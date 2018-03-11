using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;
using dataprocessor.Compilers;
using dataprocessor.Old;
using dataprocessor.benchmarks.Utilities;

namespace dataprocessor.benchmarks
{
    [MemoryDiagnoser]
    public class OneIn_OneOut_ChainedProcessors
    {
        [Params(100)]
        public int RunLength;

        Writer<int> _optimal;
        Writer<int> _naive;
        Writer<int> _actual;
        Writer<int> _actualWithBuilder;
        Writer<int> _dynamicMethod;
        Writer<int> _reflectionEmit;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _naive = Setup(new NaiveDataProcessor());
            _actual = Setup(new DataProcessorBuilder());
            _actualWithBuilder = Setup(new DataProcessorBuilder(
                new MethodBuilderCompiler("OneIn_OneOut_ChainedProcessors")));
            
            var p = Expression.Parameter(typeof(int), "p");
            var expr = Expression.Lambda<Action<int>>(
                Expression.Call(
                    typeof(OneIn_OneOut_ChainedProcessors),
                    "DoNothing",
                    null,
                    Expression.Add(
                        Expression.Call(
                            typeof(OneIn_OneOut_ChainedProcessors),
                            "Plus1",
                            null,
                            p),
                        Expression.Call(
                            typeof(OneIn_OneOut_ChainedProcessors),
                            "Plus2",
                            null,
                            p))),
                p);
            _dynamicMethod = new ActionWriter<int>(expr.Compile());

            _optimal = new ActionWriter<int>(i =>
            {
                var tmp1 = Plus1(i);
                var tmp2 = Plus2(i);
                DoNothing(tmp1 + tmp2);
            });

            var myAsmBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(
                new AssemblyName { Name = "OneIn_OneOut_ChainedProcessors" },
                AssemblyBuilderAccess.RunAndCollect);
            var myModule = myAsmBuilder.DefineDynamicModule("MyDynamicAsm");
            var myTypeBld = myModule.DefineType("MyDynamicType", TypeAttributes.Public);
            var myMthdBld = myTypeBld.DefineMethod(
                "UsingReflectionEmit",
                MethodAttributes.Public | MethodAttributes.Static,
                typeof(void),
                new[] { typeof(int) });

            expr.CompileToMethod(myMthdBld);

            var newType = myTypeBld.CreateType();
            _reflectionEmit = new ActionWriter<int>((Action<int>)Delegate.CreateDelegate(
                typeof(Action<int>),
                newType.GetMethod(myMthdBld.Name)));
        }

        [Benchmark]
        public void Optimal() => Run(_optimal, RunLength);

        [Benchmark(Baseline = true)]
        public void DynamicMethod() => Run(_dynamicMethod, RunLength);

        [Benchmark]
        public void Naive() => Run(_naive, RunLength);

        [Benchmark]
        public void Actual() => Run(_actual, RunLength);

        [Benchmark]
        public void ActualWithBuilder() => Run(_actualWithBuilder, RunLength);

        [Benchmark]
        public void UsingReflectionEmit() => Run(_reflectionEmit, RunLength);

        static Writer<int> Setup(IDataProcessorBuilder b)
        {
            var w = b.AddInput<int>("in");
            b.AddProcessor<int, int>("in", "tmp1", Plus1);
            b.AddProcessor<int, int>("in", "tmp2", Plus2);
            b.AddProcessor<int, int, int>("tmp1", "tmp2", "out", Add);
            b.AddListener<int>("out", DoNothing);
            b.Build();

            return w;
        }

        static void Run(Writer<int> w, int runLength)
        {
            while (runLength-- > 0)
            {
                w.Send(runLength);
            }
        }

        public static int Plus1(int i) => i + 1;
        public static int Plus2(int i) => i + 2;
        public static int Add(int i, int j) => i + j;
        public static void DoNothing(int _) { }
    }
}

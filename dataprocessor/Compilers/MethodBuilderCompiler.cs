using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using dataprocessor.Expressions;

namespace dataprocessor.Compilers
{
#if NET461
	public sealed class MethodBuilderCompiler : ICompiler
	{
		private class AddFieldsForConstantsVisitor : ExpressionVisitor
		{
			public readonly Dictionary<ConstantExpression, FieldInfo> Fields
				= new Dictionary<ConstantExpression, FieldInfo>();
			private readonly TypeBuilder _tb;

			public AddFieldsForConstantsVisitor(TypeBuilder tb)
			{
				_tb = tb;
			}

			protected override Expression VisitConstant(ConstantExpression node)
			{
				FieldInfo f;
				if (!Fields.TryGetValue(node, out f))
				{
					f = _tb.DefineField(
					   "_" + Fields.Count,
					   node.Type,
						FieldAttributes.Public | FieldAttributes.Static);

					Fields.Add(node, f);
				}

				return Expression.Field(null, f);
			}
		}

		private const string MethodName = "Invoke";
		private readonly AssemblyName _assemblyName;
		private readonly ModuleBuilder _module;

		public MethodBuilderCompiler()
			: this(Guid.NewGuid().ToString())
		{
		}

		public MethodBuilderCompiler(string assemblyName)
			: this(new AssemblyName(assemblyName))
		{
		}

		public MethodBuilderCompiler(AssemblyName assemblyName)
		{
			if (assemblyName == null)
				throw new ArgumentNullException(nameof(assemblyName));
			_assemblyName = assemblyName;

			var assembly = AppDomain.CurrentDomain.DefineDynamicAssembly(
				assemblyName, AssemblyBuilderAccess.RunAndCollect);
			_module = assembly.DefineDynamicModule(assemblyName.Name);
		}

		public Delegate Compile(string name, LambdaExpression expression)
		{
			if (expression == null)
				throw new ArgumentNullException(nameof(expression));
			if (name == null)
				throw new ArgumentNullException(nameof(name));

			using (Timer.Step("MethodBuilderCompiler.Compile"))
			{
				expression.AssertNoPrivateMethods();

				var typeB = _module.DefineType(name, TypeAttributes.Public);

				var v = new AddFieldsForConstantsVisitor(typeB);
				expression = v.VisitAndConvert(expression, nameof(Compile));

				var methodB = typeB.DefineMethod(
					MethodName,
					MethodAttributes.Public | MethodAttributes.Static,
					expression.ReturnType,
					expression.Parameters.Select(p => p.Type).ToArray());

				expression.CompileToMethod(methodB);

				var type = typeB.CreateType();

				foreach (var f in v.Fields)
				{
					var fi = type.GetField(f.Value.Name);
					fi.SetValue(null, f.Key.Value);
				}

				var method = type.GetMethod(MethodName);
				var del = Delegate.CreateDelegate(expression.Type, method);
				return del;
			}
		}
	}
#endif
}

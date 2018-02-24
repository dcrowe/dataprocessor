using System;
using System.Diagnostics;

namespace dataprocessor.tests
{
    public struct Timer : IDisposable
    {
        public static Timer Step(string name)
        {
            return new Timer(name);
        }

        private readonly string _name;
        private readonly Stopwatch _sw;

        public Timer(string name)
        {

            _name = name;
            _sw = new Stopwatch();
            _sw.Start();
        }

        public void Stop()
        {
            _sw.Stop();
            Console.Out.WriteLine($"{_name}: {_sw.Elapsed.TotalMilliseconds:0.##}ms");
        }

        void IDisposable.Dispose()
        {
            Stop();  
        }
    }
}

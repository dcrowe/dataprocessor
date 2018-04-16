using System;
using System.Diagnostics;

namespace dataprocessor
{
    internal class Timer : IDisposable
    {
        public static Timer Step(string name)
        {
#if DEBUG
            return new Timer(name);
#else   
            return null;
#endif
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
            Logger.WriteLine($"{_name}: {_sw.Elapsed.TotalMilliseconds:0.##}ms");
        }

        void IDisposable.Dispose()
        {
            Stop();  
        }
    }
}

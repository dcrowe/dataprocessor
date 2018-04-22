using System;
using System.Diagnostics;

namespace dataprocessor
{
    internal class Timer : IDisposable
    {
        public static Timer Step(string name)
        {
            if (Log.IsVerbose)
                return new Timer(name);
            else
                return null;
        }

        private readonly string _name;
        private readonly Stopwatch _sw;

        public Timer(string name)
        {
            _name = name;
            _sw = new Stopwatch();
            _sw.Start();
        }

        void IDisposable.Dispose()
        {
            _sw.Stop();
            Log.Verbose($"{_name}: {_sw.Elapsed.TotalMilliseconds:0.##}ms");
        }
    }
}

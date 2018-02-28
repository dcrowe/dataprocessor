using System;

namespace dataprocessor.tests.Utilities
{
    public class ActionWriter<T> : IWriter<T>
    {
        private readonly Action<T> _action;

        public ActionWriter(Action<T> action)
        {
            _action = action;
        }

        void IWriter<T>.Send(T value)
        {
            _action(value);
        }
    }
}

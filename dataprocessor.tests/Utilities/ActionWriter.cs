using System;

namespace dataprocessor.tests.Utilities
{
    public sealed class ActionWriter<T> : IWriter<T>
    {
        private readonly Action<T> _action;

        public ActionWriter(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            _action = action;
        }

        void IWriter<T>.Send(T value)
        {
            _action(value);
        }

        public void Send(T value)
        {
            _action(value);
        }
    }
}

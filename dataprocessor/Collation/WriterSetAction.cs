using System;
namespace dataprocessor.Collation
{
    public class WriterSetAction<T> : Writer<T>, ICanSetAction
    {
        public virtual Type ActionType => typeof(Action<T>);

        public virtual void SetAction(Delegate action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            if (action.GetType() != ActionType)
                throw new ArgumentException(nameof(action));

            var a = (Action<T>)action;
            base.SetAction(a);
        }
    }
}

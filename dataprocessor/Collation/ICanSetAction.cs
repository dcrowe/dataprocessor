using System;
namespace dataprocessor.Collation
{
    public interface ICanSetAction
    {
        Type ActionType { get; }
        void SetAction(Delegate action);
    }
}

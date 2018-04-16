using System;
namespace dataprocessor.Collation
{
    public class NodeSetAction : ICanSetAction
    {
        private readonly object _node;
        private readonly Type _actionType;

        public NodeSetAction(object node, Type actionType)
        {
            _node = node;
            _actionType = actionType;
        }

        public Type ActionType => _actionType;

        public void SetAction(Delegate action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            if (action.GetType() != ActionType)
                throw new ArgumentException(nameof(action));
            
            var meth = _node.GetType().GetMethod("SetAction");
            meth.Invoke(_node, new[] { action });
        }
    }
}

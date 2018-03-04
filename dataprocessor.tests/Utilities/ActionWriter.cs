﻿using System;

namespace dataprocessor.tests.Utilities
{
    public sealed class ActionWriter<T> : Writer<T>
    {
        public ActionWriter(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));
            SetAction(action);
        }
    }
}

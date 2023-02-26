using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
    public partial struct UniTask
    {
        public static UniTask WaitUntil(Func<bool> predicate, CancellationToken cancellationToken)
        {
            return WaitUntil(predicate, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask WaitWhile(Func<bool> predicate, CancellationToken cancellationToken)
        {
            return WaitWhile(predicate, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, CancellationToken cancellationToken)
            where T : class
        {
            return WaitUntilValueChanged(target, monitorFunction, PlayerLoopTiming.Update, null, cancellationToken);
        }

        public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, PlayerLoopTiming monitorTiming, CancellationToken cancellationToken)
            where T : class
        {
            return WaitUntilValueChanged(target, monitorFunction, monitorTiming, null, cancellationToken);
        }

        public static UniTask<U> WaitUntilValueChanged<T, U>(T target, Func<T, U> monitorFunction, IEqualityComparer<U> equalityComparer, CancellationToken cancellationToken)
            where T : class
        {
            return WaitUntilValueChanged(target, monitorFunction, PlayerLoopTiming.Update, equalityComparer, cancellationToken);
        }
    }
}

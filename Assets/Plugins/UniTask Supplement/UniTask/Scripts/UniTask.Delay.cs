using System;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
    public partial struct UniTask
    {
        public static UniTask DelayFrame(int delayFrameCount, CancellationToken cancellationToken)
        {
            return DelayFrame(delayFrameCount, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask Delay(int millisecondsDelay, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, false, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask Delay(int millisecondsDelay, bool ignoreTimeScale, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, ignoreTimeScale, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask Delay(TimeSpan delayTimeSpan, CancellationToken cancellationToken)
        {
            return Delay(delayTimeSpan, false, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask Delay(TimeSpan delayTimeSpan, bool ignoreTimeScale, CancellationToken cancellationToken)
        {
            return Delay(delayTimeSpan, ignoreTimeScale, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask Delay(int millisecondsDelay, DelayType delayType, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, delayType, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask Delay(TimeSpan delayTimeSpan, DelayType delayType, CancellationToken cancellationToken)
        {
            return Delay(delayTimeSpan, delayType, PlayerLoopTiming.Update, cancellationToken);
        }
    }
}

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

#if !UNITASK_SUPPLEMENT_DISABLE_DELAY_MILLISECONDS
        public static UniTask DelayMilliseconds(int millisecondsDelay, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, false, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask DelayMilliseconds(int millisecondsDelay, bool ignoreTimeScale, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, ignoreTimeScale, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask DelayMilliseconds(int millisecondsDelay, bool ignoreTimeScale, PlayerLoopTiming delayTiming, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, ignoreTimeScale, delayTiming, cancellationToken);
        }

        public static UniTask DelayMilliseconds(int millisecondsDelay, DelayType delayType, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, delayType, PlayerLoopTiming.Update, cancellationToken);
        }

        public static UniTask DelayMilliseconds(int millisecondsDelay, DelayType delayType, PlayerLoopTiming delayTiming, CancellationToken cancellationToken)
        {
            return Delay(millisecondsDelay, delayType, delayTiming, cancellationToken);
        }
#endif
    }
}

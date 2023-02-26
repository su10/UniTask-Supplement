#if UNITASK_SUPPLEMENT_DOTWEEN_SUPPORT
using System.Threading;
using DG.Tweening;

namespace Cysharp.Threading.Tasks
{
    public static partial class DOTweenAsyncExtensions
    {
        private const TweenCancelBehaviour DefaultTweenCancelBehaviour =
#if UNITASK_SUPPLEMENT_DOTWEEN_SUPPORT_USE_ORIGINAL_DEFAULT_TWEEN_CANCEL_BEHAVIOUR
            TweenCancelBehaviour.Kill;
#else
            TweenCancelBehaviour.KillAndCancelAwait;
#endif

        public static UniTask ToUniTask(this Tween tween, CancellationToken cancellationToken)
        {
            return ToUniTask(tween, DefaultTweenCancelBehaviour, cancellationToken);
        }

        public static UniTask AwaitForComplete(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForComplete(tween, DefaultTweenCancelBehaviour, cancellationToken);
        }

        public static UniTask AwaitForPause(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForPause(tween, DefaultTweenCancelBehaviour, cancellationToken);
        }

        public static UniTask AwaitForPlay(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForPlay(tween, DefaultTweenCancelBehaviour, cancellationToken);
        }

        public static UniTask AwaitForRewind(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForRewind(tween, DefaultTweenCancelBehaviour, cancellationToken);
        }

        public static UniTask AwaitForStepComplete(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForStepComplete(tween, DefaultTweenCancelBehaviour, cancellationToken);
        }
    }
}
#endif

#if UNITASK_SUPPLEMENT_DOTWEEN_SUPPORT
using System.Threading;
using DG.Tweening;

namespace Cysharp.Threading.Tasks
{
    public static partial class DOTweenAsyncExtensions
    {
        public static UniTask ToUniTask(this Tween tween, CancellationToken cancellationToken)
        {
            return ToUniTask(tween, TweenCancelBehaviour.Kill, cancellationToken);
        }

        public static UniTask AwaitForComplete(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForComplete(tween, TweenCancelBehaviour.Kill, cancellationToken);
        }

        public static UniTask AwaitForPause(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForPause(tween, TweenCancelBehaviour.Kill, cancellationToken);
        }

        public static UniTask AwaitForPlay(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForPlay(tween, TweenCancelBehaviour.Kill, cancellationToken);
        }

        public static UniTask AwaitForRewind(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForRewind(tween, TweenCancelBehaviour.Kill, cancellationToken);
        }

        public static UniTask AwaitForStepComplete(this Tween tween, CancellationToken cancellationToken)
        {
            return AwaitForStepComplete(tween, TweenCancelBehaviour.Kill, cancellationToken);
        }
    }
}
#endif

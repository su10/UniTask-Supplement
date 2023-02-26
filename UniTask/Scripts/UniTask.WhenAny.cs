#if !UNITASK_SUPPLEMENT_DISABLE_WHEN_ANY
using System;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
    public partial struct UniTask
    {
        public static async UniTask<(bool hasResultLeft, T result)> WhenAny<T>(Func<CancellationToken, UniTask<T>> leftTaskFunc, Func<CancellationToken, UniTask> rightTaskFunc, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (bool hasResultLeft, T result) result;

            try
            {
                result = await WhenAny(leftTaskFunc(cts.Token), rightTaskFunc(cts.Token));
                cts.Cancel();
            }
            catch (OperationCanceledException ex) when (ex.CancellationToken == cts.Token)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    throw new OperationCanceledException(ex.Message, ex, cancellationToken);
                }

                throw;
            }
            finally
            {
                cts.Dispose();
            }

            return result;
        }
    }
}
#endif

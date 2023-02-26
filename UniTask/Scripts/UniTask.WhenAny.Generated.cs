#if !UNITASK_SUPPLEMENT_DISABLE_WHEN_ANY
using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using Cysharp.Threading.Tasks.Internal;

namespace Cysharp.Threading.Tasks
{
    public partial struct UniTask
    {
        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            Func<CancellationToken, UniTask<T>> taskFunc9,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            Func<CancellationToken, UniTask<T>> taskFunc9,
            Func<CancellationToken, UniTask<T>> taskFunc10,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            Func<CancellationToken, UniTask<T>> taskFunc9,
            Func<CancellationToken, UniTask<T>> taskFunc10,
            Func<CancellationToken, UniTask<T>> taskFunc11,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            Func<CancellationToken, UniTask<T>> taskFunc9,
            Func<CancellationToken, UniTask<T>> taskFunc10,
            Func<CancellationToken, UniTask<T>> taskFunc11,
            Func<CancellationToken, UniTask<T>> taskFunc12,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            Func<CancellationToken, UniTask<T>> taskFunc9,
            Func<CancellationToken, UniTask<T>> taskFunc10,
            Func<CancellationToken, UniTask<T>> taskFunc11,
            Func<CancellationToken, UniTask<T>> taskFunc12,
            Func<CancellationToken, UniTask<T>> taskFunc13,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            Func<CancellationToken, UniTask<T>> taskFunc9,
            Func<CancellationToken, UniTask<T>> taskFunc10,
            Func<CancellationToken, UniTask<T>> taskFunc11,
            Func<CancellationToken, UniTask<T>> taskFunc12,
            Func<CancellationToken, UniTask<T>> taskFunc13,
            Func<CancellationToken, UniTask<T>> taskFunc14,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token),
                    taskFunc14(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T result)> WhenAny<T>(
            Func<CancellationToken, UniTask<T>> taskFunc1,
            Func<CancellationToken, UniTask<T>> taskFunc2,
            Func<CancellationToken, UniTask<T>> taskFunc3,
            Func<CancellationToken, UniTask<T>> taskFunc4,
            Func<CancellationToken, UniTask<T>> taskFunc5,
            Func<CancellationToken, UniTask<T>> taskFunc6,
            Func<CancellationToken, UniTask<T>> taskFunc7,
            Func<CancellationToken, UniTask<T>> taskFunc8,
            Func<CancellationToken, UniTask<T>> taskFunc9,
            Func<CancellationToken, UniTask<T>> taskFunc10,
            Func<CancellationToken, UniTask<T>> taskFunc11,
            Func<CancellationToken, UniTask<T>> taskFunc12,
            Func<CancellationToken, UniTask<T>> taskFunc13,
            Func<CancellationToken, UniTask<T>> taskFunc14,
            Func<CancellationToken, UniTask<T>> taskFunc15,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T result) result = default;

            try
            {
                result = await WhenAny<T>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token),
                    taskFunc14(cts.Token),
                    taskFunc15(cts.Token)
                );

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

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            Func<CancellationToken, UniTask> taskFunc9,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            Func<CancellationToken, UniTask> taskFunc9,
            Func<CancellationToken, UniTask> taskFunc10,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            Func<CancellationToken, UniTask> taskFunc9,
            Func<CancellationToken, UniTask> taskFunc10,
            Func<CancellationToken, UniTask> taskFunc11,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            Func<CancellationToken, UniTask> taskFunc9,
            Func<CancellationToken, UniTask> taskFunc10,
            Func<CancellationToken, UniTask> taskFunc11,
            Func<CancellationToken, UniTask> taskFunc12,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            Func<CancellationToken, UniTask> taskFunc9,
            Func<CancellationToken, UniTask> taskFunc10,
            Func<CancellationToken, UniTask> taskFunc11,
            Func<CancellationToken, UniTask> taskFunc12,
            Func<CancellationToken, UniTask> taskFunc13,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            Func<CancellationToken, UniTask> taskFunc9,
            Func<CancellationToken, UniTask> taskFunc10,
            Func<CancellationToken, UniTask> taskFunc11,
            Func<CancellationToken, UniTask> taskFunc12,
            Func<CancellationToken, UniTask> taskFunc13,
            Func<CancellationToken, UniTask> taskFunc14,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token),
                    taskFunc14(cts.Token)
                );

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

            return winArgumentIndex;
        }

        /// <summary>Return value is winArgumentIndex</summary>
        public static async UniTask<int> WhenAny(
            Func<CancellationToken, UniTask> taskFunc1,
            Func<CancellationToken, UniTask> taskFunc2,
            Func<CancellationToken, UniTask> taskFunc3,
            Func<CancellationToken, UniTask> taskFunc4,
            Func<CancellationToken, UniTask> taskFunc5,
            Func<CancellationToken, UniTask> taskFunc6,
            Func<CancellationToken, UniTask> taskFunc7,
            Func<CancellationToken, UniTask> taskFunc8,
            Func<CancellationToken, UniTask> taskFunc9,
            Func<CancellationToken, UniTask> taskFunc10,
            Func<CancellationToken, UniTask> taskFunc11,
            Func<CancellationToken, UniTask> taskFunc12,
            Func<CancellationToken, UniTask> taskFunc13,
            Func<CancellationToken, UniTask> taskFunc14,
            Func<CancellationToken, UniTask> taskFunc15,
            CancellationToken cancellationToken
        )
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            int winArgumentIndex = default;

            try
            {
                winArgumentIndex = await WhenAny(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token),
                    taskFunc14(cts.Token),
                    taskFunc15(cts.Token)
                );

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

            return winArgumentIndex;
        }

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2)> WhenAny<T1, T2>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2) result = default;

            try
            {
                result = await WhenAny<T1, T2>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3)> WhenAny<T1, T2, T3>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4)> WhenAny<T1, T2, T3, T4>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5)> WhenAny<T1, T2, T3, T4, T5>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6)> WhenAny<T1, T2, T3, T4, T5, T6>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7)> WhenAny<T1, T2, T3, T4, T5, T6, T7>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, Func<CancellationToken, UniTask<T9>> taskFunc9, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, Func<CancellationToken, UniTask<T9>> taskFunc9, Func<CancellationToken, UniTask<T10>> taskFunc10, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, Func<CancellationToken, UniTask<T9>> taskFunc9, Func<CancellationToken, UniTask<T10>> taskFunc10, Func<CancellationToken, UniTask<T11>> taskFunc11, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, Func<CancellationToken, UniTask<T9>> taskFunc9, Func<CancellationToken, UniTask<T10>> taskFunc10, Func<CancellationToken, UniTask<T11>> taskFunc11, Func<CancellationToken, UniTask<T12>> taskFunc12, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12, T13 result13)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, Func<CancellationToken, UniTask<T9>> taskFunc9, Func<CancellationToken, UniTask<T10>> taskFunc10, Func<CancellationToken, UniTask<T11>> taskFunc11, Func<CancellationToken, UniTask<T12>> taskFunc12, Func<CancellationToken, UniTask<T13>> taskFunc13, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12, T13 result13) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12, T13 result13, T14 result14)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, Func<CancellationToken, UniTask<T9>> taskFunc9, Func<CancellationToken, UniTask<T10>> taskFunc10, Func<CancellationToken, UniTask<T11>> taskFunc11, Func<CancellationToken, UniTask<T12>> taskFunc12, Func<CancellationToken, UniTask<T13>> taskFunc13, Func<CancellationToken, UniTask<T14>> taskFunc14, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12, T13 result13, T14 result14) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token),
                    taskFunc14(cts.Token)
                );

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

        public static async UniTask<(int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12, T13 result13, T14 result14, T15 result15)> WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<CancellationToken, UniTask<T1>> taskFunc1, Func<CancellationToken, UniTask<T2>> taskFunc2, Func<CancellationToken, UniTask<T3>> taskFunc3, Func<CancellationToken, UniTask<T4>> taskFunc4, Func<CancellationToken, UniTask<T5>> taskFunc5, Func<CancellationToken, UniTask<T6>> taskFunc6, Func<CancellationToken, UniTask<T7>> taskFunc7, Func<CancellationToken, UniTask<T8>> taskFunc8, Func<CancellationToken, UniTask<T9>> taskFunc9, Func<CancellationToken, UniTask<T10>> taskFunc10, Func<CancellationToken, UniTask<T11>> taskFunc11, Func<CancellationToken, UniTask<T12>> taskFunc12, Func<CancellationToken, UniTask<T13>> taskFunc13, Func<CancellationToken, UniTask<T14>> taskFunc14, Func<CancellationToken, UniTask<T15>> taskFunc15, CancellationToken cancellationToken)
        {
            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            (int winArgumentIndex, T1 result1, T2 result2, T3 result3, T4 result4, T5 result5, T6 result6, T7 result7, T8 result8, T9 result9, T10 result10, T11 result11, T12 result12, T13 result13, T14 result14, T15 result15) result = default;

            try
            {
                result = await WhenAny<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
                    taskFunc1(cts.Token),
                    taskFunc2(cts.Token),
                    taskFunc3(cts.Token),
                    taskFunc4(cts.Token),
                    taskFunc5(cts.Token),
                    taskFunc6(cts.Token),
                    taskFunc7(cts.Token),
                    taskFunc8(cts.Token),
                    taskFunc9(cts.Token),
                    taskFunc10(cts.Token),
                    taskFunc11(cts.Token),
                    taskFunc12(cts.Token),
                    taskFunc13(cts.Token),
                    taskFunc14(cts.Token),
                    taskFunc15(cts.Token)
                );

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

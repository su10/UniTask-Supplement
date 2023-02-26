# UniTask Supplement
Supplemental codes for UniTask.

Mainly adds shorthand methods that do not require `cancellationToken:`.

## Features
### `Delay***()` Shorthands & Aliases
```csharp
// UniTask
await UniTask.DelayFrame(5, cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.DelayFrame(5, cancellationToken);
```

```csharp
// UniTask
await UniTask.Delay(500, cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.Delay(500, cancellationToken);
```

```csharp
// UniTask
await UniTask.Delay(TimeSpan.FromMilliseconds(500), cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.Delay(TimeSpan.FromMilliseconds(500), cancellationToken);
```

```csharp
// UniTask
await UniTask.Delay(500, cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.DelayMilliseconds(500, cancellationToken);
```

You can disable `DelayMilliseconds()` to define `UNITASK_SUPPLEMENT_DISABLE_DELAY_MILLISECONDS`.

```csharp
// UniTask
await UniTask.Delay(1500, cancellationToken: cancellationToken);
await UniTask.Delay(TimeSpan.FromSeconds(1.5f), cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.DelaySeconds(1.5f, cancellationToken);
```

You can disable `DelaySeconds()` to define `UNITASK_SUPPLEMENT_DISABLE_DELAY_SECONDS`.

### `Wait***()` Shorthands
```csharp
// UniTask
await UniTask.WaitUntil(() => flag, cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.WaitUntil(() => flag, cancellationToken);
```

```csharp
// UniTask
await UniTask.WaitWhile(() => flag, cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.WaitWhile(() => flag, cancellationToken);
```

```csharp
// UniTask
await UniTask.WaitUntilValueChanged(transform, x => x.position, cancellationToken: cancellationToken);

// with UniTask Supplement
await UniTask.WaitUntilValueChanged(transform, x => x.position, cancellationToken);
```

### `WhenAny(.., cancellationToken)` Shorthands
```csharp
// UniTask
{
    var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
    (bool hasResultLeft, T result) result;

    try
    {
        result = await WhenAny(TaskA(cts.Token), TaskB(cts.Token));
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

    ...
}

// with UniTask Supplement
var (hasResultLeft, result) = await UniTask.WhenAny<T>(
        cancel => TaskA(cancel),
        cancel => TaskB(cancel),
        cancellationToken
    );
```

```csharp
// UniTask
{
    var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
    (int winArgumentIndex, T result) result = default;

    try
    {
        result = await WhenAny<T>(
            taskFunc1(cts.Token),
            taskFunc2(cts.Token),
            ..
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

    ...
}

// with UniTask Supplement
var (winArgumentIndex, result) = await UniTask.WhenAny<T>(
        cancel => TaskA(cancel),
        cancel => TaskB(cancel),
        ..,
        cancellationToken
    );
```

You can disable `WhenAny(.., cancellationToken)` to define `UNITASK_SUPPLEMENT_DISABLE_WHEN_ANY`.

### DOTween integration
#### Shorthands
```csharp
// UniTask
await tween.ToUniTask(cancellationToken: cancellationToken);
await tween.AwaitForComplete(cancellationToken: cancellationToken);
await tween.AwaitForPause(cancellationToken: cancellationToken);
await tween.AwaitForPlay(cancellationToken: cancellationToken);
await tween.AwaitForRewind(cancellationToken: cancellationToken);
await tween.AwaitForStepComplete(cancellationToken: cancellationToken);

// with UniTask Supplement
await tween.ToUniTask(cancellationToken);
await tween.AwaitForComplete(cancellationToken);
await tween.AwaitForPause(cancellationToken);
await tween.AwaitForPlay(cancellationToken);
await tween.AwaitForRewind(cancellationToken);
await tween.AwaitForStepComplete(cancellationToken);
```

You can **enable** this behavior to define `UNITASK_SUPPLEMENT_DOTWEEN_SUPPORT` instead of `UNITASK_DOTWEEN_SUPPORT`.

#### Change default value of `TweenCancelBehaviour` to `KillAndCancelAwait`
See [this thread (Twitter)](https://twitter.com/ishida_gigacee/status/1569951411160645633?s=20) for why this should be.

```csharp
// UniTask
// OperationCanceledException will not be thrown when canceled.
await tween.WithCancellation(cancellationToken);
await tween.ToUniTask(cancellationToken: cancellationToken);
await tween.AwaitForComplete(cancellationToken: cancellationToken);
await tween.AwaitForPause(cancellationToken: cancellationToken);
await tween.AwaitForPlay(cancellationToken: cancellationToken);
await tween.AwaitForRewind(cancellationToken: cancellationToken);
await tween.AwaitForStepComplete(cancellationToken: cancellationToken);

// but with UniTask Supplement, OperationCanceledException will be thrown when canceled.
```

```csharp
// UniTask
await tween.ToUniTask(TweenCancelBehaviour.KillAndCancelAwait, cancellationToken);
await tween.AwaitForComplete(TweenCancelBehaviour.KillAndCancelAwait, cancellationToken);
await tween.AwaitForPause(TweenCancelBehaviour.KillAndCancelAwait, cancellationToken);
await tween.AwaitForPlay(TweenCancelBehaviour.KillAndCancelAwait, cancellationToken);
await tween.AwaitForRewind(TweenCancelBehaviour.KillAndCancelAwait, cancellationToken);
await tween.AwaitForStepComplete(TweenCancelBehaviour.KillAndCancelAwait, cancellationToken);

// with UniTask Supplement
await tween.ToUniTask(cancellationToken);
await tween.AwaitForComplete(cancellationToken);
await tween.AwaitForPause(cancellationToken);
await tween.AwaitForPlay(cancellationToken);
await tween.AwaitForRewind(cancellationToken);
await tween.AwaitForStepComplete(cancellationToken);
```

You can restore original behavior to define `UNITASK_SUPPLEMENT_DOTWEEN_SUPPORT_USE_ORIGINAL_DEFAULT_TWEEN_CANCEL_BEHAVIOUR`.

## Installation
### Install via OpenUPM (Recommended)
The package is available on the [openupm registry](https://openupm.com/). It's recommended to install it via [openupm-cli](https://github.com/openupm/openupm-cli).

`openupm add com.jagapippi.unitask-supplement`

### Install via git URL
1. Open the Package Manager
1. Press [＋▼] button and click Add package from git URL...
1. Enter the following:
   - https://github.com/su10/UniTask-Supplement.git#upm

or add a following line to dependencies field of your Packages/manifest.json.

`"com.jagapippi.unitask-supplement": "https://github.com/su10/UniTask-Supplement.git#upm"`

## License
MIT

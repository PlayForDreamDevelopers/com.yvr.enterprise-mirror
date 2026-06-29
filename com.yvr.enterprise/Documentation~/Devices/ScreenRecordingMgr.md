# ScreenRecordingMgr

> [!note]
>
> ScreenRecordingMgr is used for screen recording control.

## Main Interfaces

| Interface                             | Description |
| ------------------------------------- | ----------- |
| `StartRecordScreen()`                 | Start screen recording |
| `StopRecordScreen()`                  | Stop screen recording |
| `ScreenShot(Action<string> callback)` | Take a screenshot and return the image path through the callback |

## Example

```csharp
// Start screen recording
ScreenRecordingMgr.Instance.StartRecordScreen();

// Stop screen recording
ScreenRecordingMgr.Instance.StopRecordScreen();

// Take a screenshot
ScreenRecordingMgr.Instance.ScreenShot(path =>
{
    UnityEngine.Debug.Log($"Screen shot saved at: {path}");
});
```

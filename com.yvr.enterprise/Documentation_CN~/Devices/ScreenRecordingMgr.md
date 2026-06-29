# 录屏管理

> [!note]
>
> ScreenRecordingMgr 用于屏幕录制的控制。

## 主要接口

| 接口                                  | 说明                         |
| ------------------------------------- | ---------------------------- |
| `StartRecordScreen()`                 | 开始录制屏幕                 |
| `StopRecordScreen()`                  | 停止录制屏幕                 |
| `ScreenShot(Action<string> callback)` | 截屏，并通过回调返回图片路径 |

## 示例

```csharp
// 开始录屏
ScreenRecordingMgr.Instance.StartRecordScreen();

// 停止录屏
ScreenRecordingMgr.Instance.StopRecordScreen();

// 截屏
ScreenRecordingMgr.Instance.ScreenShot(path =>
{
    UnityEngine.Debug.Log($"Screen shot saved at: {path}");
});
```

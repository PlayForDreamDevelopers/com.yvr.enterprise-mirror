# Changelog

## [0.1.10] - 2025-09-16

### Added

- 支持开关电源键的拓展功能

## [0.1.9] - 2025-08-26

### Added

- 支持获取 Camera 到 VST Camera 的偏移量
- 支持获取 Distortion Map

## [0.1.8] - 2025-08-06

### Added

- 支持打开 Home 设置中的任意界面

## [0.1.7] - 2025-07-24

### Added

- 补充 Device.md 英文文档
- 增加获取基于 IMU 位置的相机内参外参接口

## [0.1.6] - 2025-06-26

### Added

- 添加 camera 畸变参数

## [0.1.5] - 2025-06-20

### Added

- 为TrackingCameraType添加新类型枚举

## [0.1.4] - 2025-06-18

### Added

- 添加 LargeSpatialMgr


## [0.1.3] - 2025-06-12

### changed

- 修复无法调用切换左右手柄重定位

## [0.1.2] - 2025-06-05

### Added

- 移除 C# 中的坐标转换逻辑，适配最新的 Core SDK

## [0.1.1] - 2025-05-29

### Added

- 增加关于屏幕 etfr 设定的接口

## [0.1.0] - 2025-05-27

### Added

- 封装 AAR 中暴露的各 Java 接口，提供更易用的 C# 接口

## [0.0.16] - 2025-04-27

### Added

- 开放 kiosk mode 相关的 SetStartupApp(string packageName, bool active) 函数

## [0.0.15] - 2025-04-27

### Added

- 修正 startup App 中的字符判断错误

## [0.0.14] - 2025-04-25

### Added

- VSTCamera 增加反畸变相关处理

## [0.0.13] - 2025-04-24

### Added

- 将 AppMgr 内的函数改为属性

## [0.0.12] - 2025-04-24

### Added

- 增加 AppMgr ，它提供配置开机自启动应用等功能

## [0.0.11] - 2025-04-16

### Added

- 增加 IPD 设置相关的接口

## [0.0.10] - 2025-03-18

### Added

- 删除 EyeTracking Camera 接口

## [0.0.9] - 2025-03-18

### Added

- 增加 Unsubscribe 接口

## [0.0.8] - 2025-03-17

### Added

- 增加获取 Tracking Camera 信息的接口

## [0.0.7] - 2025-03-14

### Added

- 添加渲染倍率接口

## [0.0.6] - 2025-03-07

### Changed

- 将 Android Device Core 作为弱依赖

## [0.0.5] - 2025-03-07

### Added

- 增加 Device Data 相关接口

### Changed

- 修改 LBE 接口的命名空间

## [0.0.4] - 2025-03-06

### Added

- 增加 LBE 相关接口

## [0.0.3] - 2024-11-07

### Changed

- 更新 GetVSTCameraIntrinsicExtrinsic 接口参数，区分左右眼

## [0.0.2] - 2024-10-28

### Changed

- 过滤 dlopen 或 dlsym 失败时的调用

## [0.0.1] - 2024-10-25

### Added

- 增加 VST Camera 相关接口

# `hahaha_thread_pause` 處理方法

## 適用情境

- `thread_pause` 子類別一律繼承 `hahahalib.hahaha_thread_pause`。
- `hahaha_thread_pause` 適合用在啟用後持續運作、停用後停止的背景流程。

## 核心結構

- 子類別自行維護 `Is_Enabled_` 之類的啟停旗標。
- `Enabled()` 負責防止重複啟動，`Disabled()` 負責切換停止旗標。
- `Handle()` 直接寫主要持續處理流程，不使用 command queue。

## Enabled / Disabled

- `Enabled()` 內先檢查 `Is_Close_` 與目前是否已啟用，避免重複喚醒或關閉後誤啟動。
- 通過檢查後先把 `Is_Enabled_` 設為 `true`，再呼叫 `base.Enabled()`。
- `Disabled()` 建議只負責把 `Is_Enabled_` 切回 `false`，讓 `Handle()` 內的 while 條件自然結束。

## Handle 實作

- 若需要持續輪詢或週期更新，可用 `while (!Is_Close_ && Is_Enabled_)` 控制生命週期。
- while 內先產生本地 `result_` 或狀態值，再統一回 UI 更新。
- 週期間隔直接寫在 `Handle()` 內，例如 `Thread.Sleep(1000)`。

## UI 回拋

- 背景處理若要更新 UI，一律透過 `BeginInvoke(...)` 或 `Invoke(...)` 回 UI thread。
- 更新前先檢查目標 form 非 null 且未釋放。
- 若主要顯示目標是某個子表單，可直接對該 form 做 `BeginInvoke(...)`。
- 若 UI 更新目標已收斂到單一 form 控制項，就不要再平行建立額外包裝方法。

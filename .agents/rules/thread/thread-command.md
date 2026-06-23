# `hahaha_thread_command` 處理方法

## 適用情境

- `thread_command` 子類別一律繼承 `hahahalib.hahaha_thread_command`。
- `hahaha_thread_command` 適合用在一次丟多筆命令、由背景佇列逐筆處理的需求。

## 核心結構

- command code 使用獨立 static class 常數管理。
- parameter class 獨立宣告，欄位一律使用 `public`。
- `Handle(...)` 只負責 command routing，不堆大段業務邏輯。
- 實際處理邏輯拆到 `On_Command_xxx(...)`。
- 對外呼叫入口統一用 `Add_Command_xxx(...)` 封裝。

## Handle 分流

- `Handle(...)` 內先依 `cmd.Code_` 分流。
- 若同一功能同時支援基本型別與 parameter object，可先把兩種輸入轉成同一份本地變數，再共用同一個 `On_Command_xxx(...)`。
- 若另外提供 `*_OBJECT` command code，則在對應分支中解開 parameter class 後呼叫 `On_Command_xxx_Object(...)`。
- `Handle(...)` 完成分流後維持明確回傳值，例如 `0` 或 `-1`。

## On_Command 實作

- `On_Command_xxx(...)` 放主要業務邏輯，例如計時、等待、組字串、整理結果。
- 若 thread 內需要共用 timer、log、json、setting，優先沿用 `hahaha_define.cs` 內已建立的靜態物件。
- `On_Command_xxx_Object(...)` 建議只做 null 檢查、欄位解包與轉呼叫 `On_Command_xxx(...)`，不要複製主要邏輯。

## Add_Command 封裝

- `Add_Command_xxx(...)` 內部負責建立 `hahaha_thread_command_command`、設定 `Code_`、`Parameter_`、enqueue、`Event_Run_.Set()`。
- 若 `Event_Run_ == null`，明確回傳 `-1`。
- 若同一需求同時提供基本型別版與物件參數版，兩者都應維持相同主要處理流程。
- `Add_Command_xxx_Object(...)` 若只是把基本型別包成 parameter object，應在方法內完成包裝後，再用對應 `*_OBJECT` command code enqueue。

## UI 回拋

- 背景處理完若要更新 UI，一律透過 `BeginInvoke(...)` 或 `Invoke(...)` 回 UI thread。
- 更新前先檢查目標 form 非 null 且未釋放。
- UI 更新目標若已統一收斂到某個 form 或某個控制項，就不要再平行建立另一套頁面包裝方法。

# AGENTS

本檔是 `D:\vs\c#\c_sharp_base` 的規則入口，適用於本 C# WinForms 解決方案。

## 讀取原則

- 每次處理需求前，先讀本檔。
- 先縮小需求範圍，再打開直接相關檔案，不要一開始全專案掃描。
- `.agents/` 只保留對本 C# WinForms 專案仍有用的規則。
- `.agent_customs/rules/` 放各自獨立頁面或各功能自己專屬的規則，方便各頁面獨立處理。
- 規則衝突優先順序：
  1. 本檔「最高優先」
  2. 使用者當前需求
  3. `.agents/rules/` 對應規則檔
  4. `.agent_customs/rules/` 對應頁面或功能的專屬規則
  5. `hahahalib` / `hahahaUIlib` 既有實作慣例
  6. `c_sharp_base` 主專案既有實作慣例

## 最高優先

- 本專案以 C# / .NET WinForms 為主，不採 Laravel / Web 專案流程。
- 核心搭建順序固定為：`hahahalib` -> `hahahaUIlib` -> .NET 內建能力 -> 已有 NuGet -> 新增 NuGet。
- 能重用核心庫就不要先把邏輯寫死在 `c_sharp_base`。
- 所有後續新增的 class 欄位一律使用 `public`。
- 不要未經同意新增 NuGet 套件、改大目錄結構、刪除既有檔案、或大幅重命名核心型別。
- 不要隨意修改 `.csproj` 的 TargetFramework、平台目標、輸出設定或套件版本。
- 修改 WinForms 表單時，要同時注意 `.cs`、`.Designer.cs`、`.resx` 一致性。
- 有程式碼異動時，結束前至少做最小範圍編譯驗證；若無法執行，要明確說明原因。

## 規則索引

### 工作流程 / 有順序規則

- [`.agents/rules/workflow/00-project-policy.md`](.agents/rules/workflow/00-project-policy.md)
- [`.agents/rules/workflow/01-feature-placement.md`](.agents/rules/workflow/01-feature-placement.md)
- [`.agents/rules/workflow/02-form-initialization.md`](.agents/rules/workflow/02-form-initialization.md)
- [`.agents/rules/workflow/03-thread-command.md`](.agents/rules/workflow/03-thread-command.md)
- [`.agents/rules/workflow/04-thread-pause.md`](.agents/rules/workflow/04-thread-pause.md)

### 命名規則

- [`.agents/rules/naming/project-naming.md`](.agents/rules/naming/project-naming.md)

### Form 共用規則

- [`.agents/rules/form/common-form.md`](.agents/rules/form/common-form.md)
- [`.agents/rules/form/main-form.md`](.agents/rules/form/main-form.md)
- [`.agents/rules/form/general-form.md`](.agents/rules/form/general-form.md)
- [`.agents/rules/form/setting-form.md`](.agents/rules/form/setting-form.md)

### Thread 共用規則

- [`.agents/rules/thread/thread-command.md`](.agents/rules/thread/thread-command.md)
- [`.agents/rules/thread/thread-pause.md`](.agents/rules/thread/thread-pause.md)

### Setting 共用規則

- [`.agents/rules/setting/setting-box.md`](.agents/rules/setting/setting-box.md)

### Form 客製 / 獨立規則

- [`.agent_customs/rules/form/README.md`](.agent_customs/rules/form/README.md)
- [`.agent_customs/rules/form/hahaha_form_main.md`](.agent_customs/rules/form/hahaha_form_main.md)
- [`.agent_customs/rules/form/hahaha_form_test.md`](.agent_customs/rules/form/hahaha_form_test.md)
- [`.agent_customs/rules/form/hahaha_form_setting.md`](.agent_customs/rules/form/hahaha_form_setting.md)

## 需求對應讀法

- 命名、類別、欄位、常數、enum：
  - 先讀 `.agents/rules/naming/project-naming.md`
- 判斷功能要放主專案、`hahahalib`、`hahahaUIlib` 或 NuGet：
  - 先讀 `.agents/rules/workflow/00-project-policy.md`
  - 再讀 `.agents/rules/workflow/01-feature-placement.md`
- WinForms 啟動流程、主畫面、事件：
  - 先讀 `.agents/rules/form/common-form.md`
  - 再讀 `.agents/rules/form/main-form.md`
  - 再讀 `.agents/rules/form/general-form.md`
  - 先讀 `.agents/rules/workflow/02-form-initialization.md`
  - 再讀 `D:\vs\c#\c_sharp_base\c_sharp_base\Program.cs`
  - 再讀 `D:\vs\c#\c_sharp_base\c_sharp_base\define\hahaha_define.cs`
  - 再讀 `D:\vs\c#\c_sharp_base\c_sharp_base\form\`
  - `hahaha_define.cs` 是全專案共用物件入口
  - 主頁規則、一般頁面規則已抽到 `.agents/rules/form/`，後續不要把單一 `.cs` 檔當唯一規範來源
  - 若是某個頁面自己的獨立規則，讀 `D:\vs\c#\c_sharp_base\.agent_customs\rules\` 下對應分類
  - `hahaha_form_main`、`hahaha_form_test`、`hahaha_form_setting` 的處理方式已抽到 `.agent_customs/rules/form/`
- 啟動即顯示 form / 初始化建立子表單：
  - 先讀 `.agents/rules/form/common-form.md`
  - 再讀 `.agents/rules/form/main-form.md`
  - 再讀 `.agents/rules/form/general-form.md`
  - 先讀 `.agents/rules/workflow/02-form-initialization.md`
  - 再讀 `D:\vs\c#\c_sharp_base\c_sharp_base\define\hahaha_define.cs`
- 共用工具、thread、timer、log、json：
  - 先讀 `.agents/rules/workflow/00-project-policy.md`
  - 再讀 `D:\vs\c#\c_sharp_base\hahahalib\hahahalib\`
- 設定容器、設定載入、設定共用入口：
  - 先讀 `.agents/rules/setting/setting-box.md`
  - 再讀 `.agents/rules/form/setting-form.md`
  - 再讀 `D:\vs\c#\c_sharp_base\c_sharp_base\define\hahaha_define.cs`
  - 再讀 `D:\vs\c#\c_sharp_base\c_sharp_base\box\hahaha_setting_box.cs`
  - 設定容器的建立與掛載入口以 `hahaha_define.cs` 為準
- `hahaha_thread_command` / `hahaha_thread_pause` 子類別、背景處理、UI thread 回拋：
  - 先讀 `.agents/rules/thread/thread-command.md`
  - 再讀 `.agents/rules/thread/thread-pause.md`
  - 先讀 `.agents/rules/workflow/03-thread-command.md`
  - 再讀 `.agents/rules/workflow/04-thread-pause.md`
  - 再讀 `D:\vs\c#\c_sharp_base\hahahalib\hahahalib\thread\hahaha_thread_command.cs`
  - 再讀 `D:\vs\c#\c_sharp_base\hahahalib\hahahalib\thread\hahaha_thread_pause.cs`
  - 最後才讀需求直接相關的 `c_sharp_base/thread/` 子類別
  - `hahaha_thread_command_timer_test.cs` 的共用處理方法已抽到 `.agents/rules/thread/thread-command.md`，後續不要把它當唯一規範來源
  - `hahaha_thread_pause_timer_test.cs` 的共用處理方法已抽到 `.agents/rules/thread/thread-pause.md`，後續不要把它當唯一規範來源
- 可重用 UI 元件、控制項、表單基底、視覺封裝：
  - 先讀 `.agents/rules/workflow/01-feature-placement.md`
  - 再讀 `D:\vs\c#\c_sharp_base\hahahaUIlib\hahahaUIlib\`
  - 若功能其實已在 `hahahalib` 內，優先沿用既有做法
- 表單修改：
  - 先讀對應 `.cs`
  - 再讀對應 `.Designer.cs`
  - 若有資源項，再讀 `.resx`

## 分析順序

1. `AGENTS.md`
2. `.agents/AGENTS.md`
3. 需求對應規則檔
4. `c_sharp_base.sln`
5. 需求直接相關的 `.csproj`
6. `hahahalib` / `hahahaUIlib` 對應模組
7. 最後才打開 `c_sharp_base` 的具體 form、setting、thread、流程檔

避免一開始就逐檔掃描整個專案，也不要把 `bin/`、`obj/` 當主要分析來源。

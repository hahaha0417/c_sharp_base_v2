# Form 共用規則

## 共用物件入口

- `D:\vs\c#\c_sharp_base\c_sharp_base\define\hahaha_define.cs` 是全專案共用物件入口。
- 全域 form 引用、thread 物件、timer、log、json、setting 與初始化/關閉流程，都優先集中在 `hahaha_define.cs` 管理。
- form 不應各自 new 一份平行的全域物件；需要共用能力時，優先使用 `hahaha_define.cs` 內已建立的靜態物件。
- 主頁與一般頁面都可以使用 `hahaha_define.cs` 提供的共用物件，但不要在 form 內重新定義另一套全域狀態。

## 共用初始化規則

- 啟動後要立即建立或顯示的 form，統一在 `D:\vs\c#\c_sharp_base\c_sharp_base\define\hahaha_define.cs` 管理。
- `Program.cs` 只保留主啟動順序，不直接散落多個測試或子表單建立碼。
- 跨表單的建立、持有、`Show()` 時機，集中放在 `hahaha_define.cs`。
- 單一 form 內部控制項初始化留在 form 自己處理。
- 若新增共用 form/static 入口，優先沿用 `hahaha_define.cs` 既有靜態管理方式。
- `Form_Load` 主要負責初始文字、預設狀態、控制項顯示內容，不要把跨表單建立流程塞進單一 form 的 `Load`。

## 共用修改規則

- 不要把主頁與一般頁面的責任混在同一個 form 內：主頁處理全域生命週期，一般頁面處理局部功能。
- 表單修改時，先讀對應 `.cs`，再讀 `.Designer.cs`，若有資源項再讀 `.resx`。
- 修改 Designer 檔時要保守；只有需求明確涉及版面或控制項結構時才改 `.Designer.cs`。

## 驗證

- 表單或 UI 修改後，至少確認初始化流程與控制項結構沒有被破壞。

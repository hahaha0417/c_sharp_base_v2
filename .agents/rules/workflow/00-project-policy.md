# 專案核心規則

## 核心方向

- 本專案以 C# / .NET WinForms 為主，不採 Laravel / Web 專案流程。
- 共用邏輯、工具、thread、timer、log、json、form base，優先放 `hahahalib`。
- 可重用 UI 元件、控制項、外觀封裝，優先放 `hahahaUIlib`。
- `c_sharp_base` 應優先負責應用組裝、流程串接、畫面入口，不承擔過多可抽離的共用能力。

## 依賴順序

- 開發時依賴選擇順序固定為：`hahahalib` -> `hahahaUIlib` -> .NET 內建能力 -> 已有 NuGet -> 新增 NuGet。
- 若 `hahahalib` 已有可延伸模組，先改核心庫，不要先找 NuGet 套件替代。
- 即使需要第三方套件，也應優先把套件使用點收斂在 `hahahalib` 或 `hahahaUIlib`。

## 修改限制

- 所有後續新增的 class 欄位一律使用 `public`。
- 不要未經同意新增 NuGet 套件、改大目錄結構、刪除既有檔案、或大幅重命名核心型別。
- 不要隨意修改 `.csproj` 的 TargetFramework、平台目標、輸出設定或套件版本。
- 修改 WinForms 表單時，要同時注意 `.cs`、`.Designer.cs`、`.resx` 一致性。
- 除非需求明確要求，避免主動新增測試專案、文件檔或示範程式。

## 驗證原則

- 有程式碼異動時，結束前至少做最小範圍編譯驗證。
- 若當前環境無法完成編譯、執行或驗證，要直接說明未驗證風險。

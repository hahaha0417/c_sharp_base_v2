# 功能落點與架構判斷

## 專案結構

### 解決方案

- `c_sharp_base_v2.sln`
- 目前主要專案：
  - `c_sharp_base_v2/c_sharp_base_v2.csproj`
  - `hahahalib/hahahalib/hahahalib.csproj`
  - `hahahaUIlib/hahahaUIlib/hahahaUIlib.csproj`
  - `hahaha_sub_lib/hahaha_sub_lib.csproj`
  - `project/hahaha_main_dll/hahaha_main_dll.csproj`
  - `project/hahaha_sub_dll/hahaha_sub_dll.csproj`

### 應用組裝專案

- `c_sharp_base_v2/`
- 主要資料夾：
  - `Program.cs`：主啟動順序與主頁建立
  - `box/`：設定或互動封裝
  - `define/`：全域入口、定義、靜態共用物件
  - `flow/`：應用層初始化與關閉流程

### 應用畫面專案

- `project/hahaha_main_dll/`
  - `form/`：目前主頁 `hahaha_form_main` 所在位置

### 核心庫

- `hahahalib/`
  - 基礎能力與共用功能
  - 已有方向：`thread/`、`thread_pool/`、`timer/`、`log/`、`json/`、`sleep/`、`form/`、`ui/`
- `hahahaUIlib/`
  - 可重用 UI 控制項、視覺元件、表單外觀封裝

## 落點判斷

- `hahahalib` 是第一核心依賴；若已有 70% 以上可重用能力，優先擴充原模組。
- `hahahaUIlib` 是第一優先 UI 元件承載位置；若需求屬於可重用 UI，優先評估放入此庫。
- 若功能目前已存在 `hahahalib/hahahalib/ui` 或 `hahahalib/hahahalib/form`，優先沿用，不要平行造新輪子。
- 啟動順序、define 掛接、flow 串接、設定容器這類應用組裝邏輯優先留在 `c_sharp_base_v2`。
- 主頁或單一 DLL 專用畫面邏輯可留在 `project/` 專案內，不要為了抽象而拆散既有責任。
- 可能重用的邏輯或 UI，優先抽回核心庫。

## 分析順序

1. `AGENTS.md`
2. `.agents/AGENTS.md`
3. 需求直接相關的規則檔
4. `c_sharp_base_v2.sln`
5. 需求直接相關的 `.csproj`
6. `hahahalib` / `hahahaUIlib` / `hahaha_sub_lib` 對應模組
7. 最後才打開 `c_sharp_base_v2` 與 `project/` 內直接相關的 form、box、flow、thread、流程檔

避免一開始就逐檔掃描整個專案，也不要把 `bin/`、`obj/` 當主要分析來源。

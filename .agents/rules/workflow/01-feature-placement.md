# 功能落點與架構判斷

## 專案結構

### 解決方案

- `D:\vs\c#\c_sharp_base\c_sharp_base.sln`
- 目前主要專案：
  - `D:\vs\c#\c_sharp_base\c_sharp_base\c_sharp_base.csproj`
  - `D:\vs\c#\c_sharp_base\hahahalib\hahahalib\hahahalib.csproj`

### 主專案

- `D:\vs\c#\c_sharp_base\c_sharp_base`
- 主要資料夾：
  - `form/`：表單與畫面流程
  - `box/`：設定或互動封裝
  - `define/`：全域入口、定義、靜態共用物件
  - `setting/`：設定資料模型
  - `thread/`：應用層背景命令流程

### 核心庫

- `D:\vs\c#\c_sharp_base\hahahalib`
  - 基礎能力與共用功能
  - 已有方向：`thread/`、`thread_pool/`、`timer/`、`log/`、`json/`、`sleep/`、`form/`、`ui/`
- `D:\vs\c#\c_sharp_base\hahahaUIlib`
  - 可重用 UI 控制項、視覺元件、表單外觀封裝

## 落點判斷

- `hahahalib` 是第一核心依賴；若已有 70% 以上可重用能力，優先擴充原模組。
- `hahahaUIlib` 是第一優先 UI 元件承載位置；若需求屬於可重用 UI，優先評估放入此庫。
- 若功能目前已存在 `hahahalib/hahahalib/ui` 或 `hahahalib/hahahalib/form`，優先沿用，不要平行造新輪子。
- 只屬於單一專案流程的邏輯可留在 `c_sharp_base`，不要過度抽象。
- 可能重用的邏輯或 UI，優先抽回核心庫。

## 分析順序

1. `AGENTS.md`
2. `.agents/AGENTS.md`
3. 需求直接相關的規則檔
4. `c_sharp_base.sln`
5. 需求直接相關的 `.csproj`
6. `hahahalib` / `hahahaUIlib` 對應模組
7. 最後才打開 `c_sharp_base` 的具體 form、setting、thread、流程檔

避免一開始就逐檔掃描整個專案，也不要把 `bin/`、`obj/` 當主要分析來源。

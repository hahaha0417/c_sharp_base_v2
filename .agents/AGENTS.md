# .agents AGENTS

本目錄提供 `D:\vs\c#\c_sharp_base` 的代理規則輔助內容。

## 使用原則

- 先讀 `D:\vs\c#\c_sharp_base\AGENTS.md`，本檔只補充 `.agents` 目錄用途。
- 依賴選擇、專案架構分析、核心庫優先順序，以根目錄 `AGENTS.md` 為準。
- 本專案是 C# WinForms 專案，`.agents` 內只保留對 WinForms、`.NET`、`hahahalib`、`hahahaUIlib` 有幫助的內容。
- 與 Laravel、PHP、Blade、Tailwind、Eloquent、Artisan、Octane 直接相關的規則與 skill，不應再作為本專案依據。

## 目錄定位

- `.agents/rules/`
  - 以 C# / WinForms / 共用元件庫規範為主
  - `workflow/00-project-policy.md` 到 `workflow/04-thread-pause.md`：有讀取順序的流程規則，保留編號
  - `naming/project-naming.md`：命名規則，屬於用途分類，不使用編號
- `.agents/skills/`
  - 若有內容，應以目前專案可實際使用的技能或備忘為主
- `.agents/skills/說明.txt`
  - 可保留為一般說明文字
- `.agents/skills/codex參考.txt`
  - 可保留為一般參考文字

## 核心方向

- 共用基礎能力優先回到 `D:\vs\c#\c_sharp_base\hahahalib`
- 可重用 UI 能力優先回到 `D:\vs\c#\c_sharp_base\hahahaUIlib`
- `.agents` 只負責規則與輔助，不應凌駕實際程式庫結構

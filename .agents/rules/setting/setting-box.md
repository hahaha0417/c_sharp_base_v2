# `hahaha_setting_box` 設定容器規則

## 適用範圍

- 本檔適用於 `c_sharp_base/box/hahaha_setting_box.cs` 這類設定檔容器。
- 設定容器負責集中持有各設定類別，並提供整包 `Load_All()` / `Save_All()` 的統一入口。

## 容器結構

- 設定容器內以欄位方式持有各設定物件，例如 `System`、`Global`。
- 容器內欄位一律使用 `public`，方便全專案直接讀取設定值。
- 各設定物件的載入與儲存方法分開實作，例如 `Load_System()`、`Save_System()`、`Load_Global()`、`Save_Global()`。

## Load / Save 規則

- `Load_All()` 負責集中呼叫各設定區段的 `Load_xxx()`，並用整體成功/失敗回傳值表示結果。
- `Save_All()` 負責集中呼叫各設定區段的 `Save_xxx()`。
- 各 `Load_xxx()` / `Save_xxx()` 內部路徑組法保持一致，優先由 `System` 設定提供環境目錄、設定目錄、類別名、檔名等路徑資訊。
- JSON 載入與儲存優先沿用 `hahaha_define.cs` 內既有的 `hahaha.Json_`，不要在設定容器內再 new 另一份序列化工具。

## 使用方式

- 設定容器的建立集中放在 `hahaha_define.cs` 的初始化流程處理，不要在各 form、thread 或功能類別內各自 new 一份。
- `Initial_Environment()` 內先建立 `hahaha.Setting_Box_ = new hahaha_setting_box()`。
- 建立後先呼叫 `Load_All()`；若載入失敗，再補一次 `Save_All()` 產生預設設定檔。
- 全專案共用入口維持掛到 `ha.Setting`，讓其他位置優先透過 `ha.Setting` 讀取設定。
- 若設定物件有重新 `Load_All()` 或重新建立，才重新指定 `ha.Setting = hahaha.Setting_Box_`。
- 單純修改欄位後呼叫 `Save_All()` 時，不要重設 `ha.Setting` 參考。

## 擴充規則

- 新增設定區段時，先在設定容器內新增對應 `public` 欄位，再補上 `Load_xxx()`、`Save_xxx()`，最後把它串進 `Load_All()` / `Save_All()`。
- 不要把設定檔讀寫散落在各功能頁或各 thread 類別中，設定容器只保留集中管理與路徑組裝責任。

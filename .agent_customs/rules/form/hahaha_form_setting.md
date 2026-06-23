# hahaha_form_setting 處理方式

## 適用範圍

- 本檔只描述設定頁 `hahaha_form_setting` 自己的處理方式。
- 設定頁共用模式另讀 `D:\vs\c#\c_sharp_base\.agents\rules\form\setting-form.md`。

## 結構

- 外層 tab 控制項名稱維持 `pageControl1`。
- 目前頁面 tab 採中文命名，例如 `系統`、`全域`。

## 頁面規則

- `系統` tab 目前只保留 `Dir_Environment` 的可編輯輸入框。
- `Name_Setting`、`Name_Config`、`Name_Log`、`Name_Class`、`Name_File` 屬於內建設定，不提供輸入框。
- `textBox_system_dir_environment` 後方保留 `...` 按鈕，用來選擇資料夾路徑。
- `textBox_system_dir_environment`、`...` 按鈕、底部 `儲存` / `取消` 按鈕的既有位置與大小，以使用者目前擺放為準，後續不要任意更動。
- `全域` tab 目前保留頁面與 panel 結構，供後續擴充。
- `Name_Class`、`Name_File` 屬於內建設定，不提供輸入框。

## 存讀流程

- `Form_Load` 時設定頁標題為 `設定`，並呼叫 `Setting_Reload_All()` 回填畫面。
- `Setting_Reload_All()` 只回填目前允許編輯的欄位。
- `Setting_Save_All()` 只回寫目前允許編輯的欄位，再呼叫對應 `Save_xxx()`。
- `Setting_Save_All()` 將參數回寫到 `hahaha.Setting_Box_` 後直接儲存，不要在 save 流程內重設 `ha.Setting`。
- `取消` 按鈕流程為重新 `Load_All()` 後再呼叫 `Setting_Reload_All()`。
- 只有重新 `Load_All()` 後，才重新指定 `ha.Setting = hahaha.Setting_Box_`。

## 關閉

- `FormClosing` 維持 `e.Cancel = false;`。
- 設定頁不負責全域關閉流程，也不要在此頁內直接呼叫 `hahaha.Close()`。

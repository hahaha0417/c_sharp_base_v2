# 專案命名規範

## C# WinForms 命名規範

- 規則：專案內自訂類別、表單、控制項、設定類別、工具類別，優先延續既有 `hahaha_*` 前綴。
  - 建議：`hahaha_form_main`、`hahaha_setting_global`、`hahaha_thread_command`
  - 避免：`MainForm`、`GlobalSettingManager`、`ThreadHelper1`
- 規則：檔名、類別名、資料夾命名優先與既有結構一致，不要在同一專案混用另一套全新風格。
  - 建議：檔名 `hahaha_form_about.cs` 對應類別 `hahaha_form_about`
  - 避免：檔名 `hahaha_form_about.cs` 但類別叫 `AboutForm`
- 規則：若既有方法命名已採 `Xxx_Yyy` 或 `xxx_yyy` 風格，新增方法需延續同一類別既有寫法。
  - 建議：`Form_Initialize()`、`Thread_Start()`
  - 避免：同一類別混用 `Form_Initialize()` 與 `InitializeForm()`
- 規則：欄位、區域變數、參數命名以可讀性與一致性為主；若既有檔案採底線分隔，就沿用底線分隔。
  - 建議：`string log_path_`
  - 建議：`int retry_count_`
  - 避免：同一段程式同時混用 `logPath`、`log_path_`、`Log_Path`
- 規則：本專案後續新增的 class 欄位一律使用 `public`，不要新產生 `private`、`protected`、`internal` 欄位。
  - 建議：`public string result_text_ = "";`
  - 建議：`public hahaha_thread_command_timer_test? Thread_Timer_Test_ = null;`
  - 避免：`private string result_text_ = "";`
- 規則：常數名稱使用全大寫底線風格 `XXX_XXX`。
  - 建議：`MAX_RETRY_COUNT`
  - 建議：`DEFAULT_TIMEOUT_MS`
  - 避免：`MaxRetryCount`
- 規則：enum 成員名稱使用 `UPPER_SNAKE_CASE` 或與既有 enum 完全一致，不要在同一個 enum 內混用多種風格。
  - 建議：`PENDING_APPROVAL`
  - 建議：`THREAD_STOPPED`
  - 避免：`PendingApproval`
- 規則：布林欄位、屬性、參數優先使用可直接判讀真假的名稱。
  - 建議：`is_enabled`
  - 建議：`has_error`
  - 避免：`flag1`
- 規則：WinForms 表單類別使用角色語意命名，常見前綴優先沿用 `hahaha_form_`。
  - 建議：`hahaha_form_main`
  - 建議：`hahaha_form_version`
  - 避免：`form1`
- 規則：設定類別使用 `hahaha_setting_` 前綴，定義類別使用 `hahaha_define_` 前綴，執行緒類別使用 `hahaha_thread_` 前綴。
  - 建議：`hahaha_setting_system`
  - 建議：`hahaha_define`
  - 建議：`hahaha_thread_pause`
- 規則：可重用 UI 控制項與 UI 基底元件，優先以 `hahahaUIlib` 或 `hahahalib` 內既有命名方式延伸，不要在主專案另起不一致命名。
  - 建議：延續 `SK_Control`、`Tab_Controll_Base` 所在模組風格
  - 避免：同類 UI 元件一部分放核心庫、一部分用全新命名散落主專案

## 使用原則

- 新增命名規則前，先觀察需求所在資料夾目前的命名方式。
- 若 `hahahalib`、`hahahaUIlib`、`c_sharp_base` 三邊命名略有差異，優先遵守該模組本身既有風格，不要硬性統一到破壞一致性。
- 若要大規模重命名既有類別、檔名、命名空間，需先確認是否會影響 Designer、資源檔、專案引用與反射使用位置。

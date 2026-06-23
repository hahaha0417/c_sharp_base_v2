# hahaha_form_main 處理方式

## 適用範圍

- 本檔只描述主頁 `hahaha_form_main` 自己的處理方式。

## 初始化

- 建構子只負責 `InitializeComponent()`。
- `Form_Load` 可啟動必要的背景初始化流程，但 UI 更新必須透過 `Invoke(...)` 或 `BeginInvoke(...)` 回主執行緒。
- 主頁載入後，主標題由系統名稱統一控制時，回寫目標維持目前 form 自己的 `label_title.Text`；若從背景執行緒更新，透過 `ha.Form_Main!.Invoke(...)` 回主執行緒。

## 日誌與狀態

- 主頁背景初始化若要寫 log，優先使用 `ha.Log_Form_Main`。
- 主頁是共用物件與全域狀態的主要承接畫面，可接收背景 thread 的 UI 回寫。

## 關閉

- `FormClosing` 維持 `e.Cancel = false;`。
- 主頁關閉時要呼叫 `ha.Flow_Close!.Close_All()`，統一收掉全域 thread 與共用資源。

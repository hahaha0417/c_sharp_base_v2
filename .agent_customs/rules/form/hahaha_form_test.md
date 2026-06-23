# hahaha_form_test 處理方式

## 適用範圍

- 本檔只描述測試頁 `hahaha_form_test` 自己的處理方式。

## 初始化

- 建構子只負責 `InitializeComponent()`。
- `Form_Load` 負責設定頁面初始文字、預設狀態與按鈕顯示內容。
- 測試頁初始狀態維持 timer 結果提示文字與 pause timer 按鈕文字初始化。

## 事件處理

- 同步測量按鈕直接使用 `hahaha.Timer_` 進行 `Reset()`、`Start()`、`End()` 與結果顯示。
- 背景測量按鈕直接呼叫 `hahaha.Thread_Timer_Test_` 已提供的 command 方法，不在頁面內自行建立 thread。
- pause timer 啟用/禁用按鈕直接呼叫 `hahaha.Thread_Pause_Timer_Test_` 的 `Enabled()` 與 `Disabled()`。
- 測試頁觸發背景處理前，可先把結果區更新為執行中提示文字。

## 關閉

- `FormClosing` 維持 `e.Cancel = false;`。
- 測試頁不負責全域關閉流程，也不要在此頁內直接呼叫 `hahaha.Close()`。

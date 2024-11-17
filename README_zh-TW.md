# yt-dlp_GUI_Downloader

![截圖](https://github.com/user-attachments/assets/81864443-5459-438b-9524-06fc1f114abd)

一款可以輕鬆通過GUI操作 `yt-dlp.exe` 的工具。

## 捐款
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/G2G315YFUU)

## 支援的語言
除日語外，其他語言通過翻譯工具生成。
- 日語
- 英語
- 中文（簡體）
- 中文（繁體）

---

## 使用說明

### 語言選擇
![語言選擇](https://github.com/user-attachments/assets/c55f09e2-6de4-44e8-be70-853a942b198f)

通過此選單切換語言。選擇的語言將在下次啟動時生效。  
![示例介面](https://github.com/user-attachments/assets/fca2d17d-a92f-467a-bee6-e35fb1bf4514)  
![示例介面](https://github.com/user-attachments/assets/220171ae-031c-476e-ba5d-cc7a5d6cce95)  
![示例介面](https://github.com/user-attachments/assets/5d2f7b46-57c8-40ab-9f32-679ecd321fec)

---

### 如何下載視頻

#### 1. 初始設定
點擊左上角的設定圖示，打開配置畫面。  
![設定](https://github.com/user-attachments/assets/47903cfd-91c5-4871-8edd-4d805bd45fe7)

完成選擇後，請務必點擊 **保存**。  
如果需要使用cookies，請指定通過例如“Get cookies.txt LOCALLY”保存的 `.txt` 文件。（具體用法請參考外部指南）

#### 2. 添加視頻
點擊 **ADD URL**，然後將URL貼上到文本框中。  
可以添加多行URL。  
![添加URL](https://github.com/user-attachments/assets/a7f395a2-4be6-481c-b517-93e6b06e0f75)

點擊 **OK** 開始獲取視頻資訊。  
![獲取資訊](https://github.com/user-attachments/assets/a704f4bc-7c07-4e4b-9885-e982391e101d)

完成獲取後，畫面將顯示如下：  
![視頻列表](https://github.com/user-attachments/assets/1935c634-19e7-48d6-ae8d-4096a46c3899)

#### 3. 刪除視頻列表中的項目
右鍵點擊某一項目，顯示選項：“開啟”、“刪除”或“刪除所有項目”。  
![右鍵選單](https://github.com/user-attachments/assets/11767368-552f-4b5b-acfa-3668bf2877fb)

#### 4. 指定視頻格式
可以為每個項目配置解析度和其他設定。  
![格式選擇](https://github.com/user-attachments/assets/8f929e50-c85d-4c9b-b205-6d813089a04e)

#### 5. 開始下載
點擊紅色 **RUN** 按鈕。  
如果在設定中已指定下載目錄，則會立即開始下載。否則，系統會提示您選擇一個資料夾。  
![開始下載](https://github.com/user-attachments/assets/be176319-ff02-4e7b-bfdb-ad40f9a64db9)

下載過程中，可以通過進度條和通知查看進度。  
![進度條](https://github.com/user-attachments/assets/dd7c016d-1c8c-4bfe-9dff-4a9cbe4e1c86)

下載完成後，會收到如下通知：  
![完成通知](https://github.com/user-attachments/assets/8441c8ef-a513-46c0-b143-96a2972acba1)

在指定資料夾中可找到下載的文件：  
![下載的文件](https://github.com/user-attachments/assets/e7e724b2-3cd0-41a7-9f28-91651cacf722)

---

### 查看下載歷史
您可以查看下載歷史，並通過右鍵點擊選擇 **開啟** 查看視頻頁面。  
![歷史記錄](https://github.com/user-attachments/assets/c2b0978b-8619-4e5b-a3fb-d1e623a21850)

歷史記錄文件保存在程式目錄的 `Recent` 資料夾中。  
![Recent 資料夾](https://github.com/user-attachments/assets/5aabee74-165c-40b1-b916-0d99c07769b7)

---

### 常見問題

- **為什麼指定的編解碼器或解析度不起作用？**  
  對於4K或8K視頻，請使用VP9或AV1編解碼器。YouTube不支援H265，因此會默認使用H264。如果找不到匹配的格式，系統會自動選擇最接近的組合。

- **可以下載整個播放清單嗎？**  
  可以支援。（已在YouTube上驗證）

- **可以下載有年齡限制或僅限會員的視頻嗎？**  
  可以通過指定cookies實現，但請務必遵守會員規定。

- **可以下載非法上傳的視頻嗎？**  
  請不要這樣做。作者不為濫用行為承擔任何責任。

---

### 授權
MIT License

Copyright (c) 2024 Long0823-1

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

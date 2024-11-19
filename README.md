# yt-dlp GUI Downloader 日本語対応

![スクリーンショット](https://github.com/user-attachments/assets/81864443-5459-438b-9524-06fc1f114abd)

`yt-dlp.exe` をGUIで簡単に操作できるツールです。

[简体中文版的README请点击这里](https://github.com/Long0823-1/yt-dlp_GUI_Downloader_/blob/master/README_zh-CN.md)  
[繁體中文版的README請點擊這裡](https://github.com/Long0823-1/yt-dlp_GUI_Downloader_/blob/master/README_zh-TW.md)  
[English version of the README is available here.](https://github.com/Long0823-1/yt-dlp_GUI_Downloader_/blob/master/README_EN.md)  

## 寄付
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/G2G315YFUU)  
## ダウンロード
[![Download yt-dlp GUI Downloader](https://img.shields.io/badge/Download-yt--dlp_GUI_Downloader-blue?style=for-the-badge)](https://github.com/Long0823-1/yt-dlp_GUI_Downloader_/releases/download/v1.0.0.0/yt-dlp_GUI_Downloader.zip)


## 対応言語
日本語以外は翻訳ツールを使用しています。
- 日本語
- 英語
- 中国語（簡体字）
- 中国語（繁体字）

---

## 使用方法

### 言語選択
![言語選択](https://github.com/user-attachments/assets/c55f09e2-6de4-44e8-be70-853a942b198f)

このメニューから言語を切り替えることができます。選択した言語は次回起動時に適用されます。  
![UIサンプル](https://github.com/user-attachments/assets/fca2d17d-a92f-467a-bee6-e35fb1bf4514)  
![UIサンプル](https://github.com/user-attachments/assets/220171ae-031c-476e-ba5d-cc7a5d6cce95)  
![UIサンプル](https://github.com/user-attachments/assets/5d2f7b46-57c8-40ab-9f32-679ecd321fec)

---

### 動画のダウンロード方法

#### 1. 初期設定
左上の設定アイコンをクリックして設定画面を開きます。  
![設定](https://github.com/user-attachments/assets/47903cfd-91c5-4871-8edd-4d805bd45fe7)

選択を終えたら、必ず **保存** をクリックしてください。  
クッキーを使用する場合は、「Get cookies.txt LOCALLY」などを利用して `.txt` ファイルを保存し、指定してください。（詳しい使い方は外部ガイドをご参照ください）

#### 2. 動画を追加
**ADD URL** をクリックし、URLをテキストボックスに貼り付けます。複数のURLを改行して追加することも可能です。  
![URLの追加](https://github.com/user-attachments/assets/a7f395a2-4be6-481c-b517-93e6b06e0f75)

**OK** をクリックすると、動画情報の取得が開始されます。  
![情報取得](https://github.com/user-attachments/assets/a704f4bc-7c07-4e4b-9885-e982391e101d)

情報取得が完了すると以下のように表示されます：  
![動画リスト](https://github.com/user-attachments/assets/1935c634-19e7-48d6-ae8d-4096a46c3899)

#### 3. 動画リストから項目を削除
リスト内の項目を右クリックすると、「開く」「削除」「リスト内のアイテムをすべて削除」といったオプションが表示されます。  
![右クリックメニュー](https://github.com/user-attachments/assets/11767368-552f-4b5b-acfa-3668bf2877fb)

#### 4. 動画形式の指定
各項目ごとに解像度などの設定を行うことができます。  
![形式選択](https://github.com/user-attachments/assets/8f929e50-c85d-4c9b-b205-6d813089a04e)

#### 5. ダウンロードを開始
赤い **RUN** ボタンをクリックしてください。  
設定画面でダウンロード先を指定している場合は、すぐにダウンロードが開始されます。指定していない場合は、フォルダ選択のダイアログが表示されます。  
![ダウンロード開始](https://github.com/user-attachments/assets/be176319-ff02-4e7b-bfdb-ad40f9a64db9)

ダウンロード中は進捗状況をプログレスバーや通知で確認できます。  
![進行状況](https://github.com/user-attachments/assets/dd7c016d-1c8c-4bfe-9dff-4a9cbe4e1c86)

ダウンロード完了後には以下の通知が表示されます：  
![完了通知](https://github.com/user-attachments/assets/8441c8ef-a513-46c0-b143-96a2972acba1)

指定したフォルダ内にダウンロードしたファイルが保存されています：  
![ダウンロード済みファイル](https://github.com/user-attachments/assets/e7e724b2-3cd0-41a7-9f28-91651cacf722)

---

### ダウンロード履歴を見る
ダウンロード履歴を確認することができます。履歴内の項目を右クリックし、**開く** を選択すると動画ページが開きます。  
![履歴](https://github.com/user-attachments/assets/c2b0978b-8619-4e5b-a3fb-d1e623a21850)

履歴ファイルはプログラムのフォルダ内の `Recent` フォルダに保存されています。  
![Recent フォルダ](https://github.com/user-attachments/assets/5aabee74-165c-40b1-b916-0d99c07769b7)

---

### FAQ

- **指定したコーデックや解像度が反映されないのはなぜですか？**  
  4Kや8Kの動画をダウンロードする場合は、VP9またはAV1コーデックを選択してください。YouTubeではH265がサポートされていないため、自動的にH264が選択されます。指定した形式が見つからない場合、近いものが自動的に選択されます。

- **プレイリスト全体をダウンロードできますか？**  
  はい、可能です。（YouTubeで動作確認済み）

- **年齢制限付きやメンバーシップ限定動画をダウンロードできますか？**  
  クッキーを指定することで可能ですが、利用規約に必ず従ってください。

- **違法アップロードされた動画をダウンロードしてもいいですか？**  
  絶対にしないでください。作者は一切の責任を負いません。

---

### ライセンス
MIT License

Copyright (c) 2024 Long0823-1

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### 使用したライブラリのライセンス

The MIT License (MIT)

Copyright (c) 2007 James Newton-King

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Windows Community Toolkit
Copyright © .NET Foundation and Contributors

All rights reserved.

MIT License (MIT)
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED AS IS, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

MIT License

Copyright (c) 2023-2024 Jake Soenneker

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

WindowsAPICodePack 8.0.6
License file
MIT License

Copyright (c) 2009 - 2010 Microsoft Corporation, then modifications by Peter William Wagner 2017 - 2024

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

BSD 3-Clause License

Copyright (c) 2020-2024, Bluegrams.
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice, this
  list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

* Neither the name of the copyright holder nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

# yt-dlp_GUI_Downloader

![スクリーンショット 2024-11-10 155503](https://github.com/user-attachments/assets/81864443-5459-438b-9524-06fc1f114abd)

yt-dlp.exeをGUIで操作することができます。

### 対応言語
日本語以外は翻訳機を使ってます。
- 日本語
- 英語（English）
- 中国語（簡体字）
- 中国語（繁体字）

## 使用方法
### 言語選択
![language](https://github.com/user-attachments/assets/4e8ad913-3671-4c1f-b8fa-4ea434436a70)

ここから言語を切り替えることができます。  
次回起動以降は、選択した言語になります。

![image](https://github.com/user-attachments/assets/fca2d17d-a92f-467a-bee6-e35fb1bf4514)
![image](https://github.com/user-attachments/assets/220171ae-031c-476e-ba5d-cc7a5d6cce95)
![image](https://github.com/user-attachments/assets/5d2f7b46-57c8-40ab-9f32-679ecd321fec)

## ダウンロード方法

### 最初に設定をしてください

左上の設定をクリックすると、詳細設定画面が表示されます。

![image](https://github.com/user-attachments/assets/47903cfd-91c5-4871-8edd-4d805bd45fe7)

選択し終えたら、最後に保存を必ずクリックしてください。

クッキーを使うについては「Get cookies.txt LOCALLY」などで保存したtxtファイルを指定してください。
使い方は調べれば出てくるので、ここでは割愛します。

### 動画の追加方法

ADD URLをクリックして、テキストボックスにURLを貼り付けてください。  
複数行にURLを追加できます。  

![image](https://github.com/user-attachments/assets/a7f395a2-4be6-481c-b517-93e6b06e0f75)

[OK]をクリックすると、動画情報の取得が始まります。

![image](https://github.com/user-attachments/assets/a704f4bc-7c07-4e4b-9885-e982391e101d)

取得が終わると、このように表示されます。

![image](https://github.com/user-attachments/assets/1935c634-19e7-48d6-ae8d-4096a46c3899)

### 動画リストにあるアイテムを削除する

アイテムの上で右クリックすると、「開く」「削除」「リスト内のアイテムをすべて削除」があります。  
![image](https://github.com/user-attachments/assets/11767368-552f-4b5b-acfa-3668bf2877fb)

### 動画形式の指定について

アイテムごとに解像度などの設定をできます。

![image](https://github.com/user-attachments/assets/8f929e50-c85d-4c9b-b205-6d813089a04e)

### ダウンロードを開始する方法

「RUN」と書かれた赤ボタンをクリックしてください。
設定画面で、ダウンロード先を指定している場合は、即ダウンロードが開始されます。  
指定していない場合は、フォルダの選択ダイアログで選択してください。

![image](https://github.com/user-attachments/assets/be176319-ff02-4e7b-bfdb-ad40f9a64db9)

ダウンロードが始まると、このような通知が来ます。  
![image](https://github.com/user-attachments/assets/67d9bc71-9cfc-47ba-8c92-0394607527e2)

ダウンロード中はこのように、プログレスバーなどで進捗状況を確認できます。  
![image](https://github.com/user-attachments/assets/dd7c016d-1c8c-4bfe-9dff-4a9cbe4e1c86)

終わるとこのような通知が来ます。  
![image](https://github.com/user-attachments/assets/8441c8ef-a513-46c0-b143-96a2972acba1)

指定したフォルダを見ると、指定した通りのファイルができています。  
![image](https://github.com/user-attachments/assets/e7e724b2-3cd0-41a7-9f28-91651cacf722)

## 履歴について

ダウンロード履歴を見ることができます。  
右クリック→「開く」で動画ページが開きます。  
![image](https://github.com/user-attachments/assets/c2b0978b-8619-4e5b-a3fb-d1e623a21850)


### 仕様について

Q. 指定したコーディック、解像度にならない  
A. 4K,8Kなどの動画をダウンロードする際は、VP9もしくはAV1コーディックを指定してください  
YouTubeではH265を指定しても、サーバ上に存在しないため、強制的にH264を指定するようにしています。  
基本的には、指定したコーディック、解像度の組み合わせが見つからなかった場合、自動的に近しいものを選択します。  

Q. プレイリストを丸ごとダウンロードできますか？  
A. はい。できます。（YouTubeのみ確認済み）  

Q. 年齢制限がかかった動画や、メンバーシップ限定動画をダウンロードできますか？  
A. できます。（クッキーを絶対に指定するのと、メンバーシップ先の規約などを絶対に確認してください。）  

Q. 違法アップロード動画をダウンロードしていい？  
A. 絶対にしないでください。何かあっても作者は責任を一切負いません。

## このソフトのラインセンス

MIT License

Copyright (c) 2024 Long0823-1

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


## 使用したライブラリのライセンス

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

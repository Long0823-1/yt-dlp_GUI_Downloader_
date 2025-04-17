# yt-dlp GUI Downloader

![截图](https://github.com/user-attachments/assets/81864443-5459-438b-9524-06fc1f114abd)

一款可以轻松通过GUI操作 `yt-dlp.exe` 的工具。

## Download
[![Download yt-dlp GUI Downloader](https://img.shields.io/badge/Download-yt--dlp_GUI_Downloader-blue?style=for-the-badge)](https://github.com/Long0823-1/yt-dlp_GUI_Downloader_/releases/download/v1.0.0.0/yt-dlp_GUI_Downloader.zip)


## 支持的语言
除日语外，其他语言通过翻译工具生成。
- 日语
- 英语
- 中文（简体）
- 中文（繁体）

---

## 使用说明

### 语言选择
![语言选择](https://github.com/user-attachments/assets/c55f09e2-6de4-44e8-be70-853a942b198f)

通过此菜单切换语言。选择的语言将在下次启动时生效。  
![示例界面](https://github.com/user-attachments/assets/fca2d17d-a92f-467a-bee6-e35fb1bf4514)  
![示例界面](https://github.com/user-attachments/assets/220171ae-031c-476e-ba5d-cc7a5d6cce95)  
![示例界面](https://github.com/user-attachments/assets/5d2f7b46-57c8-40ab-9f32-679ecd321fec)

---

### 如何下载视频

#### 1. 初始设置
点击左上角的设置图标，打开配置界面。  
![设置](https://github.com/user-attachments/assets/47903cfd-91c5-4871-8edd-4d805bd45fe7)

完成选择后，请务必点击 **保存**。  
如果需要使用cookies，请指定通过例如“Get cookies.txt LOCALLY”保存的 `.txt` 文件。（具体用法请参考外部指南）

#### 2. 添加视频
点击 **ADD URL**，然后将URL粘贴到文本框中。  
可以添加多行URL。  
![添加URL](https://github.com/user-attachments/assets/a7f395a2-4be6-481c-b517-93e6b06e0f75)

点击 **OK** 开始获取视频信息。  
![获取信息](https://github.com/user-attachments/assets/a704f4bc-7c07-4e4b-9885-e982391e101d)

完成获取后，界面将显示如下：  
![视频列表](https://github.com/user-attachments/assets/1935c634-19e7-48d6-ae8d-4096a46c3899)

#### 3. 删除视频列表中的项目
右键点击某一项目，显示选项：“打开”、“删除”或“删除所有项目”。  
![右键菜单](https://github.com/user-attachments/assets/11767368-552f-4b5b-acfa-3668bf2877fb)

#### 4. 指定视频格式
可以为每个项目配置分辨率和其他设置。  
![格式选择](https://github.com/user-attachments/assets/8f929e50-c85d-4c9b-b205-6d813089a04e)

#### 5. 开始下载
点击红色 **RUN** 按钮。  
如果在设置中已指定下载目录，则会立即开始下载。否则，系统会提示您选择一个文件夹。  
![开始下载](https://github.com/user-attachments/assets/be176319-ff02-4e7b-bfdb-ad40f9a64db9)

下载过程中，可以通过进度条和通知查看进度。  
![进度条](https://github.com/user-attachments/assets/dd7c016d-1c8c-4bfe-9dff-4a9cbe4e1c86)

下载完成后，会收到如下通知：  
![完成通知](https://github.com/user-attachments/assets/8441c8ef-a513-46c0-b143-96a2972acba1)

在指定文件夹中可找到下载的文件：  
![下载的文件](https://github.com/user-attachments/assets/e7e724b2-3cd0-41a7-9f28-91651cacf722)

---

### 查看下载历史
您可以查看下载历史，并通过右键点击选择 **打开** 查看视频页面。  
![历史记录](https://github.com/user-attachments/assets/c2b0978b-8619-4e5b-a3fb-d1e623a21850)

历史记录文件保存在程序目录的 `Recent` 文件夹中。  
![Recent 文件夹](https://github.com/user-attachments/assets/5aabee74-165c-40b1-b916-0d99c07769b7)

---

### 常见问题

- **为什么指定的编解码器或分辨率不起作用？**  
  对于4K或8K视频，请使用VP9或AV1编解码器。YouTube不支持H265，因此会默认使用H264。如果找不到匹配的格式，系统会自动选择最接近的组合。

- **可以下载整个播放列表吗？**  
  可以支持。（已在YouTube上验证）

- **可以下载有年龄限制或仅限会员的视频吗？**  
  可以通过指定cookies实现，但请务必遵守会员规定。

- **可以下载非法上传的视频吗？**  
  请不要这样做。作者不为滥用行为承担任何责任。

---

### 许可证
MIT License

Copyright (c) 2024 Long0823-1

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

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

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

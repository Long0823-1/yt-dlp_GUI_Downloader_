# yt-dlp_GUI_Downloader

![Screenshot](https://github.com/user-attachments/assets/81864443-5459-438b-9524-06fc1f114abd)

A GUI tool to operate `yt-dlp.exe` effortlessly.

## Donations
[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/G2G315YFUU)

## Download
[![Download yt-dlp GUI Downloader](https://img.shields.io/badge/Download-yt--dlp_GUI_Downloader-blue?style=for-the-badge)](https://github.com/Long0823-1/yt-dlp_GUI_Downloader_/releases/download/v1.0.0.0/yt-dlp_GUI_Downloader.zip)


## Supported Languages
Non-Japanese translations are machine-generated.
- Japanese
- English
- Chinese (Simplified)
- Chinese (Traditional)

---

## Usage Instructions

### Language Selection
![Language Selection](https://github.com/user-attachments/assets/c55f09e2-6de4-44e8-be70-853a942b198f)

Use this menu to switch languages. The selected language will be retained for future launches.  
![Sample UI](https://github.com/user-attachments/assets/fca2d17d-a92f-467a-bee6-e35fb1bf4514)  
![Sample UI](https://github.com/user-attachments/assets/220171ae-031c-476e-ba5d-cc7a5d6cce95)  
![Sample UI](https://github.com/user-attachments/assets/5d2f7b46-57c8-40ab-9f32-679ecd321fec)

---

### How to Download Videos

#### 1. Initial Setup
Click the settings icon in the top-left corner to open the configuration screen.  
![Settings](https://github.com/user-attachments/assets/47903cfd-91c5-4871-8edd-4d805bd45fe7)

After making your selections, ensure you click **Save**.  
If using cookies, specify the `.txt` file saved locally using tools like "Get cookies.txt LOCALLY." (Refer to external guides for details.)

#### 2. Add Videos
Click **ADD URL**, then paste URLs into the text box.  
You can add multiple URLs across multiple lines.  
![Add URL](https://github.com/user-attachments/assets/a7f395a2-4be6-481c-b517-93e6b06e0f75)

Click **OK** to fetch video details.  
![Fetching Info](https://github.com/user-attachments/assets/a704f4bc-7c07-4e4b-9885-e982391e101d)

Once the details are fetched, they will display as shown:  
![Video List](https://github.com/user-attachments/assets/1935c634-19e7-48d6-ae8d-4096a46c3899)

#### 3. Delete Items from the Video List
Right-click on an item to see options: "Open," "Delete," or "Delete All Items."  
![Context Menu](https://github.com/user-attachments/assets/11767368-552f-4b5b-acfa-3668bf2877fb)

#### 4. Specify Video Formats
You can configure resolution and other settings for each item.  
![Format Selection](https://github.com/user-attachments/assets/8f929e50-c85d-4c9b-b205-6d813089a04e)

#### 5. Start Download
Click the red **RUN** button.  
If the download directory is already set in settings, the download will start immediately. Otherwise, you will be prompted to select a folder.  
![Start Download](https://github.com/user-attachments/assets/be176319-ff02-4e7b-bfdb-ad40f9a64db9)

During downloads, progress is displayed via progress bars and notifications.  
![Progress](https://github.com/user-attachments/assets/dd7c016d-1c8c-4bfe-9dff-4a9cbe4e1c86)

Once completed, you’ll receive a notification:  
![Completion Notification](https://github.com/user-attachments/assets/8441c8ef-a513-46c0-b143-96a2972acba1)

Check the designated folder for your downloaded files:  
![Downloaded Files](https://github.com/user-attachments/assets/e7e724b2-3cd0-41a7-9f28-91651cacf722)

---

### Viewing Download History
You can view your download history and open video pages by right-clicking and selecting **Open**.  
![History](https://github.com/user-attachments/assets/c2b0978b-8619-4e5b-a3fb-d1e623a21850)

The history files are located in the `Recent` folder within the program directory.  
![Recent Folder](https://github.com/user-attachments/assets/5aabee74-165c-40b1-b916-0d99c07769b7)

---

### FAQ

- **Why does the specified codec or resolution not apply?**  
  For 4K or 8K videos, use VP9 or AV1 codecs. YouTube does not support H265, so H264 is used as a fallback. If no matching format is found, the closest available combination will be selected.

- **Can I download entire playlists?**  
  Yes, it is supported (confirmed for YouTube).

- **Can I download age-restricted or membership-only videos?**  
  Yes, by specifying cookies. Always verify compliance with membership terms.

- **Is it legal to download copyrighted content?**  
  No. Do not download illegally uploaded videos. The author holds no responsibility for misuse.

---

### License

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


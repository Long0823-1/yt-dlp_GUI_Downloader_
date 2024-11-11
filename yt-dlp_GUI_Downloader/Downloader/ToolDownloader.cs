using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_dlp_GUI_Downloader.Downloader
{
    public class ToolDownloader
    {
        public async static Task<bool> Downloader()
        {
            if(!File.Exists(@".\yt-dlp.exe") || !File.Exists(@".\ffmpeg.exe"))
            {
                return await Task.Run(async () =>
                {
                    await YoutubeDLSharp.Utils.DownloadYtDlp();
                    await YoutubeDLSharp.Utils.DownloadFFmpeg();
                    return true;
                });
            }
            else
            {
                return false;
            }
           

        }
    }
}

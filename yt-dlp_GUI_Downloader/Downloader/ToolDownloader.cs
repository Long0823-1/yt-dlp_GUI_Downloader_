using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_dlp_GUI_Downloader.Downloader
{
    public class ToolDownloader
    {
        public async static Task<bool> Downloader()
        {
            if(!File.Exists(@".\yt-dlp.exe") || !File.Exists(@".\ffmpeg-master-latest-win64-gpl-shared\bin\ffmpeg.exe"))
            {
                Toast.ShowToast("Download", "Downloading ffmpeg and yt-dlp Now!\nDo not close the software until the “Download Complete” message appears.\n「ダウンロード終了」が表示されるまでソフトを閉じないでください。");

                return await Task.Run(async () =>
                {
                    FileDownloader fld = new FileDownloader();
                    string ffmpegUrl = "https://github.com/yt-dlp/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl-shared.zip";

                    await YoutubeDLSharp.Utils.DownloadYtDlp(); //yt-dlpをダウンロード
                    Toast.ShowToast("Download Done!", "yt-dlp"); 
                    var ffmpeg = await fld.GetContent(ffmpegUrl);

                    try
                    {
                        ZipFile.ExtractToDirectory(ffmpeg, @".\", true);
                    }
                    catch (Exception) 
                    {
                        Toast.ShowToast("Error", "yt-dlp");
                    }

                    ffmpeg.Close();
                    Toast.ShowToast("Download Done!", "I just finished downloading FFMPEG."); 
                    return true;
                });
            }
            else
            {
                return false;
            }
           

        }

        private async void FFMPEG_Download()
        {

        }
    }
}

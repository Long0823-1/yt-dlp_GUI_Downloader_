using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yt_dlp_GUI_Downloader.yt_dlp
{
    public class Settings_Json_Save_Class
    {
        public Settings_Json_Save_Class() { }

        public int VideoCodec { get; set; } = 0;
        public int AudioCodec { get; set; } = 0;
        public int Pixel {  get; set; } = 0;
        public int VideoExtension {  get; set; } = 0;
        public bool IsAudioOnly { get; set; } = false;
        public bool IsGaiyoranSave {  get; set; } = false;
        public bool IsCommentSave {  get; set; } = false;
        public bool IsThumbnailSave {  get; set; } = false;
        public bool IsUseCookies {  get; set; } = false;
        public string CookiesPath { get; set; } = "";
        public bool IsUseDownloadPath {  get; set; } = false;
        public string DownloadPath { get; set; } = "";
        public int Retries { get; set; } = 100;
        public bool IsPlaylist { get; set; } = false;
    }
}

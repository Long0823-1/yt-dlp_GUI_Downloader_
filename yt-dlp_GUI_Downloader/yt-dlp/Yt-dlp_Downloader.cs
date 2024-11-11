using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using YoutubeDLSharp;
using YoutubeDLSharp.Metadata;
using YoutubeDLSharp.Options;
using yt_dlp_GUI_Downloader.Downloader;

namespace yt_dlp_GUI_Downloader.yt_dlp
{
    public class Yt_dlp_Downloader
    {
        public Yt_dlp_Downloader()
        {
            _vm = (App.Current as App).MainViewModel;
            progress = new Progress<DownloadProgress>(p => ShowProgress(p)); // 進捗状況を反映するための式
        }
        MainViewModel _vm;

        private IProgress<DownloadProgress> progress;
        private readonly string yt_dlp_Path = @".\yt-dlp.exe";
        private readonly string ffmpeg_Path = @".\ffmpeg.exe";
        string[] Pixel = { "256x144", "426x240", "640x360", "854x480", "1280x720", "1920x1080", "2560x1440", "3840x2160", "7680x4320" };
        string[] VideoCodec = { "avc1", "h265", "vp09", "av01" };
        AudioConversionFormat[] AudioFormat = { AudioConversionFormat.Mp3, AudioConversionFormat.Aac, AudioConversionFormat.Flac };
        ObservableCollection<DownloadMergeFormat> MergeList = new ObservableCollection<DownloadMergeFormat>
        {
            DownloadMergeFormat.Mkv,
            DownloadMergeFormat.Mp4,
            DownloadMergeFormat.Flv
        };
        private string TempSaveFilePath;
        public void DownloadAsync(string saveFilePath)
        {
            try
            {
                TempSaveFilePath = saveFilePath;
                string url = _vm.DownloadItems[0].Url;
                FormatData[] formats = _vm.DownloadItems[0].VideoData.Formats;

                var ytdl = new YoutubeDL
                {
                    YoutubeDLPath = yt_dlp_Path,
                    FFmpegPath = ffmpeg_Path,
                    OutputFolder = saveFilePath,

                };

                DownloadVideoAsync(url, ytdl, formats, _vm.DownloadItems[0].IsLive);
            }
            catch (Exception e) { Debug.WriteLine(e); }
        }

        private async Task DownloadVideoAsync(string url, YoutubeDL ytdl, FormatData[] formatData, bool IsLive)
        {
            // FormatIdで管理するか、解像度＋コーディックで管理するか
            string VideoFormatId = "";
            VideoFormatId = GetFormatID(formatData, VideoFormatId, _vm.DownloadItems[0].DownloadSingleSettings.Pixel, _vm.DownloadItems[0].DownloadSingleSettings.VideoCodec);

            var split = Pixel[_vm.DownloadItems[0].DownloadSingleSettings.Pixel].Split('x');
            var options = new OptionSet
            {
                Format = $"bestvideo[vcodec*={VideoCodec[_vm.DownloadItems[0].DownloadSingleSettings.VideoCodec]}][width<={split[0]}][height<={split[1]}]+bestaudio[ext=m4a]/bestvideo[vcodec*={VideoCodec[_vm.DownloadItems[0].DownloadSingleSettings.VideoCodec]}][width<={split[0]}][height<={split[1]}]+bestaudio[ext=m4a]/bestvideo[ext=mp4][vcodec*={VideoCodec[_vm.DownloadItems[0].DownloadSingleSettings.VideoCodec]}][width<={split[0]}][height<={split[1]}]+bestaudio[ext=m4a]/bestvideo[width<={split[0]}][height<={split[1]}]+bestaudio[ext=m4a]/best", //動画のダウンロード形式を指定
                FormatSort = $"vcodec:{VideoCodec[_vm.DownloadItems[0].DownloadSingleSettings.VideoCodec]}",
                AudioFormat = AudioFormat[_vm.DownloadItems[0].DownloadSingleSettings.AudioCodec],
                ExtractAudio = _vm.DownloadItems[0].DownloadSingleSettings.IsAudioOnly,
                MergeOutputFormat = MergeList[_vm.DownloadItems[0].DownloadSingleSettings.VideoExtension],
                Cookies = _vm.DownloadItems[0].DownloadSingleSettings.CookiesPath,
                NoCookies = !_vm.DownloadItems[0].DownloadSingleSettings.IsUseCookies,
                EmbedMetadata = _vm.DownloadItems[0].DownloadSingleSettings.IsGaiyoranSave,
                EmbedThumbnail = _vm.DownloadItems[0].DownloadSingleSettings.IsThumbnailSave,
                IgnoreErrors = true,
                Retries = _vm.DownloadItems[0].DownloadSingleSettings.Retries,
                YesPlaylist = true
            };

            RunResult<string> DownloadTask;
            DownloadTask = await ytdl.RunVideoDownload(url, progress: progress, ct: cts.Token, overrideOptions: options);
            
            if (DownloadTask.Success)
            {
                DownloadComplete();
            }
            else
            {
                Debug.WriteLine($"エラーが発生しました！\n{DownloadTask.ErrorOutput[0]}\n{DownloadTask.ErrorOutput[1]}");
                Toast.ShowToast("エラー", $"エラーが発生しました！\n{DownloadTask.ErrorOutput[0]}\n{DownloadTask.ErrorOutput[1]}");
                DownloadComplete();
            }
        }
        CancellationTokenSource cts = new CancellationTokenSource();
        RecentData recent = new RecentData();
        private async void ShowProgress(DownloadProgress p)
        {
            _vm.DownloadItems[0].Progress_Value = p.Progress;
            if (_vm.Download_Cancel)
            {
                _vm.Download_Cancel = false;
                cts.Cancel();
                Toast.ShowToast("Information", $"Cancel");
            }
            int ConvPer = (int)(p.Progress * 100);
            _vm.DownloadItems[0].Progress_Title = $"DownloadSpeed: {p.DownloadSpeed} | ETA: {p.ETA} | Percentage: {ConvPer}%";
            _vm.DownloadItems[0].Progress_State = p.State.ToString();
            Debug.WriteLine(p.State);
        }

        private void DownloadComplete()
        {
            // 履歴を残す
            Directory.CreateDirectory(@".\Recent");
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter($@".\Recent\{random.Next()}.json"))
            {
                string jsonStr = JsonConvert.SerializeObject(_vm.DownloadItems[0], Formatting.None);
                sw.WriteLine(jsonStr);
            }

            DownloadEndHantei();
        }

        private void DownloadEndHantei()
        {
            _vm.DownloadItems.RemoveAt(0);
            if (_vm.DownloadItems.Count == 0)
            {
                EndDownload();
            }
            else
            {
                ReturnDownload();
                recent.GetRecent();
            }
        }

        private void EndDownload()
        {
            _vm.DownloadItems.Clear();
            Debug.WriteLine("End");
            Toast.ShowToast("Information", $"Download Done!");
            recent.GetRecent();
        }

        private void ReturnDownload()
        {
            if (!_vm.DownloadItems[0].DownloadSingleSettings.IsUseDownloadPath)
            {
                DownloadAsync(TempSaveFilePath);
            }
            else
            {
                DownloadAsync(_vm.DownloadItems[0].DownloadSingleSettings.DownloadPath);
            }
        }

        private string GetFormatID(FormatData[] formatData, string VideoFormatId, int vm_Pixel, int vm_Codec)
        {
            foreach (var format in formatData)
            {
                Debug.WriteLine(Pixel[_vm.DownloadItems[0].DownloadSingleSettings.Pixel] + " " + format.Format + " " + format.VideoCodec);

                if (format.Format.Contains(Pixel[vm_Pixel]) && format.VideoCodec.Contains(VideoCodec[vm_Codec]))
                {
                    Debug.WriteLine("!!!!!!!!!!!" + Pixel[vm_Pixel] + " " + format.Format + " " + format.VideoCodec);
                    VideoFormatId = format.FormatId;
                    //break;
                }
            }

            return VideoFormatId;
        }
    }
}

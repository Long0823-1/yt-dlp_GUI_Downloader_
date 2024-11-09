using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using YoutubeDLSharp;
using YoutubeDLSharp.Metadata;
using YoutubeDLSharp.Options;
using static yt_dlp_GUI_Downloader.MainViewModel;

namespace yt_dlp_GUI_Downloader.yt_dlp
{
    public class Yt_dlp_Information_Getter
    {
        public Yt_dlp_Information_Getter()
        {
            _vm = (App.Current as App).MainViewModel;
        }
        MainViewModel _vm;

        private readonly string yt_dlp_Path = @".\Resources\yt-dlp.exe";
        private readonly string ffmpeg_Path = @".\Resources\ffmpeg.exe";
        public async Task<VideoData> Information_Getter(string Url)
        {
            return await Task.Run(async () =>
            {
                var ytdl = new YoutubeDL();
                VideoData videoData = new VideoData();
                ytdl.YoutubeDLPath = yt_dlp_Path;
                ytdl.FFmpegPath = ffmpeg_Path;

                var options = new OptionSet()
                {
                    Cookies = _vm.cookies
                };

                try
                {
                    var res = await ytdl.RunVideoDataFetch(Url);
                    videoData = res.Data;
                    var formats = videoData.Formats;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("何らかのエラーにより、処理ができませんでした。\nURLが正しいかご確認ください。");
                }

                return videoData;
            });
        }
        /// <summary>
        /// 正しいURL形式かチェック
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        public static bool IsValidUrl(string uri)
        {
            return Uri.IsWellFormedUriString(uri, UriKind.Absolute);
        }

        public static BitmapImage LoadImage(string imagePath)
        {
            var bitmap = new BitmapImage();
            using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                bitmap.BeginInit();
                bitmap.CacheOption = BitmapCacheOption.OnLoad; // メモリにロード
                bitmap.StreamSource = stream;
                bitmap.EndInit();
            }
            return bitmap;
        }

        /// <summary>
        /// 動画情報を展開
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async Task<bool> InformationExtractor(string[] urls)
        {
            return await Task.Run(async () =>
            {
                try
                {
                    foreach (var url in urls)
                    {
                        if (IsValidUrl(url))
                        {
                            try
                            {
                                var video = await Information_Getter(url);

                                if (video != null)
                                {
                                    await Application.Current.Dispatcher.InvokeAsync(new Action(() =>
                                    {
                                        var SettingsItem = new Settings_Json_Save_Class {Retries=_vm.SettingsClass.Retries, AudioCodec = _vm.SettingsClass.AudioCodec, IsAudioOnly = _vm.SettingsClass.IsAudioOnly, CookiesPath = _vm.SettingsClass.CookiesPath, DownloadPath = _vm.SettingsClass.DownloadPath, IsCommentSave = _vm.SettingsClass.IsCommentSave, IsGaiyoranSave = _vm.SettingsClass.IsGaiyoranSave, IsThumbnailSave = _vm.SettingsClass.IsThumbnailSave, IsUseCookies = _vm.SettingsClass.IsUseCookies, IsUseDownloadPath = _vm.SettingsClass.IsUseDownloadPath, Pixel = _vm.SettingsClass.Pixel, VideoCodec = _vm.SettingsClass.VideoCodec, VideoExtension = _vm.SettingsClass.VideoExtension };
                                        _vm.DownloadItems.Add(new Items { DownloadSingleSettings = SettingsItem, VideoData = video, ThumbImage = new BitmapImage(new Uri(video.Thumbnail)), Url = url, Title = video.Title, Pixel = 0, IsLive = (bool)video.IsLive});
                                    }));
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("対応していないサイトかエラーが発生しました。", "警告", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("URLを入力してください!", "注意", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            });


        }
    }
}

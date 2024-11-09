using System.Collections.ObjectModel;
using System.Configuration;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using YoutubeDLSharp.Metadata;
using yt_dlp_GUI_Downloader.yt_dlp;

namespace yt_dlp_GUI_Downloader
{
    
    public class MainViewModel : Prism.Mvvm.BindableBase
    {
        public class Items: Prism.Mvvm.BindableBase
        {
            public required ImageSource ThumbImage { get; set; }
            public required string Title { get; set; }
            public required string Url { get; set; }
            public int Pixel { get; set; }
            public bool IsLive { get; set; }
            public VideoData VideoData { get; set; }
            public Settings_Json_Save_Class DownloadSingleSettings { get; set; }
            private float _Progress_Value = 0;
            private string _Progress_Title = "";
            private string _Progress_State = "待機中";
            public float Progress_Value
            {
                get => _Progress_Value; set=> SetProperty(ref _Progress_Value,value,nameof(Progress_Value));
            }
            public string Progress_Title
            {
                get => _Progress_Title; set => SetProperty(ref _Progress_Title, value, nameof(Progress_Title));

            }
            public string Progress_State
            {
                get => _Progress_State; set => SetProperty(ref _Progress_State, value, nameof(Progress_State));
            }
        }
        public MainViewModel()
        {

        }
       
        // 動画情報を保存
        private ObservableCollection<Items> _DownloadItems = new ObservableCollection<Items>();
        public ObservableCollection<Items> DownloadItems
        {
            get { return _DownloadItems; }
            set { SetProperty(ref _DownloadItems, value, nameof(DownloadItems)); }
        }

        // ダウンロードした動画情報を保存
        private ObservableCollection<Items> _RecentDownloadItems = new ObservableCollection<Items>();
        public ObservableCollection<Items> RecentDownloadItems
        {
            get { return _RecentDownloadItems; }
            set { SetProperty(ref _RecentDownloadItems, value, nameof(RecentDownloadItems)); }
        }

        // yt-dlpのoptions関連
        private string _cookies = "";
        public string cookies
        {
            get { return _cookies; }
            set
            {
                SetProperty(ref _cookies, value, nameof(cookies));
            }
        }
        private Settings_Json_Save_Class _SettingsClass = new Settings_Json_Save_Class();
        public Settings_Json_Save_Class SettingsClass
        {
            get { return _SettingsClass; }
            set { SetProperty(ref _SettingsClass, value, nameof(SettingsClass)); }
        }
    }
}


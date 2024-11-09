using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System.IO;
using System.Windows;

namespace yt_dlp_GUI_Downloader.yt_dlp
{
    /// <summary>
    /// Settings_MenuItem.xaml の相互作用ロジック
    /// </summary>
    public partial class Settings_MenuItem : Window
    {
        private string SavePath = @".\Settings.json";


        public Settings_MenuItem()
        {
            InitializeComponent();
            _vm = (App.Current as App).MainViewModel;

            Settings_Load();
        }
        MainViewModel _vm;
    

        private void Settings_Load()
        {
            if (File.Exists(SavePath))
            {
                using (StreamReader sr = new StreamReader(SavePath))
                {
                    var json = sr.ReadToEnd();
                    var SettingsClass = JsonConvert.DeserializeObject<Settings_Json_Save_Class>(json);
                    _vm.SettingsClass = SettingsClass;

                    VideoCodecComboBox.SelectedIndex = SettingsClass.VideoCodec < 0 ? 0 : SettingsClass.VideoCodec;
                    ResolutionComboBox.SelectedIndex = SettingsClass.Pixel < 0 ? 0 : SettingsClass.Pixel;
                    AudioCodecComboBox.SelectedIndex = SettingsClass.AudioCodec < 0 ? 0 : SettingsClass.AudioCodec;
                    AudioOnlyCheckBox.IsChecked = SettingsClass.IsAudioOnly;
                    CookiesFilePathTextBox.Text = SettingsClass.CookiesPath;
                    Download_Folder_Always_Use.IsChecked = SettingsClass.IsUseDownloadPath;
                    DownloadFolderPathTextBox.Text = SettingsClass.DownloadPath;
                    CommentsCheckBox.IsChecked = SettingsClass.IsCommentSave;
                    DescriptionCheckBox.IsChecked = SettingsClass.IsGaiyoranSave;
                    ThumbnailCheckBox.IsChecked = SettingsClass.IsThumbnailSave;
                    UseCookiesCheckBox.IsChecked = SettingsClass.IsUseCookies;
                    VideoExtensionComboBox.SelectedIndex = SettingsClass.VideoExtension < 0 ? 0 : SettingsClass.VideoExtension;
                    Retries.Text = SettingsClass.Retries.ToString();

                    
                }
            }
        }

        private void Settings_Save_Button_Click(object sender, RoutedEventArgs e)
        {
            // 設定ファイルを生成して保存
            using (StreamWriter sw = new StreamWriter(SavePath))
            {
                // -1の場合0にする

                int result;
                int.TryParse(Retries.Text, out result);

                Settings_Json_Save_Class json_Save_Class = new Settings_Json_Save_Class()
                {
                    VideoCodec = VideoCodecComboBox.SelectedIndex < 0 ? 0 : VideoCodecComboBox.SelectedIndex,
                    Pixel = ResolutionComboBox.SelectedIndex < 0 ? 0 : ResolutionComboBox.SelectedIndex,
                    AudioCodec = AudioCodecComboBox.SelectedIndex < 0 ? 0 : AudioCodecComboBox.SelectedIndex,
                    VideoExtension = VideoExtensionComboBox.SelectedIndex < 0 ? 0 : VideoExtensionComboBox.SelectedIndex,
                    IsAudioOnly = (bool)AudioOnlyCheckBox.IsChecked,
                    CookiesPath = CookiesFilePathTextBox.Text,
                    IsUseDownloadPath = (bool)Download_Folder_Always_Use.IsChecked,
                    DownloadPath = DownloadFolderPathTextBox.Text,
                    IsCommentSave = (bool)CommentsCheckBox.IsChecked,
                    IsGaiyoranSave = (bool)DescriptionCheckBox.IsChecked,
                    IsThumbnailSave = (bool)ThumbnailCheckBox.IsChecked,
                    IsUseCookies = (bool)UseCookiesCheckBox.IsChecked,
                    Retries = result
                };
                _vm.SettingsClass = json_Save_Class;
                string jsonStr = JsonConvert.SerializeObject(json_Save_Class, Formatting.None);
                sw.WriteLine(jsonStr);
            }

            // 設定を再読み込み
            Settings_Load();

            // 閉じる
            this.Close();
        }

        private void SelectCookiesFileButton_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog { IsFolderPicker = false, Title = "Cookiesが保存されたファイルを指定してください" };
            if(dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                CookiesFilePathTextBox.Text = dlg.FileName;
            }
        }

        private void SelectDownloadFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new CommonOpenFileDialog { IsFolderPicker = true, Title = "動画・音声の保存先を指定してください" };
            if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DownloadFolderPathTextBox.Text = dlg.FileName;
            }
        }
    }
}

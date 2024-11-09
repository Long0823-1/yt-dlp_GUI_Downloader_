using Microsoft.WindowsAPICodePack.Dialogs;
using Microsoft.WindowsAPICodePack.Dialogs.Controls;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using yt_dlp_GUI_Downloader.Downloader;
using yt_dlp_GUI_Downloader.yt_dlp;
using static yt_dlp_GUI_Downloader.MainViewModel;

namespace yt_dlp_GUI_Downloader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        private string SavePath = @".\Settings.json";

        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;
            (App.Current as App).MainViewModel = _vm;

            RecentData recent = new RecentData();
            Settings_Load(); // 設定をロード
            recent.GetRecent();
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
                }
            }
        }

        /// <summary>
        /// ダウンロードする際の橋渡し
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Download_Start_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(SavePath))
            {
                MessageBox.Show("設定ファイルが存在しません！\n設定が完了後、ダウンロードができます。", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                Settings_MenuItem item = new Settings_MenuItem();
                item.ShowDialog();
            }
            if (_vm.DownloadItems.Count > 0)
            {
                var dlg = new CommonOpenFileDialog { IsFolderPicker = true };
                if (_vm.DownloadItems[0].DownloadSingleSettings.IsUseDownloadPath && _vm.DownloadItems[0].DownloadSingleSettings.DownloadPath.Length > 0)
                {
                    DownloadStart(_vm.DownloadItems[0].DownloadSingleSettings.DownloadPath);
                }
                else if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    string? saveFilePath = dlg.FileName;
                    DownloadStart(saveFilePath);
                }
                dlg.Dispose();
            }
            else if(!File.Exists(SavePath))
            {
                MessageBox.Show("設定ファイルが存在しません！\nメニューの「設定」からも設定できます。", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("動画を追加してください！", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        /// <summary>
        /// 実際にダウンロードを開始
        /// </summary>
        /// <param name="saveFilePath"></param>
        private static void DownloadStart(string? saveFilePath)
        {
            Yt_dlp_Downloader downloader = new Yt_dlp_Downloader();
            downloader.DownloadAsync(saveFilePath);
        }

        private void Url_Add_Click(object sender, RoutedEventArgs e)
        {
            Url_Add url_Add = new Url_Add();
            url_Add.ShowDialog();          
        }

        private void Settings_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Settings_MenuItem item = new Settings_MenuItem();
            item.ShowDialog();
        }

        private void Open_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string url = (DownloadList.SelectedItem as Items).Url;
            Debug.WriteLine((DownloadList.SelectedItem as Items).DownloadSingleSettings.VideoExtension);
            /*var proc = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
                CreateNoWindow = true,
            };
            System.Diagnostics.Process.Start(proc);*/

        }

        private void Delete_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            _vm.DownloadItems.RemoveAt(DownloadList.SelectedIndex);
        }

        private void List_All_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            _vm.DownloadItems.Clear();
        }

        private void SelectCookiesFileButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RecentData recent = new RecentData();
            recent.GetRecent();
        }
    }
}
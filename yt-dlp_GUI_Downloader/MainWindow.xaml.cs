using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Windows;
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
            Lang_Getter();
            recent.GetRecent();
        }
        MainViewModel _vm;

        string LangPath = @".\Resources\Lang.txt";
        private void Lang_Getter()
        {
            if (File.Exists(LangPath))
            {
                StreamReader sr = new StreamReader(LangPath);

                string path = sr.ReadLine();
                sr.Close();
                ChangeLang(path);

            }
        }

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
                MessageBox.Show("The configuration file does not exist! \nYou can proceed with the download once the setup is complete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
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
            else if (!File.Exists(SavePath))
            {
                MessageBox.Show("The configuration file does not exist! \nYou can also configure it from 'Settings' in the menu.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Please add a video!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        bool Download_Now = false;

        /// <summary>
        /// 実際にダウンロードを開始
        /// </summary>
        /// <param name="saveFilePath"></param>
        private void DownloadStart(string? saveFilePath)
        {
            Toast.ShowToast("Information", $"Download Start!");
            Download_Now = true;
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
            string url = ((DownloadList).SelectedItem as Items).Url;
            Debug.WriteLine((DownloadList.SelectedItem as Items).DownloadSingleSettings.VideoExtension);
            var proc = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
                CreateNoWindow = true,
            };
            System.Diagnostics.Process.Start(proc);

        }
        private void Open_MenuItem_Recent_Click(object sender, RoutedEventArgs e)
        {
            string url = ((Recent_ListView).SelectedItem as Items).Url;
            Debug.WriteLine((Recent_ListView.SelectedItem as Items).DownloadSingleSettings.VideoExtension);
            var proc = new ProcessStartInfo()
            {
                FileName = url,
                UseShellExecute = true,
                CreateNoWindow = true,
            };
            System.Diagnostics.Process.Start(proc);

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

        private void English_Click(object sender, RoutedEventArgs e)
        {
            ChangeLang(@"lang/english.xaml");
        }
        private void Japanese_Click(object sender, RoutedEventArgs e)
        {
            ChangeLang(@"lang/japanese.xaml");
        }

        private void Chinese_Click_Kan(object sender, RoutedEventArgs e)
        {
            ChangeLang(@"lang/chinese_Kan.xaml");
        }
        private void Chinese_Click_Han(object sender, RoutedEventArgs e)
        {
            ChangeLang(@"lang/chinese_Han.xaml");
        }

        private void ChangeLang(string langFile)
        {
            ResourceDictionary langRd = null;
            using (StreamWriter sw = new StreamWriter(LangPath))
            {
                sw.WriteLine(langFile);
            }

            try
            {
                langRd = Application.LoadComponent(new Uri(langFile, UriKind.Relative)) as ResourceDictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (langRd != null)
            {
                if (this.Resources.MergedDictionaries.Count > 0)
                {
                    this.Resources.MergedDictionaries[0] = langRd;
                }
                else
                {
                    this.Resources.MergedDictionaries.Add(langRd);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Download_Now)
            {
                _vm.Download_Cancel = true;
                Download_Now = false;
            }
        }
    }
}
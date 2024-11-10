using System.IO;
using System.Windows;
using yt_dlp_GUI_Downloader.yt_dlp;

namespace yt_dlp_GUI_Downloader.Downloader
{
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Url_Add : Window
    {
        public Url_Add()
        {
            InitializeComponent();
            _vm = (App.Current as App).MainViewModel;

            Lang_Getter();
        }
        MainViewModel _vm;

        private async void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            OK_Button.Visibility = Visibility.Hidden;
            prog.Visibility = Visibility.Visible;
            Yt_dlp_Information_Getter get = new Yt_dlp_Information_Getter();
            var split_Url = Url_TextBox.Text.Split("\n");
            var IsAdded = await get.InformationExtractor(split_Url);

            if (IsAdded)
            {
                this.Close();
            }
            else
            {
                OK_Button.Visibility = Visibility.Visible;
                prog.Visibility = Visibility.Hidden;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
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
    }
}

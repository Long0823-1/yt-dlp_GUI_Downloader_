using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
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
        }
        MainViewModel _vm;

        private async void OK_Button_Click(object sender, RoutedEventArgs e)
        {
            OK_Button.Visibility = Visibility.Hidden;
            prog.Visibility = Visibility.Visible;
            Yt_dlp_Information_Getter get = new Yt_dlp_Information_Getter();
            var split_Url = Url_TextBox.Text.Split("\n");
            var IsAdded = await get.InformationExtractor(split_Url);
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

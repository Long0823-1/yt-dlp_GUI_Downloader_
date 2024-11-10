using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yt_dlp_GUI_Downloader.yt_dlp;
using static yt_dlp_GUI_Downloader.MainViewModel;

namespace yt_dlp_GUI_Downloader.Downloader
{
    public class RecentData
    {
        string Recent = @".\Recent";
        public RecentData() 
        {
            if(!Directory.Exists(Recent))
            {
                Directory.CreateDirectory(Recent);
            }
            _vm = (App.Current as App).MainViewModel;
        }
        MainViewModel _vm;

        public void GetRecent()
        {
            if (_vm.RecentDownloadItems.Count > 0)
            {
                _vm.RecentDownloadItems.Clear();
            }
            foreach (var file in Directory.GetFiles(@".\Recent"))
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    var RecentDataClass = JsonConvert.DeserializeObject<Items>(sr.ReadToEnd());
                    _vm.RecentDownloadItems.Add(RecentDataClass);
                }
            }
        }
    }
}

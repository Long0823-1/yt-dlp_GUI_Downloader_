using Microsoft.Toolkit.Uwp.Notifications;
namespace yt_dlp_GUI_Downloader.Downloader
{
    public class Toast
    {
        public static void ShowToast(string title, string body)
        {
            new ToastContentBuilder()
                        .AddText(title)
                        .AddText(body)
                        .SetToastDuration(ToastDuration.Short)
                        .SetToastScenario(ToastScenario.Default)
                        .Show();
        }
        public static void ShowToast(string title, string body, string uri)
        {
            new ToastContentBuilder()
                        .AddText(title)
                        .AddText(body)
                        .AddHeroImage(new Uri(uri))
                        .SetToastDuration(ToastDuration.Short)
                        .SetToastScenario(ToastScenario.Default)
                        .Show();
        }
    }
}

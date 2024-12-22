using System.Windows;

using KakaoTalk.Forms.UI.Views;

namespace KakaoTalk
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            KakaoWindow window = new();
            window.Show();
        }
    }
}

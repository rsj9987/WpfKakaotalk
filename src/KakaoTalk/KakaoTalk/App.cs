using System.Windows;

using Jamesnet.Wpf.Controls;

using KakaoTalk.Forms.UI.Views;

namespace KakaoTalk
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new KakaoWindow();
        }
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    KakaoWindow window = new();
        //    window.Show();
        //}

    }
}

using System.Windows;

using Jamesnet.Wpf.Controls;

using KakaoTalk.Core.Talking;
using KakaoTalk.Forms.UI.Views;

using Prism.Ioc;

namespace KakaoTalk
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new KakaoWindow();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterTypes(containerRegistry);

            containerRegistry.RegisterInstance(new TalkWindowManager());

        }
        //protected override void OnStartup(StartupEventArgs e)
        //{
        //    base.OnStartup(e);

        //    KakaoWindow window = new();
        //    window.Show();
        //}

    }
}

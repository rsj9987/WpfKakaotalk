using Jamesnet.Wpf.Global.Location;

using KakaoTalk.Forms.Local.ViewModels;
using KakaoTalk.Forms.UI.Views;
using KakaoTalk.Friends.Local.ViewModels;
using KakaoTalk.Friends.UI.Views;
using KakaoTalk.Login.Local.ViewModels;
using KakaoTalk.Login.UI.Views;
using KakaoTalk.Main.Local.ViewModels;
using KakaoTalk.Main.UI.Views;

namespace KakaoTalk.Settings
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<KakaoWindow, KakaoViewModel>();
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
        }
    }
}

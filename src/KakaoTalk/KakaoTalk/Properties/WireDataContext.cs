using Jamesnet.Wpf.Global.Location;

using KakaoTalk.Chats.Local.ViewModels;
using KakaoTalk.Chats.UI.Views;
using KakaoTalk.Forms.Local.ViewModels;
using KakaoTalk.Forms.UI.Views;
using KakaoTalk.Friends.Local.ViewModels;
using KakaoTalk.Friends.UI.Views;
using KakaoTalk.Login.Local.ViewModels;
using KakaoTalk.Login.UI.Views;
using KakaoTalk.Main.Local.ViewModels;
using KakaoTalk.Main.UI.Views;
using KakaoTalk.More.Local.ViewModels;
using KakaoTalk.More.UI.Views;
using KakaoTalk.Talk.Local.ViewModels;
using KakaoTalk.Talk.UI.Views;
using KakaoTalk.Tests.Local.ViewModels;
using KakaoTalk.Tests.UI.Views;

namespace KakaoTalk.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<KakaoWindow, KakaoViewModel>();
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
            items.Register<ChatsContent, ChatsContentViewModel>();
            items.Register<MoreContent, MoreContentViewModel>();

            items.Register<TalkWindow, TalkViewModel>();
            items.Register<TalkContent, TalkContentViewModel>();

            items.Register<SimulatorWindow, SimulatorViewModel>();

            items.Register<GoogleWindow, GoogleViewModel>();
        }
    }
}

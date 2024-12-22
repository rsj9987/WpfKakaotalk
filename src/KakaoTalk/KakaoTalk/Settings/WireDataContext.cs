using Jamesnet.Wpf.Global.Location;

using KakaoTalk.Login.Local.ViewModels;
using KakaoTalk.Login.UI.Views;

namespace KakaoTalk.Settings
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<LoginContent, LoginContentViewModel>();
        }
    }
}

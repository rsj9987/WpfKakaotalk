using Jamesnet.Wpf.Controls;

using KakaoTalk.Core.Names;
using KakaoTalk.Friends.UI.Views;
using KakaoTalk.Login.UI.Views;
using KakaoTalk.Main.UI.Views;

using Prism.Ioc;
using Prism.Modularity;

namespace KakaoTalk.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, MainContent>(ContentNameManager.Main);
            containerRegistry.RegisterSingleton<IViewable, FriendsContent>(ContentNameManager.Friends);
        }

    }
}

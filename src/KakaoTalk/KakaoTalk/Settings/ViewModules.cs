using Jamesnet.Wpf.Controls;

using KakaoTalk.Login.UI.Views;

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
            containerRegistry.RegisterSingleton<IViewable, LoginContent>("LoginContent");
        }

    }
}

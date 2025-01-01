using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Event;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Args;
using KakaoTalk.Core.Events;
using KakaoTalk.Core.Names;
using KakaoTalk.Login.UI.Views;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Login.Local.ViewModels
{
    public partial class LoginContentViewModel : ObservableBase
    {
        private readonly IEventHub _eventHub;
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        private GoogleWindow _window = default!;

        public LoginContentViewModel(IEventHub eventHub, IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _eventHub = eventHub;
            _regionManager = regionManager;
            _containerProvider = containerProvider;

            _eventHub.Subscribe<LoginCompletedPubSub, LoginCompletedArgs>(LoginCompleted);
        }

        private void LoginCompleted(LoginCompletedArgs args)
        {
            _window.Close();

            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            IViewable mainContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Main);

            if (!mainRegion.Views.Contains(mainContent))
            {
                mainRegion.Add(mainContent);
            }

            // Friends Content로 변경
            mainRegion.Activate(mainContent);
        }

        [RelayCommand]
        private void Login()
        {
            _window = new();
            _window.Show();
        }
    }
}

using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Names;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Login.Local.ViewModels
{
    public partial class LoginContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public LoginContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Login()
        {
            // Region에 등록된 것을 string Index로 가져옴
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];
            // ViewModules에서 컨테이너에 등록된 FriendsContent를 가져옴
            IViewable friendsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Friends);

            // FriendsContent 중복등록 예외처리
            if (!mainRegion.Views.Contains(friendsContent))
            {
                mainRegion.Add(friendsContent);
            }

            // Friends Content로 변경
            mainRegion.Activate(friendsContent);
        }
    }
}

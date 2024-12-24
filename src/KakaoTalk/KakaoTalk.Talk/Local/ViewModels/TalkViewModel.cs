using Jamesnet.Wpf.Controls;

using KakaoTalk.Core.Names;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Talk.Local.ViewModels
{
    public class TalkViewModel : IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public TalkViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(IViewable view)
        {
            // CustomControl 생성자가 여러번 Resolve 함수를 탈 때마다 생성되는 것을 방지하기 위해 처음 Load 될 때 등록해놓는다.
            // KakakTalk -> DirectModules.cs 참조
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];

            var loginContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Login);

            if (!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);
            }

            mainRegion.Activate(loginContent);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Controls;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Forms.Local.ViewModels
{
    public class KakaoViewModel : IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public KakaoViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        public void OnLoaded(IViewable view)
        {
            // CustomControl 생성자가 여러번 Resolve 함수를 탈 때마다 생성되는 것을 방지하기 위해 처음 Load 될 때 등록해놓는다.
            // KakakTalk -> DirectModules.cs 참조
            IRegion mainRegion = _regionManager.Regions["MainRegion"];

            var loginContent = _containerProvider.Resolve<IViewable>("LoginContent");

            if (!mainRegion.Views.Contains(loginContent))
            {
                mainRegion.Add(loginContent);
            }

            mainRegion.Activate(loginContent);
        }
    }
}

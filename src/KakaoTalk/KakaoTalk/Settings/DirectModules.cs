using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;

using Unity;

namespace KakaoTalk.Settings
{
    internal class DirectModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            // OnInitialized 실행이 안됨 (version : .net 8.0)
            //IRegionManager regionManager = containerProvider.Resolve<IRegionManager>();
            //regionManager.RegisterViewWithRegion("MainRegion", typeof(LoginContent));
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 첫 App이 실행될 때 RegisterTypes가 실행됨
            // 그래서 ContainerRegistry에서 IUnityContainer를 가져온 뒤
            // Resolve를 통해서 IRegionManager를 획득
            // IRegionManager를 통해서 Region을 View와 함께 주입
            IUnityContainer container = containerRegistry.GetContainer();
            IRegionManager regionManager = container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("MainRegion", "LoginContent");
        }

    }
}

﻿using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Names;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.More.Local.ViewModels
{
    public partial class MoreContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public MoreContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }


        [RelayCommand]
        private void Logout()
        {
            IRegion mainRegion = _regionManager.Regions[RegionNameManager.MainRegion];

            var mainContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Main);

            if (!mainRegion.Views.Contains(mainContent))
            {
                mainRegion.Add(mainContent);
            }

            mainRegion.Activate(mainContent);
        }
    }
}

﻿using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Names;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
        }

        [RelayCommand]
        private void Friends()
        {
            IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];

            var friendsContent = _containerProvider.Resolve<IViewable>(ContentNameManager.Friends);

            if (!contentRegion.Views.Contains(friendsContent))
            {
                contentRegion.Add(friendsContent);
            }

            contentRegion.Activate(friendsContent);
        }

        [RelayCommand]
        private void Logout()
        {
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
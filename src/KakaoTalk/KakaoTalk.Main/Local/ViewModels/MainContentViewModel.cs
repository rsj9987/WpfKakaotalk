﻿
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Models;
using KakaoTalk.Core.Names;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase, IViewLoadable
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        [ObservableProperty]
        private List<MenuModel> _menus = default!;

        [ObservableProperty]
        private MenuModel _menu = default!;

        public MainContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;

        }

        partial void OnMenuChanged(MenuModel value)
        {
            try
            {
                IRegion contentRegion = _regionManager.Regions[RegionNameManager.ContentRegion];

                var content = _containerProvider.Resolve<IViewable>(value.Id);

                if (!contentRegion.Views.Contains(content))
                {
                    contentRegion.Add(content);
                }

                contentRegion.Activate(content);
            }
            catch (Exception)
            {

            }
        }

        private List<MenuModel> GetMenus()
        {
            List<MenuModel> source = new()
            {
                new MenuModel().DataGetn(ContentNameManager.Friends),
                new MenuModel().DataGetn(ContentNameManager.Chats),
                new MenuModel().DataGetn(ContentNameManager.More),
            };

            return source;
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

        public void OnLoaded(IViewable view)
        {
            Menus = GetMenus();
            Menu = Menus[0];
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Models;
using KakaoTalk.Core.Names;
using KakaoTalk.Talk.UI.Views;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Friends.Local.ViewModels
{
    public partial class FriendsContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;

        [ObservableProperty]
        private List<FriendsModel> _favorites;

        public FriendsContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;

            Favorites = GetFavorites();
        }

        private List<FriendsModel> GetFavorites()
        {
            List<FriendsModel> source = new()
            {
                new FriendsModel().DataGen(1, "James"),
                new FriendsModel().DataGen(2, "Vickey"),
                new FriendsModel().DataGen(3, "Hardey"),
            };

            return source;
        }

        [RelayCommand]
        private void DoubleClick(FriendsModel data)
        {
            TalkWindow talkWindow = new();
            talkWindow.Title = data.Name;
            talkWindow.Width = 360;
            talkWindow.Height = 500;
            talkWindow.ShowDialog();
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

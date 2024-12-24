using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Models;
using KakaoTalk.Core.Names;
using KakaoTalk.Core.Talking;
using KakaoTalk.Talk.UI.Views;

using Prism.Ioc;
using Prism.Regions;

namespace KakaoTalk.Friends.Local.ViewModels
{
    public partial class FriendsContentViewModel : ObservableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IContainerProvider _containerProvider;
        private readonly TalkWindowManager _talkWindowManager;

        [ObservableProperty]
        private List<FriendsModel> _favorites;

        public FriendsContentViewModel(IRegionManager regionManager, IContainerProvider containerProvider, TalkWindowManager talkWindowManager)
        {
            _regionManager = regionManager;
            _containerProvider = containerProvider;
            _talkWindowManager = talkWindowManager;
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
            TalkWindow talkWindow = _talkWindowManager.ResolveWindow<TalkWindow>(data.Id);
            if (talkWindow.IsLoaded) return;
            talkWindow.Title = data.Name;
            talkWindow.Width = 360;
            talkWindow.Height = 500;
            talkWindow.Show();
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

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Global.Event;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Args;
using KakaoTalk.Core.Events;

namespace KakaoTalk.Login.Local.ViewModels
{
    public partial class GoogleViewModel : ObservableBase
    {
        private readonly IEventHub _eventHub;
        [ObservableProperty]
        private string _loginUrl;
        public GoogleViewModel(IEventHub eventHub)
        {
            LoginUrl = "https://localhost:7121/Account/Login";
            _eventHub = eventHub;
        }

        [RelayCommand]
        private void LoginCompleted(string email)
        {
            LoginCompletedArgs args = new();
            args.Email = email;
            _eventHub.Publish<LoginCompletedPubSub, LoginCompletedArgs>(args);
        }
    }
}

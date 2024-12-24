using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Models;

namespace KakaoTalk.Talk.Local.ViewModels
{
    public partial class TalkContentViewModel : ObservableBase
    {
        [ObservableProperty]
        private string _sendText;

        [ObservableProperty]
        private ObservableCollection<MessageModel> _chats;

        public TalkContentViewModel()
        {
            SendText = "";

            Chats = new();
        }

        [RelayCommand]
        private void Send()
        {
            Chats.Add(new MessageModel().DataGen("Send", SendText));
            SendText = "";
        }
    }
}

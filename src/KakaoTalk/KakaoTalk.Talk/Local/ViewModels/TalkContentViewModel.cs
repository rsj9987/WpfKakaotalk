using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Interfaces;
using KakaoTalk.Core.Models;
using KakaoTalk.Core.Talking;

namespace KakaoTalk.Talk.Local.ViewModels
{
    public partial class TalkContentViewModel : ObservableBase, IReceivedMessage
    {
        [ObservableProperty]
        private string _sendText;

        [ObservableProperty]
        private ObservableCollection<MessageModel> _chats;
        private readonly ChatStorage _chatStorage;

        public TalkContentViewModel()
        {
            _chatStorage = chatStorage;

            SendText = "";
            Chats = new();
        }

        [RelayCommand]
        private void Send()
        {
            Chats.Add(new MessageModel().DataGen("Send", SendText));
            SendText = "";
        }

        public void Receive(string? receiveText)
        {
            Chats.Add(new MessageModel().DataGen("Receive", receiveText ?? ""));
        }
    }
}

using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Interfaces;
using KakaoTalk.Core.Models;
using KakaoTalk.Core.Talking;

namespace KakaoTalk.Talk.Local.ViewModels
{
    public partial class TalkContentViewModel : ObservableBase, IReceivedMessage, IReceiverInfo, IViewLoadable
    {
        private FriendsModel _receiver = default!;
        private readonly ChatStorage _chatStorage;

        [ObservableProperty]
        private string _sendText;

        [ObservableProperty]
        private ObservableCollection<MessageModel> _chats = new();

        public TalkContentViewModel(ChatStorage chatStorage)
        {
            _chatStorage = chatStorage;

            SendText = "";
        }

        [RelayCommand]
        private void Send()
        {
            var message = new MessageModel().DataGen("Send", SendText);
            Chats.Add(message);
            _chatStorage.Add(_receiver, message);
            SendText = "";

        }

        public void Receive(string? receiveText)
        {
            var message = new MessageModel().DataGen("Receive", receiveText ?? "");
            Chats.Add(message);
            _chatStorage.Add(_receiver, message);
        }

        public void InitReceiver(FriendsModel data)
        {
            _receiver = data;
        }

        public void OnLoaded(IViewable view)
        {
            var chathistory = _chatStorage.GetChatHistory(_receiver);
            Chats.Clear();

            foreach (var chat in chathistory)
            {
                Chats.Add(chat);
            }

        }

    }
}

using System.Windows;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Event;
using Jamesnet.Wpf.Mvvm;

using KakaoTalk.Core.Args;
using KakaoTalk.Core.Events;
using KakaoTalk.Core.Interfaces;
using KakaoTalk.Core.Talking;

namespace KakaoTalk.Tests.Local.ViewModels
{
    public partial class SimulatorViewModel : ObservableBase, IViewLoadable
    {
        private readonly IEventHub _eventHub;
        private readonly TalkWindowManager _talkWindowManager;

        [ObservableProperty]
        private List<KeyValuePair<string, JamesWindow>> _talkWindows = default!;

        [ObservableProperty]
        private string? _receiveText;
        [ObservableProperty]
        private KeyValuePair<string, JamesWindow> _selectedWindow;

        public SimulatorViewModel(IEventHub eventHub, TalkWindowManager talkWindowManager)
        {
            _eventHub = eventHub;
            _talkWindowManager = talkWindowManager;

            _eventHub.Subscribe<RefreshTalkWindowEvent, RefreshTalkWindowArgs>((args) => Refresh());
        }

        [RelayCommand]
        private void Receive()
        {
            var content = SelectedWindow.Value.Content;
            if (content is FrameworkElement fe && fe.DataContext is IReceivedMessage receive)
            {
                receive.Receive(ReceiveText);
            }
            ReceiveText = "";
        }

        [RelayCommand]
        private void Refresh()
        {
            TalkWindows = _talkWindowManager.GetAllWindows();
        }

        public void OnLoaded(IViewable view)
        {
            Refresh();
        }
    }
}

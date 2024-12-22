using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Chats.UI.Views
{
    public class ChatsContent : JamesContent
    {
        static ChatsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatsContent), new FrameworkPropertyMetadata(typeof(ChatsContent)));
        }
    }
}

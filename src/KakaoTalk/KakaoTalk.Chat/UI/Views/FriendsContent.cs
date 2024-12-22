using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Chat.UI.Views
{
    public class FriendsContent : JamesContent
    {
        static FriendsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsContent), new FrameworkPropertyMetadata(typeof(FriendsContent)));
        }
    }
}

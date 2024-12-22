using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Friends.UI.Views
{
    public class FriendsContent : JamesContent
    {
        static FriendsContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsContent), new FrameworkPropertyMetadata(typeof(FriendsContent)));
        }
    }
}

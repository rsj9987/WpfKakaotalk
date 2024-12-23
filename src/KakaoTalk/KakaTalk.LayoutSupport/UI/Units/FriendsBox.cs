using System.Windows;
using System.Windows.Controls;

namespace KakaoTalk.LayoutSupport.UI.Units
{
    public class FriendsBox : ListBox
    {
        static FriendsBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FriendsBox), new FrameworkPropertyMetadata(typeof(FriendsBox)));
        }
    }
}

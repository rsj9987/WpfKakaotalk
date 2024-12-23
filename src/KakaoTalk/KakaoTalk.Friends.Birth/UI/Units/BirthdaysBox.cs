using System.Windows;

using KakaoTalk.LayoutSupport.UI.Units;

namespace KakaoTalk.Friends.Birth.UI.Units
{
    public class BirthdaysBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new BirthdaysBoxItem();

        }
    }
}

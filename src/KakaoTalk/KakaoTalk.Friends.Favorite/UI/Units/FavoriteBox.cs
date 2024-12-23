using System.Windows;

using KakaoTalk.LayoutSupport.UI.Units;

namespace KakaoTalk.Friends.Favorite.UI.Units
{
    public class FavoriteBox : FriendsBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new FavoriteBoxItem();

        }
    }
}

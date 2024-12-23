using System.Windows;
using System.Windows.Controls;

namespace KakaoTalk.Friends.Birth.UI.Units
{
    public class BirthdaysBoxItem : ListBoxItem
    {
        static BirthdaysBoxItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(BirthdaysBoxItem), new FrameworkPropertyMetadata(typeof(BirthdaysBoxItem)));
        }
    }
}

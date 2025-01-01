using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Login.UI.Views
{
    public class GoogleWindow : JamesWindow
    {
        static GoogleWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GoogleWindow), new FrameworkPropertyMetadata(typeof(GoogleWindow)));
        }
    }
}

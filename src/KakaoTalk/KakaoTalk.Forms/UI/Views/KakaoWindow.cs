using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Forms.UI.Views
{
    public class KakaoWindow : JamesWindow
    {
        static KakaoWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KakaoWindow), new FrameworkPropertyMetadata(typeof(KakaoWindow)));
        }

    }
}

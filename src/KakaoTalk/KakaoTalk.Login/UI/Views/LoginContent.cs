using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Login.UI.Views
{
    public class LoginContent : JamesContent
    {
        static LoginContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginContent), new FrameworkPropertyMetadata(typeof(LoginContent)));
        }
    }
}

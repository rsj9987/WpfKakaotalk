using System.Windows;
using System.Windows.Input;

using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;

namespace KakaoTalk.Login.UI.Units
{
    public class KakaoWebView : WebView2
    {


        public ICommand LoginCompletedCommand
        {
            get { return (ICommand)GetValue(LoginCompletedCommandProperty); }
            set { SetValue(LoginCompletedCommandProperty, value); }
        }

        public static readonly DependencyProperty LoginCompletedCommandProperty =
            DependencyProperty.Register("LoginCompleted", typeof(ICommand), typeof(KakaoWebView), new PropertyMetadata(null));




        public KakaoWebView()
        {
            WebMessageReceived += KakaoWebView_WebMessageReceived;
        }

        private void KakaoWebView_WebMessageReceived(object? sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string userEmail = e.TryGetWebMessageAsString();
            LoginCompletedCommand.Execute(userEmail);
        }
    }
}

using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Talk.UI.Views
{
    public class TalkContent : JamesContent
    {
        static TalkContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TalkContent), new FrameworkPropertyMetadata(typeof(TalkContent)));
        }
    }
}

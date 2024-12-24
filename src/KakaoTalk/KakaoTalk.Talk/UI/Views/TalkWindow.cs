using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Talk.UI.Views
{
    public class TalkWindow : JamesWindow
    {
        static TalkWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TalkWindow), new FrameworkPropertyMetadata(typeof(TalkWindow)));
        }

        //public KakaoWindow()
        //{
        //// 투명도 조절해서 이미지에 맞춰보기 위해 작성
        //WindowStyle = WindowStyle.None;
        //AllowsTransparency = true;
        //}

    }
}

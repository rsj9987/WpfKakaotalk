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

        //public KakaoWindow()
        //{
        //// 투명도 조절해서 이미지에 맞춰보기 위해 작성
        //WindowStyle = WindowStyle.None;
        //AllowsTransparency = true;
        //}

    }
}

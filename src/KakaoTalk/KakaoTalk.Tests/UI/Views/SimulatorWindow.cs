using System.Windows;

using Jamesnet.Wpf.Controls;

namespace KakaoTalk.Tests.UI.Views
{
    public class SimulatorWindow : JamesWindow
    {
        static SimulatorWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SimulatorWindow), new FrameworkPropertyMetadata(typeof(SimulatorWindow)));
        }

        //public KakaoWindow()
        //{
        //// 투명도 조절해서 이미지에 맞춰보기 위해 작성
        //WindowStyle = WindowStyle.None;
        //AllowsTransparency = true;
        //}

    }
}

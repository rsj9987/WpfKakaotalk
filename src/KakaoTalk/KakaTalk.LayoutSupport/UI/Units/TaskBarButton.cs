using System.Windows;
using System.Windows.Controls;

namespace KakaoTalk.LayoutSupport.UI.Units
{
    public class TaskBarButton : Button
    {
        static TaskBarButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TaskBarButton), new FrameworkPropertyMetadata(typeof(TaskBarButton)));
        }
    }
}

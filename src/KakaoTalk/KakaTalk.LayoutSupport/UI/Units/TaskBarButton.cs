using System.Windows;
using System.Windows.Controls;

namespace KakaoTalk.LayoutSupport.UI.Units
{
    public class TaskBarButton : Control
    {
        static TaskBarButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TaskBarButton), new FrameworkPropertyMetadata(typeof(TaskBarButton)));
        }
    }
}

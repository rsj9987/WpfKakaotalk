using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KakaoTalk.Main.UI.Units
{
    public class VerticalMenuList : ListBox
    {
        static VerticalMenuList()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(VerticalMenuList), new FrameworkPropertyMetadata(typeof(VerticalMenuList)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            // return new ListBoxItem();
            // 위와 같이 인식
            //return base.GetContainerForItemOverride();

            // 아래와 같이 변경하여 ListBoxItem 연결
            return new VerticalMenuListItem();
        }
    }
}

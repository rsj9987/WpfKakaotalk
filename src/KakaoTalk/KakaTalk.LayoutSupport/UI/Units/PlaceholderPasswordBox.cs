using System.Windows;
using System.Windows.Controls;

namespace KakaoTalk.LayoutSupport.UI.Units
{
    public class PlaceholderPasswordBox : TextBox
    {


        public string PlaceholderText
        {
            get { return (string)GetValue(PlaceholderTextProperty); }
            set { SetValue(PlaceholderTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceholderText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceholderTextProperty =
            DependencyProperty.Register("PlaceholderText", typeof(string), typeof(PlaceholderPasswordBox), new PropertyMetadata(""));


        static PlaceholderPasswordBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlaceholderPasswordBox), new FrameworkPropertyMetadata(typeof(PlaceholderPasswordBox)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();



            if (GetTemplateChild("PART_PasswordBox") is PasswordBox pwd)
            {
                pwd.PasswordChanged += Pwd_PasswordChanged;
            }
        }

        private void Pwd_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox pwd)
            {
                SetValue(TextProperty, pwd.Password);
            }
        }

        private void CustomPasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource == this)
            {
                PasswordBox? passwordBox = GetTemplateChild("PART_PasswordBox") as PasswordBox;
                if (passwordBox != null)
                {
                    passwordBox.Focus();
                }
            }
        }
    }
}

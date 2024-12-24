using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KakaoTalk.LayoutSupport.UI.Units
{

    public class SendTextBox : TextBox
    {


        public ICommand EnterCommand
        {
            get { return (ICommand)GetValue(EnterCommandProperty); }
            set { SetValue(EnterCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EnterCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EnterCommandProperty =
            DependencyProperty.Register("EnterCommand", typeof(ICommand), typeof(SendTextBox), new PropertyMetadata(null));

        static SendTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SendTextBox), new FrameworkPropertyMetadata(typeof(SendTextBox)));
        }

        public SendTextBox()
        {
            PreviewKeyDown += SendTextBox_PreviewKeyDown;
        }

        private void SendTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && Keyboard.IsKeyDown(Key.LeftShift))
            {
                int caretIndex = this.CaretIndex;
                SetValue(TextProperty, this.Text.Insert(caretIndex, Environment.NewLine));
                this.CaretIndex = caretIndex + Environment.NewLine.Length;
                e.Handled = true;
            }
            else if (e.Key == Key.Enter && EnterCommand != null && EnterCommand.CanExecute(null))
            {
                EnterCommand.Execute(null);
            }
        }
    }
}

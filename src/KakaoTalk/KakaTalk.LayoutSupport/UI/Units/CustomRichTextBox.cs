using System.Collections;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

using KakaoTalk.Core.Interfaces;

namespace KakaoTalk.LayoutSupport.UI.Units
{
    public class CustomRichTextBox : RichTextBox
    {
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(CustomRichTextBox), new PropertyMetadata(null, OnitemsSourceChanged));
        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public CustomRichTextBox()
        {
            Document = new FlowDocument();
        }

        private static void OnitemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CustomRichTextBox? richTextBox = d as CustomRichTextBox;

            if (richTextBox == null) return;

            if (e.OldValue is INotifyCollectionChanged oldCollection)
            {
                oldCollection.CollectionChanged -= richTextBox.OnCollectionChanged;
            }

            if (e.NewValue is INotifyCollectionChanged newCollection)
            {
                newCollection.CollectionChanged += richTextBox.OnCollectionChanged;
            }
        }

        private void OnCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            UpdateFlowDocument();
        }

        private void UpdateFlowDocument()
        {
            FlowDocument document = new();
            if (ItemsSource != null)
            {
                foreach (var item in ItemsSource)
                {
                    var control = GetTextContainerItemForOverride();
                    control.DataContext = item;
                    //BlockUIContainer buc = new();
                    //buc.Child = control;
                    InlineUIContainer buc = new();
                    buc.Child = control;
                    Paragraph p = new();
                    p.Margin = new(0);

                    if (item is IMessage message)
                    {
                        p.TextAlignment = message.Type == "Send"
                            ? TextAlignment.Right
                            : TextAlignment.Left;
                    }

                    p.Inlines.Add(buc);
                    document.Blocks.Add(p);
                }
            }
            Document = document;

            ScrollToEnd();
        }

        protected virtual Control GetTextContainerItemForOverride()
        {
            Control control = new();
            return control;
        }
    }
}

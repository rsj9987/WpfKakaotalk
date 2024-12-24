using System.Windows.Controls;

using KakaoTalk.LayoutSupport.UI.Units;
using KakaoTalk.Talk.TextMessage.UI.Units;

namespace KakaoTalk.Talk.UI.Units
{

    public class ChatRichTextBox : CustomRichTextBox
    {
        protected override Control GetTextContainerItemForOverride()
        {
            return new TextMessageItem();
        }
    }
}

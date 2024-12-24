
using KakaoTalk.Core.Interfaces;

namespace KakaoTalk.Core.Models
{
    public class MessageModel : IMessage
    {
        public string Type { get; set; } = default!;
        public string Message { get; set; } = default!;

        public MessageModel DataGen(string type, string message)
        {
            Type = type;
            Message = message;
            return this;
        }
    }
}

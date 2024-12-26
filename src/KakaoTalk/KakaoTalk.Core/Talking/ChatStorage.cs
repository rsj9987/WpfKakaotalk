using KakaoTalk.Core.Models;

namespace KakaoTalk.Core.Talking
{
    public class ChatStorage
    {
        private Dictionary<FriendsModel, List<MessageModel>> _chatHistory;

        public ChatStorage()
        {
            _chatHistory = new();
        }

        public void Add(FriendsModel receiver, MessageModel message)
        {
            if (!_chatHistory.ContainsKey(receiver))
            {
                _chatHistory.Add(receiver, new());
            }

            _chatHistory[receiver].Add(message);
        }

        public List<MessageModel> GetChatHistory(FriendsModel receiver)
        {
            if (!_chatHistory.ContainsKey(receiver))
            {
                _chatHistory.Add(receiver, new());
            }

            return _chatHistory[receiver];
        }
    }
}

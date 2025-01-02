using KakaoTalk.Core.Models;

namespace KakaoTalk.Core.Args
{
    public class SyncFriendsArgs : EventArgs
    {
        public List<FriendsModel> Friends { get; set; } = default!;
    }
}

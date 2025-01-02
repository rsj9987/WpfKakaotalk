
namespace KakaoTalk.Core.Models
{
    public class FriendsModel
    {
        public string? Id { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }

        public FriendsModel DataGen(string id, string name)
        {
            Id = id;
            UserName = name;

            return this;
        }
    }
}

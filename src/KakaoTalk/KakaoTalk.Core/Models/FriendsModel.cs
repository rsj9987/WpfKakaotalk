
namespace KakaoTalk.Core.Models
{
    public class FriendsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FriendsModel DataGen(int id, string name)
        {
            Id = id;
            Name = name;

            return this;
        }
    }
}

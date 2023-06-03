using Domain.Base;

namespace Domain
{
    public class UserSocial : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
        public string Youtube { get; set; }
        public string Medium { get; set; }
    }
}
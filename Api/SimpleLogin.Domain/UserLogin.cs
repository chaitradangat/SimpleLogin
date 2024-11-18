namespace SimpleLogin.Domain
{
    public class UserLogin
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string UserEmail { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }
    }
}

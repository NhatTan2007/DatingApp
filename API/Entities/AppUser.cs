namespace API.Entities
{
    public class AppUser
    {
        private int _id;
        private string _userName;

        public int Id { get => _id; set => _id = value; }
        public string UserName { get => _userName; set => _userName = value; }
    }
}
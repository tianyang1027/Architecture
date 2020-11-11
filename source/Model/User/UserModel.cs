namespace Architecture.Model
{
    public class UserModel
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public AuthModel Auth { get; set; }
    }
}

namespace BookATable.Services
{
    using Entities;
    using Repositories;

    public class AuthenticationService
    {
        public static User LoggedUser { get; set; }

        public static User Authenticate(string email, string password)
        {
            LoggedUser = new UserRepository().Get(u => u.Email == email && u.Password == password);
            return LoggedUser;
        }
    }
}

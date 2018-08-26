
namespace BookATable.Services
{
    using global::BookATable.Entities;
    using global::BookATable.Repositories;

    public class AuthenticationService
    {
        public static User LoggedUser { get; set; }

        public static User Authenticate(string email, string password)
        {
            LoggedUser = new UserRepository().Get(u => u.Email == email
                                                && u.Password == password);
            return LoggedUser;
        }
    }
}

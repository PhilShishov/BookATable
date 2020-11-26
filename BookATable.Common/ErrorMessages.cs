namespace BookATable.Common
{
    public class ErrorMessages
    {
        public const string ErrorMessageTemplate = "Something wrong happened in the {0} Form: ";

        public const string InvalidLogin = "Wrong email or password!";
        public const string InvalidPassword = "Password must be at least 8 characters.";
        public const string EmptyInputFields = "Please complete empty fields.";
        public const string InvalidCapacity = "Capacity must be greater than zero.";
        public const string InvalidNumberPeople = "Number of people must be greater than zero.";
    }
}

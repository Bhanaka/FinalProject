namespace UserService.Services
{
    public class SystemUserService
    {
        public String LoginRequestParam(string username, string password)
        {
            // Example of a simple login check
            if (username == "admin" && password == "1234")
            {
                return "Login successful!";
            }
            else
            {
                return "Invalid username or password.";
            }

        }
    }
}

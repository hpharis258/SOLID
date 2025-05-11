using solidConsoleApp;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    private ILogger _logger;

    public User(string name, string email, string password, ILogger logger)
    {
        Name = name;
        Email = email;
        Password = password;
        _logger = logger;
    }
    public void AddToMailingList()
    {
        try
        {
            // Logic to add user to mailing list
            Console.WriteLine($"{Name} has been added to the mailing list.");
        }
        catch (Exception ex)
        {
            // Now the User Class is responsible not responsible for logging the error
            if (this._logger != null)
            {
                this._logger.LogError("An error occurred while adding to the mailing list.", ex);
            }
        }

    }

}
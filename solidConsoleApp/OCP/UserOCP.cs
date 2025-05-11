public abstract class UserOCP
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public UserOCP(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }

    public abstract long GetDiscount();
}

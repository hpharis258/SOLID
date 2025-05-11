// DIP Demonstration

public class Email : IMessageService
{
    private string _email;
    private string _message;
    public Email(string email, string message)
    {
        _email = email;
        _message = message;
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"Email sent to {_email} with message: {message}");
    }
}
public class SMS : IMessageService
{
    private string _phoneNumber;
    private string _message;
    public SMS(string phoneNumber, string message)
    {
        _phoneNumber = phoneNumber;
        _message = message;
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"SMS sent to {_phoneNumber} with message: {message}");
    }
}
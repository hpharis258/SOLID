public class UserISP : ISendEmail
{
    public string Name { get; set; }
    public string Email { get; set; }

    public UserISP(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void SendEmail(string email, string subject, string body)
    {
        // Some logic to send email
        Console.WriteLine($"Email sent to {email} with subject: {subject}");
        // Don't need to implement all of the other methods in the interface
        // because we are only implementing the ISendEmail interface
        // This is a good example of the Interface Segregation Principle
    }
}

// Interface Segregation Principle (ISP) states that no client should be forced to depend on methods it does not use.
// This is really simple to understand.
// A bad example of this would be a class that implements an interface with a lot of methods.
public interface IEmailSender
{
    void SendEmail(string email, string subject, string body);
    void SendBulkEmail(string[] emails, string subject, string body);
    void SendEmailWithAttachment(string email, string subject, string body, string attachmentPath);
    void SendEmailWithCC(string email, string subject, string body, string cc);
    void SendEmailWithBCC(string email, string subject, string body, string bcc);
    void SendEmailWithReplyTo(string email, string subject, string body, string replyTo);
    void SendEmailWithPriority(string email, string subject, string body, int priority);
}

// A good example of this would be.
/// <summary>
// Two separate interfaces: ISendEmail and ISendBulkEmail.
// This way I can pick and choose which interface I want to implement.
/// </summary>
public interface ISendEmail
{
    void SendEmail(string email, string subject, string body);
}

public interface ISendBulkEmail
{
    void SendBulkEmail(string[] emails, string subject, string body);
}
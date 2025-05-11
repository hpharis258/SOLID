// This class violates the Dependency Inversion Principle (DIP)
// because it depends on a concrete implementation of the Email class.

// This create a tight coupling between the Notification class and the Email class.
// This means that if we want to change the implementation of the Email class,
// we will have to change the Notification class as well.
public class Notification
{
    private IMessageService messageService;
    public Notification(IMessageService messageService)
    {
        this.messageService = messageService;
    }

    public void SendNotification()
    {
        // Logic to send notification
        messageService.SendMessage("This is a notification message.");
    }
}
// Here is how to fix it.
// We can create an interface that defines the contract for sending notifications.
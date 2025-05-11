public class BronzeUserOCP : UserOCP
{
    public BronzeUserOCP(string name, string email, string password) : base(name, email, password)
    {
    }
    public override long GetDiscount()
    {
        return 5;
    }
}
// You can keep adding new user types without modifying the existing code.
// This adheres to the Open/Closed Principle, as the code is open for extension (new user types) but closed for modification (existing code remains unchanged).
// This is a simple example of how to implement the Open/Closed Principle in C#.
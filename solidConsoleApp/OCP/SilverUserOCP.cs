public class SilverUserOCP : UserOCP
{
    public SilverUserOCP(string name, string email, string password) : base(name, email, password)
    {
    }
    public override long GetDiscount()
    {
        return 10;
    }
}
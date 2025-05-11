public class GoldUserOCP : UserOCP
{
    public GoldUserOCP(string name, string email, string password) : base(name, email, password)
    {
    }
    public override long GetDiscount()
    {
        return 20;
    }
}
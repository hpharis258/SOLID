
// Example Liskov Substitution Principle
// BASE CLASS
public abstract class UserLSP
{
    public abstract bool ResetPassword(string password);
}

// Derived class
public class RegisteredUserLSP : UserLSP
{
    public override bool ResetPassword(string password)
    {
        // Logic to reset password for registered user
        Console.WriteLine($"Password reset for registered user: {password}");
        return true;
    }
}

public class GuestUserLSP : UserLSP
{
    public override bool ResetPassword(string password)
    {
        // Even though gues users are not allowed to reset passwords, we are still implementing the method
        // to satisfy the base class contract
        return false; // Guests cannot reset passwords 

    }
}

// WHY Following LSP is Important?
//Adhering to the Liskov Substitution Principle is crucial for building maintainable and testable OOP systems. 
//When LSP is followed, derived classes can seamlessly replace base classes, which means you can extend systems 
//with new subclasses without modifying existing code that uses the base class. 
//This leads to more robust and flexible code because callers don’t need to know the concrete subtype 
//they are dealing with – they won’t encounter unexpected errors or need special-case logic for certain subclasses.
// As a result, the code is easier to understand and easier to maintain, since class hierarchies behave in a 
//predictable manner. 
//It also improves testability: you can write tests against base class behavior and be confident 
//that all subclasses will pass those same tests. 
//In summary, following LSP helps avoid “code surprises” and cascading changes, allowing developers to 
//reuse and extend classes with minimal risk, which is a cornerstone of reliable object-oriented design.

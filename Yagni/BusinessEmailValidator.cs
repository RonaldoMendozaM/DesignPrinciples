namespace Yagni;
public class BusinessEmailValidator : EmailValidator
{
    public override bool IsValid(string email)
    {
        return true; 
    }
}
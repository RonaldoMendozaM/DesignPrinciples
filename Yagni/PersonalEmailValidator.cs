namespace Yagni;
public class PersonalEmailValidator : EmailValidator
{
    public override bool IsValid(string email)
    {
        return true; 
    }
}
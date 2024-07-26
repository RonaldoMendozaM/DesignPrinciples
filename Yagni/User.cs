namespace Yagni;
public class User
{
    public string Email { get; set; }
    public EmailValidator EmailValidator { get; set; }

    public bool IsValidEmail()
    {
        return EmailValidator.IsValid(Email);
    }
}
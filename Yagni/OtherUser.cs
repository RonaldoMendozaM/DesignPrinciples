namespace Yagni;
public class OtherUser
{
    public string Email { get; set; }

    public bool IsValidEmail()
    {
        return Email.Contains("@") && Email.Contains(".");
    }
}
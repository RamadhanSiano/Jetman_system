using Microsoft.AspNetCore.Identity;

public class UserModel : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }

    // Add other properties as needed
}

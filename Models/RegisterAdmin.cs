using System.ComponentModel.DataAnnotations;

public class RegisterAdmin
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [StringLength(100)]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Required]
    [StringLength(100)]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [StringLength(100)]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    [Display(Name = "Repeat Password")]
    public string RepeatPassword { get; set; }
}

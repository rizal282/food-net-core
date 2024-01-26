using System.ComponentModel.DataAnnotations;

namespace foodapi.Data.Request;

public class CustomerRequest
{
    [Required(ErrorMessage = "Customer name is required")]
    public string Name { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Address { get; set; }
}
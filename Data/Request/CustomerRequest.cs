using System.ComponentModel.DataAnnotations;

namespace foodapi.Data.Request;

public class CustomerRequest
{
    [Required(ErrorMessage = "Customer name is required")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Phone number is required")]
    public string PhoneNumber { get; set; } = "";

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Format Email invalid")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; } = "";
}
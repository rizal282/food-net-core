using System.ComponentModel.DataAnnotations;

namespace foodapi.Data.Request;

public class CustomerRequest
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Address { get; set; }
}
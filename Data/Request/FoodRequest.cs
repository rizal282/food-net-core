using System.ComponentModel.DataAnnotations;

namespace foodapi.Data.Request;

public class FoodRequest
{
    [Required]
    public string Name { get; set; }

    [Required]
    public int Price { get; set; }

    [Required]
    public string CategoryName { get; set; }
}
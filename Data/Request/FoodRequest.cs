using System.ComponentModel.DataAnnotations;

namespace foodapi.Data.Request;

public class FoodRequest
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Price is required")]
    public int Price { get; set; } = 0;

    [Required(ErrorMessage = "Category name is required")]
    public string CategoryName { get; set; } = "";
}
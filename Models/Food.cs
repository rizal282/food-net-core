using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using foodapi.Constans;

namespace foodapi.Models;

[Table(ConstansTable.FOODS_TABLE_NAME)]
public class Food
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(ConstansTable.ID)]
    public int Id { get; set; }

    [Column(ConstansTable.FOOD_NAME)]
    public string? Name { get; set; }

    [Column(ConstansTable.FOOD_PRICE)]
    public int Price { get; set; }

    [Column(ConstansTable.FOOD_CATEGORY_ID)]
    public int CategoryId { get; set; }

    public CategoryFood? CategoryFood { get; set; }

    public List<Order>? Orders { get; set; }
}
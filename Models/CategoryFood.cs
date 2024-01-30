using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using foodapi.Constans;

namespace foodapi.Models;

[Table(ConstansTable.CATEGORY_FOODS_TABLE_NAME)]
public class CategoryFood
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(ConstansTable.ID)]
    public int Id { get; set; }

    [Column(ConstansTable.CATEGORY_FOOD_NAME)]
    public string? Name { get; set; }

    [Column(ConstansTable.CATEGORY_FOOD_DESCRIPTION)]
    public string? Description { get; set; }
    public List<Food>? Foods { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foodapi.Models;

[Table("foods")]
public class Food
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("price")]
    public int Price { get; set; }

    [Column("category_name")]
    public string CategoryName { get; set; }
}
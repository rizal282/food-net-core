using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foodapi.Models;

[Table("foods")]
public class Food
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string CategoryName { get; set; }
}
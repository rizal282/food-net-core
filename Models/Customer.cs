using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace foodapi.Models;

[Table("customers")]
public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50)]
    public string Name { get; set; }

    [Column("phone_number")]
    [MaxLength(20)]
    public string PhoneNumber { get; set; }

    [Column("email")]
    [MaxLength(100)]
    public string Email { get; set; }

    [Column("address")]
    [MaxLength(300)]
    public string Address { get; set; }
}
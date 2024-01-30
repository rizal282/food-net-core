using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using foodapi.Constans;

namespace foodapi.Models;

[Table(ConstansTable.CUSTOMERS_TABLE_NAME)]
public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(ConstansTable.ID)]
    public int Id { get; set; }

    [Column(ConstansTable.CUSTOMER_NAME)]
    [MaxLength(50)]
    public string? Name { get; set; }

    [Column(ConstansTable.CUSTOMER_PHONE_NUMBER)]
    [MaxLength(20)]
    public string? PhoneNumber { get; set; }

    [Column(ConstansTable.CUSTOMER_EMAIL)]
    [MaxLength(100)]
    public string? Email { get; set; }

    [Column(ConstansTable.CUSTOMER_ADDRESS)]
    [MaxLength(300)]
    public string? Address { get; set; }

    public List<Order>? Orders { get; set; }
}
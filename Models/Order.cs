using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using foodapi.Constans;

namespace foodapi.Models;

[Table(ConstansTable.ORDERS_TABLE_NAME)]
public class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column(ConstansTable.ID)]
    public int Id { get; set; }

    [Column(ConstansTable.ORDER_CUSTOMER_ID)]
    public int CustomerId { get; set; }

    [Column(ConstansTable.ORDER_FOOD_ID)]
    public int FoodId { get; set; }

    [Column(ConstansTable.ORDER_TOTAL_ITEM)]
    public int TotalItem { get; set; }

    [Column(ConstansTable.ORDER_SUB_TOTAL)]
    public int SubTotal { get; set; }

    [Column(ConstansTable.ORDER_DATE_ORDER)]
    public DateTime DateOrder { get; set; }

    public Food? Food { get; set; }
    public Customer? Customer { get; set; }
}
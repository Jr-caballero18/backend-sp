using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client;

namespace backend.Models;

public class Sale
{

[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

public int SaleId {get; set;}

public int Quantity {get; set;}

 [Column(TypeName = "decimal(18,2)")]
public decimal UnitPrice {get; set;}

public DateTime SaleDate {get; set;}

 [Column(TypeName = "varchar(50)")]
public string ClientName {get; set;}

[ForeignKey("InventoryId")]

public virtual Inventory Inventory  { get; set; } = null!;

}

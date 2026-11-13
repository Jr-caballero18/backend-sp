using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models;

public class Supplier
{

public int SupplierId {get; set;}

 [Column(TypeName = "varchar(50)")]
 public string name {get; set;}

 [Column(TypeName = "varchar(50)")]
public string country {get; set;}

 [Column(TypeName = "decimal(7,15)")]
public int phone {get; set;}



}

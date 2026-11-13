using System;

namespace backend.DTOs;

public class SupplierUpdateDto
{
public int SupplierId { get; set; }

    public string name { get; set; }

    public string country { get; set; }
    
    public int phone { get; set; }
}

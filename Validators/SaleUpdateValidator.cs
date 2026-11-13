using System;
using backend.DTOs;
using FluentValidation;

namespace backend.Validators;

public class SaleUpdateValidator : AbstractValidator<SaleUpdateDto>
{
    

public SaleUpdateValidator()
    {
        RuleFor(x => x.SaleId).NotEmpty().WithMessage("El id de la venta es obligatorio");
        RuleFor(x => x.Quantity).LessThan(0).WithMessage("La cantidad no debe ser menor a 0").NotEmpty().WithMessage("La cantidad es obligatoria");
        RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("El precio es obligatorio");
        RuleFor(x => x.SaleDate).NotEmpty().WithMessage("La fecha es obligatoria");
        RuleFor(x => x.ClientName).NotEmpty().WithMessage("El nombre del cliente es obligatorio");
        RuleFor(x => x.InventoryId).NotEmpty().WithMessage("El id del lote de inventario a vender es obligatorio");

    }


}

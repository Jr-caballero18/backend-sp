using System;
using backend.DTOs;
using backend.Models;
using FluentValidation;

namespace backend.Validators;

public class SupplierInsertValidator : AbstractValidator<SupplierInsertDto>
{

public SupplierInsertValidator()
    {
        RuleFor(x => x.SupplierId).NotEmpty().WithMessage("El id del proveedor es obligatorio");
        RuleFor(x => x.name).NotEmpty().WithMessage("El nombre es obligatorio");
        RuleFor(x => x.country).NotEmpty().WithMessage("El pais es obligatorio");
        RuleFor(x => x.phone).NotEmpty().WithMessage("El telefono es obligatorio");
    }

}

using System;
using backend.DTOs;
using backend.Models;

namespace backend.services;

public class SupplierService : ICommonServices<SupplierDto, SupplierInsertDto, SupplierUpdateDto>
{
    public Task<SupplierDto> Add(SupplierInsertDto insertDto)
    {
        throw new NotImplementedException();
    }

    public Task<SupplierDto> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SupplierDto>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<SupplierDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SupplierDto> Update(int id, SupplierUpdateDto updateDto)
    {
        throw new NotImplementedException();
    }
}

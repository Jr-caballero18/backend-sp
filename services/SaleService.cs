using System;
using backend.DTOs;

namespace backend.services;

public class SaleService : ICommonServices<SaleDto, SaleInsertDto, SaleUpdateDto>
{
    public Task<SaleDto> Add(SaleInsertDto insertDto)
    {
        throw new NotImplementedException();
    }

    public Task<SaleDto> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SaleDto>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<SaleDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<SaleDto> Update(int id, SaleUpdateDto updateDto)
    {
        throw new NotImplementedException();
    }


}

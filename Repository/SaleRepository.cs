using System;
using backend.Models;

namespace backend.Repository;

public class SaleRepository : IRepository<Sale>
{
    public Task Add(Sale entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Sale entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Sale>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<Sale> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public void Update(Sale entity)
    {
        throw new NotImplementedException();
    }
}

using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository;

public class SupplierRepository : IRepository<Supplier>
{
    public Task Add(Supplier entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Supplier entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Supplier>> Get()
    {
        throw new NotImplementedException();
    }

    public Task<Supplier> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task Save()
    {
        throw new NotImplementedException();
    }

    public void Update(Supplier entity)
    {
        throw new NotImplementedException();
    }

    
}

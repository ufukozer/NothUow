using NorthUow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthUow.Interface
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}

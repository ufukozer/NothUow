using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthUow.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; set; }
        int Complete();
    }
}

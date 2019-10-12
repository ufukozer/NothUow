using NorthUow.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthUow.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public ICategoryRepository CategoryRepository { get; set; }


        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            CategoryRepository = new CategoryRepository(dataContext);
        }
        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}

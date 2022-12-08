using RepositoryDesignPatternProjectWeb.Data.Context;
using RepositoryDesignPatternProjectWeb.Data.Interfaces;
using RepositoryDesignPatternProjectWeb.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDesignPatternProjectWeb.Data.UnitOfWork
{
    public class Uow:IUow
    {
        private readonly BankContext _context;

        public Uow(BankContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T:class,new()
        {
            return new Repository<T>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

using RepositoryDesignPatternProjectWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDesignPatternProjectWeb.Data.Interfaces
{
    public interface IAccountRepository
    {
        public void Create(Account account);
    }
}

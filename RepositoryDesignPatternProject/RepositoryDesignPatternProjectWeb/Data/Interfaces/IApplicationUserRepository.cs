using RepositoryDesignPatternProjectWeb.Data.Entities;
using System.Collections.Generic;

namespace RepositoryDesignPatternProjectWeb.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
    }
}

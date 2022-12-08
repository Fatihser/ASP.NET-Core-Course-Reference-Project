using RepositoryDesignPatternProjectWeb.Data.Entities;
using RepositoryDesignPatternProjectWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryDesignPatternProjectWeb.Mapping
{
    public interface IUserMapper
    {
        public List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        public UserListModel MapToUserList(ApplicationUser user);
    }
}

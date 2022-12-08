﻿using RepositoryDesignPatternProjectWeb.Data.Entities;
using System.Collections.Generic;
using RepositoryDesignPatternProjectWeb.Models;
using System.Linq;

namespace RepositoryDesignPatternProjectWeb.Mapping
{
    public class UserMapper:IUserMapper
    {
        public List<UserListModel> MapToListOfUserList(List<ApplicationUser> users)
        {
            return users.Select(x => new UserListModel
            {
                Id = x.Id,
                Name = x.Name,
                Surname=x.Surname
            }).ToList() ;
        }

        public UserListModel MapToUserList(ApplicationUser user)
        {
            return new UserListModel
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname
            };
        }
    }
}

using RepositoryDesignPatternProjectWeb.Data.Entities;
using RepositoryDesignPatternProjectWeb.Models;

namespace RepositoryDesignPatternProjectWeb.Mapping
{
    public class AccountMapper : IAccountMapper
    {
        public Account Map(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance
            };
        }
    }
}

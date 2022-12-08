using Microsoft.AspNetCore.Mvc;
using RepositoryDesignPatternProjectWeb.Data.Entities;
using RepositoryDesignPatternProjectWeb.Data.Interfaces;
using RepositoryDesignPatternProjectWeb.Data.UnitOfWork;
using RepositoryDesignPatternProjectWeb.Mapping;

namespace RepositoryDesignPatternProjectWeb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        private readonly IUow _uow;

        public HomeController(/*IApplicationUserRepository applicationUserRepository,*/ IUserMapper userMapper, IUow uow)
        {
            //_applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
            _uow = uow;
        }
        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GetAll()));
        }
    }
}

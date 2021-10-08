using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movies.Data.Repository.IRepository;
using Movies.Models;

namespace Movies.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private static UserManager<ApplicationUser> _userManager;
        public UserController(IUnitofWork unitofWork, UserManager<ApplicationUser> userManager)
        {
            _unitofWork = unitofWork;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            return View(_unitofWork.User.GetAll(u => u.Id != claims.Value));
        }
        
        
    }
}

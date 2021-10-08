using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movies.Data.Repository.IRepository;
using Movies.Models;
using Movies.Models.ViewModels;

namespace Movies.Controllers
{
    public class OrderController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private static UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        // private readonly IWebHostEnvironment _hostingEnv;
        public OrderController(IUnitofWork unitofWork, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _unitofWork = unitofWork;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            var orders = new OrderListVM
            {
                //Username=microname.User.Email,
                //Product = product,
                Orders = _unitofWork.Order.GetAll(includeProperties: "Movie,User")
            };
            return View(orders);
           // return View();
        }
        public IActionResult UserOrder()
        {
            var userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;
            var orders = new OrderListVM
            {
                //Username=microname.User.Email,
                //Product = product,
                Orders = _unitofWork.Order.GetAll(u=>u.User==user, includeProperties: "Movie,User")
            };
            return View(orders);
            // return View();
        }
        public IActionResult Create(int id)
        {
            if (!_signInManager.IsSignedIn(User)) //verify if it's logged
            {
                return LocalRedirect("~/Identity/Account/Login");
            }
            var movie = _unitofWork.Movie.GetFirstOrDefault(u=>u.Id==id,includeProperties:"Genre");
            var order = new OrderVM
            {
                Movie = movie,
                Tax = "5%",
                Order= new Models.Order
                {
                    MovieId=movie.Id,
                    Amount=movie.Price+ movie.Price*.05,
                }
            };
            return View(order);
        }
        [HttpPost]
        public IActionResult Create(OrderVM OrderVM)
        {
            var userId = _userManager.GetUserId(User);
            var user = _userManager.FindByIdAsync(userId).Result;
            OrderVM.Order.User = user;
            OrderVM.Order.Created = DateTime.Now;
                    // ApprovalVM.Approval.PostDate = DateTime.Now
                    _unitofWork.Order.Add(OrderVM.Order);
                    //}
                    //else
                    //    ModelState.AddModelError("", "This genre has been added already!!");
                
                _unitofWork.Save();
                return RedirectToAction(nameof(UserOrder));
            
            
        }
    }
}

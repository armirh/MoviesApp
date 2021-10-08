using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Movies.Data.Repository.IRepository;
using Movies.Models;
using Movies.Models.ViewModels;

namespace Movies.Controllers
{
    public class GenreController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IWebHostEnvironment _hostingEnv;
        public GenreController(IUnitofWork unitofWork, IWebHostEnvironment hostingEnv)
        {
            _unitofWork = unitofWork;
            _hostingEnv = hostingEnv;
        }
        public IActionResult Index()
        {
            var genres = new GenreListVM
            {
                //Username=microname.User.Email,
                //Product = product,
                Genres = _unitofWork.Genre.GetAll(includeProperties: "Movies")
            };
            return View(genres);
           // return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult GenreList()
        {
            var genres = new GenreListVM
            {
                //Username=microname.User.Email,
                //Product = product,
                Genres = _unitofWork.Genre.GetAll(includeProperties: "Movies")
            };
            return View(genres);
            // return View();
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Upsert(int? id)
        {
            Genre gen = new Genre();
            GenreVM genre = new GenreVM
            {
                Genre=gen
            };
            if (id == null)
            {
                return View(genre);
            }
            if(id!=null)
            genre.Genre = _unitofWork.Genre.Get(id.GetValueOrDefault());
            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);

        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(GenreVM genreVM)
        {
            var exist = _unitofWork.Genre.GetFirstOrDefault(x => x.Title == genreVM.Genre.Title.Trim());
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (genreVM.Genre.Id == 0)
                {
                    if (exist == null)
                    {
                        genreVM.Genre.Title = genreVM.Genre.Title.Trim();
                        string uploadsFolder = Path.Combine(_hostingEnv.WebRootPath, "images");
                        // To make sure the file name is unique we are appending a new
                        // GUID value and and an underscore to the file name
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + genreVM.File.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        // Use CopyTo() method provided by IFormFile interface to
                        // copy the file to wwwroot/images folder
                        genreVM.File.CopyTo(new FileStream(filePath, FileMode.Create));
                        genreVM.Genre.ImagePath =  uniqueFileName;
                        // ApprovalVM.Approval.PostDate = DateTime.Now;
                        _unitofWork.Genre.Add(genreVM.Genre);
                    }
                    else
                        ModelState.AddModelError("", "This genre has been added already!!");
                }
                else
                {
                    _unitofWork.Genre.Update(genreVM.Genre);
                }
                _unitofWork.Save();
                return RedirectToAction(nameof(GenreList));
            }
            
                return View(genreVM);
        }
    }
}

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
    public class MovieController : Controller
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IWebHostEnvironment _hostingEnv;
        public MovieController(IUnitofWork unitofWork, IWebHostEnvironment hostingEnv)
        {
            _unitofWork = unitofWork;
            _hostingEnv = hostingEnv;
        }
        public IActionResult Index(int id)
        {
            var genre = _unitofWork.Genre.Get(id);
            var movies = _unitofWork.Movie.GetAll(u => u.GenreId == id, includeProperties: "Genre");
            //if(movies!=null)
            //{
                MoviesListVM moviesList = new MoviesListVM
                {
                    Genre = genre,
                    Movies = movies
                };
           // }
            return View(moviesList);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult MovieList()
        {
           // var genre = _unitofWork.Genre.Get(id);
            var movies = _unitofWork.Movie.GetAll( includeProperties: "Genre");
            //if(movies!=null)
            //{
            MoviesListVM moviesList = new MoviesListVM
            {
              //  Genre = genre,
                Movies = movies
            };
            // }
            return View(moviesList);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Upsert(int? id)
        {
           // Movie movie = new Movie();
            NewMovieVM model = new NewMovieVM
            {
                Movie = new Movie(),
                GetGenres = _unitofWork.Genre.GetDropDown()
            };
            if (id != null)
            {
                model.Movie = _unitofWork.Movie.Get(id.GetValueOrDefault());
            }
            //primaryPackaging = _unitofWork.PrimaryPackaging.Get(id.GetValueOrDefault());
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(NewMovieVM NewMovieVM)
        {
           // var exist = _unitofWork.Genre.GetFirstOrDefault(x => x.Title == genreVM.Genre.Title.Trim());
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (NewMovieVM.Movie.Id == 0)
                {
                   /// if (exist == null)
                  //  {
                        NewMovieVM.Movie.Title = NewMovieVM.Movie.Title.Trim();
                        string uploadsFolder = Path.Combine(_hostingEnv.WebRootPath, "images");
                        // To make sure the file name is unique we are appending a new
                        // GUID value and and an underscore to the file name
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + NewMovieVM.File.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        // Use CopyTo() method provided by IFormFile interface to
                        // copy the file to wwwroot/images folder
                        NewMovieVM.File.CopyTo(new FileStream(filePath, FileMode.Create));
                        NewMovieVM.Movie.ImagePath = uniqueFileName;
                    NewMovieVM.Movie.Created = DateTime.Now;
                        // ApprovalVM.Approval.PostDate = DateTime.Now;
                        _unitofWork.Movie.Add(NewMovieVM.Movie);
                    //}
                    //else
                    //    ModelState.AddModelError("", "This genre has been added already!!");
                }
                else
                {
                    _unitofWork.Movie.Update(NewMovieVM.Movie);
                }
                _unitofWork.Save();
                return RedirectToAction("MovieList", "Movie", new {  });
               // return RedirectToAction(nameof(Index));
            }
            NewMovieVM.GetGenres = _unitofWork.Genre.GetDropDown();
            return View(NewMovieVM);
        }
        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitofWork.Movie.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }

            _unitofWork.Movie.Remove(objFromDb);
            _unitofWork.Save();
            return Json(new { success = true, message = "Delete successful." });

        }
    }
}

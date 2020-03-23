using System.Linq;
using demo_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_mvc.Controllers
{
  public class MovieController : Controller
  {
    // public IActionResult Index(int? id, string lastClick)
    // {
    //   var repo = new MovieRepository();
    //   var data = repo.GetMovies();
    //   if (id != null)
    //   {
    //     data = data.Where(m => m.Id == id).ToList();
    //   }
    //   ViewData["lastClick"] = lastClick;
    //   return View(data);
    // }

    [HttpPost]
    public IActionResult Index(SortInputModel model, [FromForm] string specialData)
    {
      var repo = new MovieRepository();
      var data = repo.GetMovies();
      if (!string.IsNullOrEmpty(model.sort))
      {
        switch (model.sort)
        {
          case "id":
            if (model.order == "asc")
            {
              data = data.OrderBy(m => m.Id).ToList();
            }
            else
            {
              data = data.OrderByDescending(m => m.Id).ToList();
            }
            break;
          case "title":
            if (model.order == "asc")
            {
              data = data.OrderBy(m => m.Title).ToList();
            }
            else
            {
              data = data.OrderByDescending(m => m.Title).ToList();
            }
            break;
          case "releaseDate":
            if (model.order == "asc")
            {
              data = data.OrderBy(m => m.ReleaseDate).ToList();
            }
            else
            {
              data = data.OrderByDescending(m => m.ReleaseDate).ToList();
            }
            break;
          case "genre":
            if (model.order == "asc")
            {
              data = data.OrderBy(m => m.Genre).ToList();
            }
            else
            {
              data = data.OrderByDescending(m => m.Genre).ToList();
            }
            break;
          case "price":
            if (model.order == "asc")
            {
              data = data.OrderBy(m => m.Price).ToList();
            }
            else
            {
              data = data.OrderByDescending(m => m.Price).ToList();
            }
            break;
          default:
            break;
        }
      }
      return View(data);
    }

    public IActionResult Index()
    {
      var repo = new MovieRepository();
      var data = repo.GetMovies();
      return View(data);
    }


    [HttpPost]
    public IActionResult DeleteMovie(int movieId)
    {
      var repo = new MovieRepository();
      repo.DeleteMovie(movieId);
      return RedirectToAction("Index");
    }
  }
}
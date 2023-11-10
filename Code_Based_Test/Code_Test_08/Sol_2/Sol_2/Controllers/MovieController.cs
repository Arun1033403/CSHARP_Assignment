using System.Linq;
using System.Web.Mvc;
using Sol_2.Models;
using System.Data.Entity;

namespace YourNamespace.Controllers
{
    public class MovieController : Controller
    {
        private MoviesDB dbContext = new MoviesDB();

        public ActionResult Index()
        {
            var movies = dbContext.Movie.ToList();
            return View(movies);
        }

        // Create a new movie
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                dbContext.Movie.Add(movie);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // Edit an existing movie
        public ActionResult Edit(int id)
        {
            var movie = dbContext.Movie.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movies movie)
        {
            if (ModelState.IsValid)
            {
                dbContext.Entry(movie).State = EntityState.Modified;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        // Delete a movie
        public ActionResult Delete(int id)
        {
            var movie = dbContext.Movie.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var movie = dbContext.Movie.Find(id);
            if (movie != null)
            {
                dbContext.Movie.Remove(movie);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}

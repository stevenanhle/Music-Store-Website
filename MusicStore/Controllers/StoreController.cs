using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();// create an instance of MusicStoreEntities class

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            return View(genres);
        }
        public ActionResult Browse(string genre)
        {
            //When user click on specific Genre, genreModel will fetch all Albums which has genre property is equal genre
            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name ==genre);
            return View(genreModel);
        }
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            return View(album);
        }
    }
}

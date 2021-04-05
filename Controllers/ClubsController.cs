using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClubsController : Controller
    {

        public IActionResult Index()
        {
            /*List<ClubsModel> clubs = new List<ClubsModel>();
            clubs.Add(new ClubsModel("Cooking Club", "M", "https://www.youtube.com", new TimeSpan(3, 15, 0), new TimeSpan(3, 57, 0),
                        "Mr. Weng", "weng@bxscience.edu", "David Davidson", "davidson@bxscience.edu", "Make food", 69));

            clubs.Add(new ClubsModel("Book Club", "T", "https://www.google.com", new TimeSpan(4, 15, 0), new TimeSpan(4, 57, 0),
                        "Mr. G", "G@bxscience.edu", "Eric Davidson", "davidson2@bxscience.edu", "Make book", 68)); 
            */

            List<ClubsModel> clubs = new List<ClubsModel>();

            ClubsDAO clubsDAO = new ClubsDAO();

            clubs = clubsDAO.FetchAll();

            return View("Index", clubs);
        }

        public ActionResult Details(int Id)
        {

            ClubsDAO clubsDAO = new ClubsDAO();

            ClubsModel clubs = clubsDAO.FetchOne(Id);

            return View("Details", clubs);
        }

        public ActionResult Create()
        {
            return View("ClubForm");
        }

        [HttpPost]
        public ActionResult ProcessCreate(ClubsModel newClub)
        {

            ClubsDAO clubsDAO = new ClubsDAO();

            clubsDAO.CreateOrUpdate(newClub);

            return View("Details", newClub);
            
        }

        public ActionResult Edit(int Id)
        {
            ClubsDAO clubsDAO = new ClubsDAO();

            ClubsModel clubs = clubsDAO.FetchOne(Id);
            
            return View("ClubForm", clubs);
        }

        public ActionResult Delete(int Id)
        {
            ClubsDAO clubsDAO = new ClubsDAO();

            clubsDAO.Delete(Id);

            List<ClubsModel> clubs = clubsDAO.FetchAll();

            return View("Index", clubs);
        }

        public ActionResult SearchForm()
        {
            return View("SearchForm");
        }

        public ActionResult SearchForName(string searchPhrase)
        {
            ClubsDAO clubsDAO = new ClubsDAO();

            List<ClubsModel> searchResults = clubsDAO.SearchForName(searchPhrase);

            return View("Index", searchResults);
        }

        public ActionResult SearchForDescription(string searchPhrase)
        {
            ClubsDAO clubsDAO = new ClubsDAO();

            List<ClubsModel> searchResults = clubsDAO.SearchForDescription(searchPhrase);

            return View("Index", searchResults);
        }
    }
}

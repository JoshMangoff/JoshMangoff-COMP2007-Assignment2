using JoshMangoff_COMP2007_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoshMangoff_COMP2007_Assignment2.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "List of food types goes here";
        }

        //GET: Store/Browse?type=Dessert
        public string Browse(string type = "Dessert")
        {
            string message = HttpUtility.HtmlEncode("List of food of " + type +" goes here");
            return message;
        }

        // GET: Store/Details/2
        public ActionResult Details(int id = 1)
        {
            Food food = new Food(id);
            return View(food);
        }
    }
}
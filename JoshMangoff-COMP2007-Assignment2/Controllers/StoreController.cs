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
        FoodStoreContext storeDB = new FoodStoreContext();

        // GET: Store
        public ActionResult Index()
        {
            List<FoodType> foodtypes = storeDB.FoodTypes.ToList();
            return View(foodtypes);
        }

        //GET: Store/Browse?type=Dessert
        public ActionResult Browse(string foodType = "Dessert")
        {
            FoodType foodTypeModel = storeDB.FoodTypes.Include("FoodType").Single(f => f.Name == foodType);
            return View(foodTypeModel);
        }

        // GET: Store/Details/2
        public ActionResult Details(int id = 1)
        {
            Food food = storeDB.Foods.Find(id);
            return View(food);
        }
    }
}
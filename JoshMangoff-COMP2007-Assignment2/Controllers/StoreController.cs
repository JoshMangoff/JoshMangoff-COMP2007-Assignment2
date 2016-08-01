/*
 * Controllers/StoreController.cs
 * Josh Mangoff
 * Pizza Place
 * Controller for the feature pages of the foods
 */
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
        /// <summary>
        /// gets foodtypes from database, and puts them in a list
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<FoodType> foodtypes = storeDB.FoodTypes.ToList();
            return View(foodtypes);
        }

        //GET: Store/Browse?type=Dessert
        /// <summary>
        /// gets foods of the selected type from the database
        /// </summary>
        /// <param name="foodType"></param>
        /// <returns></returns>
        public ActionResult Browse(string foodType = "Desserts")
        {
            FoodType foodTypeModel = storeDB.FoodTypes.Include("Foods").Single(f => f.Name == foodType);
            return View(foodTypeModel);
        }

        // GET: Store/Details/2
        /// <summary>
        /// finds the selected food from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id = 1)
        {
            Food food = storeDB.Foods.Find(id);
            return View(food);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoshMangoff_COMP2007_Assignment2.Models
{
    public class Food
    {

        public Food()
        {

        }
        
        public Food(string Title)
        {
            this.Title = Title;
        }

        public string Title { get; set; }
        public FoodType Type { get; set;  }
        public string Description { get; set; }
        public int Price { get; set; }
        public string SmallImgUrl { get; set; }
        public string BigImgUrl { get; set; }
    }
}
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
        
        public Food(string Title, string Description, int Price, string SmallImgUrl, string BigImgUrl)
        {
            this.Title = Title;
            this.Description = Description;
            this.Price = Price;
            this.SmallImgUrl = SmallImgUrl;
            this.BigImgUrl = BigImgUrl;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string SmallImgUrl { get; set; }
        public string BigImgUrl { get; set; }
    }
}
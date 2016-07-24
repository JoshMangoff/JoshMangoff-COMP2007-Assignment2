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

        public virtual int FoodId { get; set; }
        public virtual string Title { get; set; }
        public virtual int FoodTypeId { get; set; }
        public virtual FoodType Type { get; set;  }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string SmallImgUrl { get; set; }
        public virtual string BigImgUrl { get; set; }
    }
}
/*
 * Models/Food.cs
 * Josh Mangoff
 * Pizza Place
 * Model of the food class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoshMangoff_COMP2007_Assignment2.Models
{
    public class Food
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public Food()
        {

        }

        /// <summary>
        /// Normal constructor that accepts title
        /// </summary>
        /// <param name="Title"></param>
        public Food(string Title)
        {
            this.Title = Title;
        }

        //variables in the object
        public virtual int FoodId { get; set; }
        public virtual string Title { get; set; }
        public virtual int FoodTypeId { get; set; }
        public virtual FoodType Type { get; set;  }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string ImgUrl { get; set; }
    }
}
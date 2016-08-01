/*
 * Models/FoodType.cs
 * Josh Mangoff
 * Pizza Place
 * Model of the foodtype class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoshMangoff_COMP2007_Assignment2.Models
{
    public class FoodType
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public FoodType()
        {

        }

        /// <summary>
        /// Normal constructor that accepts name
        /// </summary>
        /// <param name="Name"></param>
        public FoodType(string Name)
        {
            this.Name = Name;
        }

        //variables in the object
        public virtual int FoodTypeId { get; set; }
        public virtual string Name { get; set; }
        public virtual List<Food> Foods { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JoshMangoff_COMP2007_Assignment2.Models
{
    public class FoodType
    {
        public FoodType()
        {

        }

        public FoodType(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }
}
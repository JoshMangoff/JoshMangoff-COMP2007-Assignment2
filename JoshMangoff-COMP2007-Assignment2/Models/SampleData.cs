using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JoshMangoff_COMP2007_Assignment2.Models
{ 
     public class SampleData : DropCreateDatabaseAlways<FoodStoreContext>
     { 
         /// <summary>
         /// This method creates the data in the database
         /// </summary>
         /// <param name="context"></param>
         protected override void Seed(FoodStoreContext context)
         { 
             var foodtypes = new List<FoodType>
             { 
                 new FoodType { Name = "Appetizers" }, 
                 new FoodType { Name = "Main Courses" },
                 new FoodType { Name = "Desserts" },
                 new FoodType { Name = "Beverages" },
             }; 
 
             new List<Food> 
             { 
                 //all images are from google images
                 new Food { Title = "Onion Rings", Description = "These crispy onion rings make for a great appetizer or side to your meal!", Type = foodtypes.Single(t => t.Name == "Appetizers"), Price = 4.99M, ImgUrl = "~/Assets/images/items/onionrings.jpg" },
                 new Food { Title = "Garlic Bread with Cheese, 3 pieces", Description = "Three pieces of garlic bread with cheddar cheese!", Type = foodtypes.Single(t => t.Name == "Appetizers"), Price = 5.99M, ImgUrl = "/Assets/images/items/garlicbread.jpg" },
                 new Food { Title = "Large Pizza, 3 toppings", Description = "Description of large pizza goes here", Type = foodtypes.Single(t => t.Name == "Main Courses"), Price = 21.99M, ImgUrl = "/Assets/images/items/placeholder.jpg" },
                 new Food { Title = "Medium Pepperoni Pizza", Description = "Description of medium pepperoni pizza goes here", Type = foodtypes.Single(t => t.Name == "Main Courses"), Price = 15.99M, ImgUrl = "/Assets/items/large/placeholder.jpg" },
                 new Food { Title = "Vanilla Ice Cream Cone", Description = "Description of ice cream cone goes here", Type = foodtypes.Single(t => t.Name == "Desserts"), Price = 6.99M, ImgUrl = "/Assets/images/items/placeholder.jpg" },
                 new Food { Title = "Chocolate Sundae", Description = "Description of chocolate sundae goes here", Type = foodtypes.Single(t => t.Name == "Desserts"), Price = 8.99M, ImgUrl = "/Assets/images/items/placeholder.jpg" },
                 new Food { Title = "Water, 500mL", Description = "Description of bottle of water goes here", Type = foodtypes.Single(t => t.Name == "Beverages"), Price = 1.99M, ImgUrl = "/Assets/images/items/placeholder.jpg" },
                 new Food { Title = "Pop, 350mL", Description = "Description of can of pop goes here", Type = foodtypes.Single(t => t.Name == "Beverages"), Price = 2.99M, ImgUrl = "/Assets/images/items/placeholder.jpg" },
            }.ForEach(a => context.Foods.Add(a)); 
        } 
    } 
} 

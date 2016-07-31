using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JoshMangoff_COMP2007_Assignment2.Models
{ 
     public class SampleData : DropCreateDatabaseIfModelChanges<FoodStoreContext> //DropCreateDatabaseAlways
     { 
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
                 new Food { Title = "Onion Rings", Description = "Description of onion rings goes here", Type = foodtypes.Single(t => t.Name == "Appetizers"), Price = 4.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
                 new Food { Title = "Garlic Bread, 3 pieces", Description = "Description of garlic bread goes here", Type = foodtypes.Single(t => t.Name == "Appetizers"), Price = 5.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
                 new Food { Title = "Large Pizza, 3 toppings", Description = "Description of large pizza goes here", Type = foodtypes.Single(t => t.Name == "Main Courses"), Price = 21.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
                 new Food { Title = "Medium Pepperoni Pizza", Description = "Description of medium pepperoni pizza goes here", Type = foodtypes.Single(t => t.Name == "Main Courses"), Price = 15.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
                 new Food { Title = "Vanilla Ice Cream Cone", Description = "Description of ice cream cone goes here", Type = foodtypes.Single(t => t.Name == "Desserts"), Price = 6.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
                 new Food { Title = "Chocolate Sundae", Description = "Description of chocolate sundae goes here", Type = foodtypes.Single(t => t.Name == "Desserts"), Price = 8.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
                 new Food { Title = "Water, 500mL", Description = "Description of bottle of water goes here", Type = foodtypes.Single(t => t.Name == "Beverages"), Price = 1.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
                 new Food { Title = "Pop, 350mL", Description = "Description of can of pop goes here", Type = foodtypes.Single(t => t.Name == "Beverages"), Price = 2.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" },
            }.ForEach(a => context.Foods.Add(a)); 
        } 
    } 
} 

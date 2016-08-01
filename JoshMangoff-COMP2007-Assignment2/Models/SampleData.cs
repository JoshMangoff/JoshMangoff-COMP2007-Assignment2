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
                 new Food { Title = "Onion Rings", Description = "These crispy onion rings make for a great appetizer or side to your meal!", Type = foodtypes.Single(t => t.Name == "Appetizers"), Price = 4.99M, ImgUrl = "/Assets/images/items/onionrings.jpg" },
                 new Food { Title = "Garlic Bread with Cheese, 3 pieces", Description = "Three pieces of garlic bread with cheddar cheese!", Type = foodtypes.Single(t => t.Name == "Appetizers"), Price = 5.99M, ImgUrl = "/Assets/images/items/garlicbread.jpg" },
                 new Food { Title = "Large Pizza, 3 toppings", Description = "Large pizza with 3 toppings of your choice! Coose from over 20 different toppings!", Type = foodtypes.Single(t => t.Name == "Main Courses"), Price = 21.99M, ImgUrl = "/Assets/images/items/lpizza.jpg" },
                 new Food { Title = "Medium Pepperoni Pizza", Description = "Our oven-baked pepperoni pizza is always made with the freshest ingredients!", Type = foodtypes.Single(t => t.Name == "Main Courses"), Price = 15.99M, ImgUrl = "/Assets/images/items/ppizza.png" },
                 new Food { Title = "Vanilla Ice Cream Cone", Description = "Vanilla ice cream is always a great way to cool off after a summer day - or as dessert after a pizza!", Type = foodtypes.Single(t => t.Name == "Desserts"), Price = 6.99M, ImgUrl = "/Assets/images/items/vicecream.jpg" },
                 new Food { Title = "Chocolate Sundae", Description = "A decadent chocolate sundae, rich in flavour!", Type = foodtypes.Single(t => t.Name == "Desserts"), Price = 8.99M, ImgUrl = "/Assets/images/items/csundae.png" },
                 new Food { Title = "Water, 500mL", Description = "Natural spring water!", Type = foodtypes.Single(t => t.Name == "Beverages"), Price = 1.99M, ImgUrl = "/Assets/images/items/water.png" },
                 new Food { Title = "Pop, 350mL", Description = "A can of pop/soda, over 8 choices!", Type = foodtypes.Single(t => t.Name == "Beverages"), Price = 2.99M, ImgUrl = "/Assets/images/items/pop.png" },
            }.ForEach(a => context.Foods.Add(a)); 
        } 
    } 
} 

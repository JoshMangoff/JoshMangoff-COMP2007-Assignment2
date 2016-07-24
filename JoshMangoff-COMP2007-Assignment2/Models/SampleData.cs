using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JoshMangoff_COMP2007_Assignment2.Models
{ 
     public class SampleData : DropCreateDatabaseIfModelChanges<FoodStoreContext> 
     { 
         protected override void Seed(FoodStoreContext context)
         { 
             var foodtypes = new List<FoodType>
             { 
                 new FoodType { Name = "Beverages" }, 
                 new FoodType { Name = "Desserts" }, 
                 new FoodType { Name = "Metal" }, 
                 new FoodType { Name = "Alternative" }, 
                 new FoodType { Name = "Disco" },  
             }; 
 
             new List<Food> 
             { 
                 new Food { Title = "Vanilla Ice Cream Cone", Description = "Description of ice cream cone goes here", Type = foodtypes.Single(t => t.Name == "Desserts"), Price = 8.99M, BigImgUrl = "/Assets/images/large/placeholder.gif", SmallImgUrl = "/Assets/images/small/placeholder.gif" }, 
                 new Album { Title = "Worlds", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aaron Goldberg"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "For Those About To Rock We Salute You", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Let There Be Rock", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Balls to the Wall", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Accept"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Restless and Wild", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Accept"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Górecki: Symphony No. 3", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Adrian Leaper & Doreen de Feis"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Big Ones", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aerosmith"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Quiet Songs", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Aisha Duo"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Jagged Little Pill", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Alanis Morissette"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Facelift", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Alice In Chains"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Frank", Genre = genres.Single(g => g.Name == "Pop"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Amy Winehouse"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Ring My Bell", Genre = genres.Single(g => g.Name == "Disco"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Anita Ward"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Chill: Brazil (Disc 2)", Genre = genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Warner 25 Anos", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Antônio Carlos Jobim"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Plays Metallica By Four Cellos", Genre = genres.Single(g => g.Name == "Metal"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Apocalyptica"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Revelations", Genre = genres.Single(g => g.Name == "Alternative"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Audioslave"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Audioslave", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Audioslave"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "The Last Night of the Proms", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Barry Wordsworth & BBC Concert Orchestra"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Sibelius: Finlandia", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Berliner Philharmoniker & Hans Rosbaud"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Mozart: Symphonies Nos. 40 & 41", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Berliner Philharmoniker & Herbert Von Karajan"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "The Best Of Billy Cobham", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Billy Cobham"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                 new Album { Title = "Bach: The Cello Suites", Genre = genres.Single(g => g.Name == "Classical"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Yo-Yo Ma"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
                new Album { Title = "Ao Vivo [IMPORT]", Genre = genres.Single(g => g.Name == "Latin"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Zeca Pagodinho"), AlbumArtUrl = "/Content/Images/placeholder.gif" }, 
            }.ForEach(a => context.Albums.Add(a)); 
        } 
    } 
} 

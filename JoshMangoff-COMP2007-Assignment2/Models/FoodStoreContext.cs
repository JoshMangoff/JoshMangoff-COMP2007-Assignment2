namespace JoshMangoff_COMP2007_Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FoodStoreContext : DbContext
    {
        public FoodStoreContext()
            : base("name=FoodStoreConnection")
        {
        }

        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodType> FoodTypes { get; set; }
    }
}

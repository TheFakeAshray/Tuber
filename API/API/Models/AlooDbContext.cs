namespace API.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using DataModels;

    public partial class AlooDbContext : DbContext
    {
        public AlooDbContext()
            : base("name=Aloo")
        {
        }
        public DbSet<Tuser> Tusers { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

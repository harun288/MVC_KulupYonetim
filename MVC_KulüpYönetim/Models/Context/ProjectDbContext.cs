using MVC_KulüpYönetim.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_KulüpYönetim.Models.Context
{
    public class ProjectDbContext:DbContext
    {
        public ProjectDbContext()
        {
            Database.Connection.ConnectionString = "server =DESKTOP-M3JLO0L; database = ClubManagementDB;Trusted_Connection=True;";
        }
       public DbSet<Fan> Fans { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<FanAndRole> FanAndRoles { get; set; }
        public DbSet<Departman> Departmans { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FanAndRole>().HasKey(x => new { x.FanId, x.RoleId });
        }
    }
}

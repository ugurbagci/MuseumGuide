using Microsoft.EntityFrameworkCore;
using MuseumGuide.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace MuseumGuide.Data.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-TJVLSIK;Database=MuseumDB;uid=burak;pwd=1123;");
        }

        public DbSet<Museum> Museums { get; set; } 
         
        public DbSet<User>  Users { get; set; } 
        public DbSet<Photo> Photos  { get; set; }
    }
}
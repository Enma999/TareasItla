using ComunityWeb.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComunityWeb.Infraestructure.Context
{
    public class TaskContext : DbContext
    {
        public TaskContext()
        {
            
        }
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ENMANUEL-BE38FA\\SQL2023;Initial Catalog=Comunity;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;Packet Size=4096;Command Timeout=0");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<CoordinatorModel> Coordinators { get; set; }
        public DbSet<ActivistModel> Activists { get; set; }
        public DbSet<ChairmanModel> Chairman { get; set; }

        }
}

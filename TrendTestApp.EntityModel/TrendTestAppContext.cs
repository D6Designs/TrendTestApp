using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TrendTestApp.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TrendTestAppContext
    {


        // Your context has been configured to use a 'TimeSheetContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Walberton.TimeSheets.EntityModel.TimeSheetContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TimeSheetContext' 
        // connection string in the application configuration file.
        public TrendTestAppContext()
            : base("name=DefaultConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Company> Company { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Task_TaskOption>()
                .HasRequired(t => t.Task)
                .WithMany(t => t.Task_TaskOptions)
                .HasForeignKey(t => t.TaskID);
            modelBuilder.Entity<Task_TaskOption>()
                .HasRequired(t => t.TaskOption)
                .WithMany(t => t.Task_TaskOptions)
                .HasForeignKey(t => t.TaskOptionID);

            //modelBuilder.Entity<ApplicationUser>()
            //    .HasOptional(s => s.Employee)
            //    .WithRequired(ad => ad.User);

        }
    }
}

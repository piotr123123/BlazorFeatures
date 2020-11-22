using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Employee> Employeesa { get; set; }
        public DbSet<Department> Departmentsa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Department>().HasData(
            //    new Department { DepartmentId = 1, DepartmentName = "it" });

            //modelBuilder.Entity<Employee>().hasdata(new Employee
            //{
            //    Id = 1,
            //    Name = "magdalena",
            //    Surname = "jaskulska",
            //    Gender = Gender.Female,
            //    DepartmentId = 1,
            //    photopath = "img1.jpg"
            //});
        }

    }
}

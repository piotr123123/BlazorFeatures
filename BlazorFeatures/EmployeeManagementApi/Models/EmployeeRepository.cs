using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementApi.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await appDbContext.Employeesa.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Employee> DeleteEmployee(int employeeId)
        {
            var result = await appDbContext.Employeesa
                .FirstOrDefaultAsync(e => e.Id == employeeId);
            if (result != null)
            {
                appDbContext.Employeesa.Remove(result);
                await appDbContext.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await appDbContext.Employeesa
                .Include(e => e.Department)
                .FirstOrDefaultAsync(e => e.Id == employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDbContext.Employeesa.ToListAsync();
        }

        //public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        //{
        //    IQueryable<Employee> query = appDbContext.Employees;

        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        query = query.Where(e => e.Name.Contains(name)
        //            || e.Surname.Contains(name));
        //    }

        //    if (gender != null) 
        //    {
        //        query = query.Where(e => e.Gender == gender);
        //    }

        //    return await query.ToListAsync();

        //}

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await appDbContext.Employeesa
               .FirstOrDefaultAsync(e => e.Id == employee.Id);
            if (result != null)
            {
                //result.Id = employee.Id;
                result.Name = employee.Name;
                result.Surname = employee.Surname;

                await appDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}

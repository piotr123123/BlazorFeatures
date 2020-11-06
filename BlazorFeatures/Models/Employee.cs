using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Employee
    {
        public Employee()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public string PhotoPath { get; set; }


        public Employee(int Id, string Name, string Surname, Gender Gender, int DepartmentId, string PhotoPath)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Gender = Gender;
            this.DepartmentId = DepartmentId;
            this.PhotoPath = PhotoPath;
        }

       
    }
}


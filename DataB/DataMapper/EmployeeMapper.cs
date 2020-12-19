using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.DataMapper
{
    public class EmployeeMapper
    {
        DatabaseContext db;

        public EmployeeMapper()
        {
            db = new DatabaseContext();
        }


        public Employee GetEmployeeById(int id)
        {
            return db.Employees.FirstOrDefault(e => e.Id == id);
        }


        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public void Insert(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void Edit(Employee employee)
        {
            var change = db.Employees.Find(employee.Id);
          
            change.FirstName = employee.FirstName;
            change.LastName = employee.LastName;
            change.Email = employee.Email;
        }

        public void Remove(int Id)
        {
            var toRemove = db.Employees.Find(Id);
            db.Employees.Remove(toRemove);
            db.SaveChanges();
        }
    }
}

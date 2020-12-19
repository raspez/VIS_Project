using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.DataMapper
{
    public class CustomerMapper
    {
        DatabaseContext db;

        public CustomerMapper()
        {
            db = new DatabaseContext();
        }

        public Customer GetCustomerById(int id)
        {
            return db.Customers.FirstOrDefault(c => c.Id == id);
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public void Insert(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
        }

        public void Edit(Customer customer)
        {
            var change = db.Customers.Find(customer.Id);

            change.FirstName = customer.FirstName;
            change.LastName = customer.LastName;
            change.Password = customer.Password;
        }

        public void Remove(int Id)
        {
            var toRemove = db.Customers.Find(Id);
            db.Customers.Remove(toRemove);
            db.SaveChanges();
        }
    }
}

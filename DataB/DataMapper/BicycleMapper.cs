using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.DataMapper
{
    public class BicycleMapper
    {
        DatabaseContext db;

        public BicycleMapper()
        {
            db = new DatabaseContext();
        }


        public Bicycle GetBicycleById(int id)
        {
            return db.Bicycles.FirstOrDefault(b => b.Id == id);
        }

        
        public List<Bicycle> GetAll()
        {
            return db.Bicycles.ToList();
        }

        public void Insert(Bicycle bicycle)
        {
            db.Bicycles.Add(bicycle);
            db.SaveChanges();
        }

        public void Edit(Bicycle bicycle)
        {
            var change = db.Bicycles.Find(bicycle.Id);

            change.Description = bicycle.Description;
            change.IdEmployee = bicycle.IdEmployee;
        }

        public void Remove(int Id)
        {
            var toRemove = db.Bicycles.Find(Id);
            db.Bicycles.Remove(toRemove);
            db.SaveChanges();
        }


    }
}

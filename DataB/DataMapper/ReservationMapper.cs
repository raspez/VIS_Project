using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.DataMapper
{
    public class ReservationMapper
    {
        DatabaseContext db;

        public ReservationMapper()
        {
            db = new DatabaseContext();
        }

        public Reservation GetReservationById(int id)
        {
            return db.Reservations.FirstOrDefault(res => res.Id == id);
        }
        //TODO predelat jen na dny
        public  List<Reservation> GetReservationByDate(DateTime date) 
        {
            var From = date.Date + new TimeSpan(0, 0, 0);
            var To = date.Date + new TimeSpan(23, 59, 59);
            return db.Reservations.Where(res => res.Date >= From && res.Date <= To).ToList();
        }
 
        public void Insert(Reservation reservation)
        {
            db.Reservations.Add(reservation);
            db.SaveChanges();
        }

        //TODO -dodelat reyervace?
        //public void Edit(Reservation reservation)
        //{
        //    var change = db.Bicycles.Find(bicycle.Id);

        //    change.Description = bicycle.Description;
        //    change.IdEmployee = bicycle.IdEmployee;
        //}



        public void Remove(int id)
        {
            var toRemove = db.Reservations.Find(id);
            db.Reservations.Remove(toRemove);
            db.SaveChanges();
        }


    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL.DataMapper
{
    public class PaymentMapper
    {
        DatabaseContext db;

        public PaymentMapper()
        {
            db = new DatabaseContext();
        }


        public Payment GetPazmentById(int id)
        {
            return db.Payments.FirstOrDefault(p => p.Id == id);
        }


        public List<Payment> GetAll()
        {
            return db.Payments.ToList();
        }

        public void Insert(Payment payment)
        {
            db.Payments.Add(payment);
            db.SaveChanges();
        }

        public void Edit(Payment payment)
        {
            var change = db.Payments.Find(payment.Id);

            change.Value = payment.Value;
            change.Payed = payment.Payed;
        }

        public void Remove(int Id)
        {
            var toRemove = db.Payments.Find(Id);
            db.Payments.Remove(toRemove);
            db.SaveChanges();
        }
    }
}

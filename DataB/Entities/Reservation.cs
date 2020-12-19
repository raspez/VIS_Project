using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int IdCustomer { get; set; }
        public Customer Customer { get; set; }
        public int IdBicycle { get; set; }
        public Bicycle Bicycle { get; set; }
        public int IdPayemnt { get; set; }
        public Payment Payments { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Customer
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }

        //TODO - ma zde Bicycle byt?
        public Bicycle Bicycle { get; set; }

        public List<Reservation> Reservations { get; set; }

    }
}

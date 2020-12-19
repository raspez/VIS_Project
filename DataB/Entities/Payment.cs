using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Payment
    {
        public int Id { get; set; }
        public float Value { get; set; }
        public float Payed { get; set; }
        public int IdReservation { get; set; }
        public List<Reservation> Reservation { get; set; }
    }
}

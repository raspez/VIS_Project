﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Employee
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public List<Bicycle> Bicycles { get; set; }
    }
}

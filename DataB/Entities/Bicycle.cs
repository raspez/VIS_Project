using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Bicycle
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }
    }
}

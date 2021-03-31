using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTest.Models
{
    public class TabWork
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int AppointId { get; set; }
        public Employee Employee { get; set; }
        public Appoint Appoint { get; set; }
        //public string TabNum { get; set; }
        public string Days { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTest.Models
{
    public class TabelWork
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int AppointId { get; set; }
        public int TabelId { get; set; }
        public Employee Employee { get; set; }
        public Appoint Appoint { get; set; }
        public Tabel Tabel { get; set; }
        //public string TabNum { get; set; }
        //public string AppName { get; set; }
        public string Day1 { get; set; }
        public string Day2 { get; set; }
        public string Day3 { get; set; }
        public string Day4 { get; set; }
        public string Day5 { get; set; }
        public string Day6 { get; set; }
        public string Day7 { get; set; }
        public string Day8 { get; set; }
        public string Day9 { get; set; }
        public string Day10 { get; set; }
        public string Day11 { get; set; }
        public string Day12 { get; set; }
        public string Day13 { get; set; }
        public string Day14 { get; set; }
        public string Day15 { get; set; }
        public string Day16 { get; set; }
        public string Day17 { get; set; }
        public string Day18 { get; set; }
        public string Day19 { get; set; }
        public string Day20 { get; set; }
        public string Day21 { get; set; }
        public string Day22 { get; set; }
        public string Day23 { get; set; }
        public string Day24 { get; set; }
        public string Day25 { get; set; }
        public string Day26 { get; set; }
        public string Day27 { get; set; }
        public string Day28 { get; set; }
        public string Day29 { get; set; }
        public string Day30 { get; set; }
        public string Day31 { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
namespace PersonalTest.Models

{
    public class Tabel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не установлено")]
        public string Number { get; set; }//Номер табеля
        [Required(ErrorMessage = "Поле не установлено")]
        public DateTime DateMaking { get; set; } //Дата составления
        public int Year { get; set; }//Год
        public string Month { get; set; }//Месяц
        public string StructName { get { if (Structure != null) return Structure.StructName; else return ""; } }//Структурное подразделение
       // public string AppointName { get { if (Appoint != null) return Appoint.AppName; else return ""; } } //Должность
        public int StructureId { get; set; }
        public Structure Structure { get; set; }
        //public int AppointId { get; set; }
        //public Appoint Appoint { get; set; }
        //public string TabVar { get; set; }
        public string NumDataMaking { get; set; }
    
    }
}


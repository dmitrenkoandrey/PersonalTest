using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PersonalTest.Models
{
    public class StaffingTable
    {

        public int Id { get; set; }
        //public   string StructName { get; set; }//Структурное подразделение
        public string StructName { get { if (Structure != null) return Structure.StructName; else return ""; } }//Структурное подразделение  


        //public string AppointName { get; set; } //Должность
        public string AppointName { get { if (Appoint != null) return Appoint.AppName; else return ""; } }//Структурн ое подразделение 
        [Required(ErrorMessage = "Поле не установлено")]
        public int Quantity { get; set; } //Количество
        [Required(ErrorMessage = "Поле не установлено")]
        public int Salary { get; set; }//Тарифный оклад
        public int StructureId { get; set; }
        public int AppointId { get; set; }
        public Structure Structure { get; set; }
        public Appoint Appoint { get; set; }
    }
}

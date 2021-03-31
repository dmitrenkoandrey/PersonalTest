using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalTest.Models
{
    public class Employee
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не установлено")]
        public string Tab { get; set; }
        [Required(ErrorMessage = "Поле не установлено")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Поле не установлено")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Поле не установлено")]
        public string Patronymic { get; set; }
        [Required(ErrorMessage = "Поле не установлено")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime EntryDate { get; set; }
        public string Fio { get; set; }
    }
}


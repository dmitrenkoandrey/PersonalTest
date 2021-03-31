using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalTest.Models;
namespace PersonalTest.Models
{
    public class Appoint
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string AppName { get; set; }

    }
}

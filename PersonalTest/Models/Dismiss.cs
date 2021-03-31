using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalTest.Models
{
    public class Dismiss
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PersonalTest.Models
{
    public class Education
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string Name { get; set; }
    }
}

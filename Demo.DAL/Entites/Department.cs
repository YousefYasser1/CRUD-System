using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entites
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(50, ErrorMessage = "Max Length is 50 ...")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code is Required")]
        [MaxLength(4 , ErrorMessage = "Max Length is 50 ...")]
        public string Code { get; set; }

        public DateTime CratetionTime { get; set; } = DateTime.Now;
    }
}

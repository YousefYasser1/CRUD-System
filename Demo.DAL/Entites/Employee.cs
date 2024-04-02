using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entites
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(70)]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        public string ImageName { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternSystemClassLibrary.Models
{
    public class Intern
    {

        public int Id { get; set; }
        [Required]
        public PersonalDetails PersonalDetails { get; set; }
        [Required]
        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public DateTime DateCreate { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime DateUpdate { get; set; } = DateTime.UtcNow;

    }
}

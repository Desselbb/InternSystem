using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternSystemClassLibrary.Models
{
    public class InternProject
    {
        public int Id { get; set; }
        [Key]
        [Required]
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        [Required]
        public int InternId { get; set; }
    }
}

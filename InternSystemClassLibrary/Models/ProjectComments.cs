using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternSystemClassLibrary.Enums;

namespace InternSystemClassLibrary.Models
{
    public class ProjectComments
    {
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        [Required]
        public DateTime CommentDate { get; set; } = DateTime.Now;
        [Required]
        public string Message { get; set; }
        public Log Log { get; set; }
        [Required]
        [ForeignKey(nameof(PersonalDetails))]
        public int UserId { get; set; }
    }
}

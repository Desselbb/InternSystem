using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InternSystemClassLibrary.Enums;

namespace InternSystemClassLibrary.Models
{
    public class PersonalDetails
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Password { get; set; }
        [Key]
        [Required]
        public string? Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public string? Contact { get; set; }
        [Required]
        public string? Address { get; set; }

        [Required]
        public byte[] Image { get; set; }
    }
}

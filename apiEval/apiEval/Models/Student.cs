using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;



namespace apiEval.Models
{
    public enum TypeGender
    {
        Male,
        Female,
    }

    public class Student
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public TypeGender Gender { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        public virtual ICollection<Notes> Notas { get; set; }
    }
}
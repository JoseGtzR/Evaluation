using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace apiEval.Models
{
    public enum TypeStatus
    {
        Approved,
        Failed,
    }
    public class Grades
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public TypeStatus Status { get; set; }
        [Required]
        public int Notes { get; set; }
     

       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCFirstDemo.Models
{
    public class Customer
    {
        [Required]
        public string SName { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
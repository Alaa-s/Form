using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace form.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        
        public string Country { get; set; }
        public string City { get; set; }
    }
}

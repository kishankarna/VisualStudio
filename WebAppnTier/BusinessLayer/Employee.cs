﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace BusinessLayer
{
    public class Employee
    {   //This are the properties of Employee
        
        public int ID { get; set; }
        [Required ]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public int Department_ID { get; set; }
    }
}

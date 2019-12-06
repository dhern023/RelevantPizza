﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RelevantPizza.ViewModels
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public decimal Salary { get; set; }
        
        public int RoleID { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper.Models
{
    
    public class Department 
    {
   
        public int DepartmentID { get; set; }
        public string? Name { get; set; }
    }
}

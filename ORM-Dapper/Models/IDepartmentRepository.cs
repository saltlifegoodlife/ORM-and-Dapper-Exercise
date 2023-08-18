﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper.Models
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments();

        public void InsertDepartment(string newDepartment);
    }
}

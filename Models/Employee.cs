﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApiCRUD.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary  { get; set; }
        public string Location { get; set; }
    }
}

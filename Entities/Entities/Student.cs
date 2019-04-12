﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTI.DataAccessTier.Entities
{
    public class Student
    {
        public int ID { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int DepartmentID { get; set; }

        public Department Department { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}

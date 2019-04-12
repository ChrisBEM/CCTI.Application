using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTI.DataAccessTier.Entities
{
    public class Course
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public float Cost { get; set; }

        public Department Department { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int DepartmentID { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

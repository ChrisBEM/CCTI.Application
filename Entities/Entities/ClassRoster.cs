using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTI.DataAccessTier.Entities
{
    public class ClassRoster
    {
        [System.ComponentModel.Browsable(false)]
        public string CourseCode { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string SectionCode { get; set; }

        public Course Course { get; set; }

        public CourseSection CourseSection { get; set; }

        public int StudentID { get; set; }

        public DateTime DateRegistered { get; set; }
    }
}

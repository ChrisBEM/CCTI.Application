using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTI.DataAccessTier.Entities
{
    public class CourseSection
    {
        [System.ComponentModel.Browsable(false)]
        public string CourseCode { get; set; }

        public Course Course { get; set; }

        public string SectionCode { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string RoomNumber { get; set; }

        public override string ToString()
        {
            return SectionCode;
        }
    }
}

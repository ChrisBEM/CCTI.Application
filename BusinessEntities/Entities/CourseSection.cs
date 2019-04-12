using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CourseSection : Entity
    {
       
        public Course Course { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string CourseCode { get; set; }

        public string SectionCode
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.SectionCode]);
            }

            set
            {
                EntityRow[Constants.DataColumns.SectionCode] = value;
            }
        }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string RoomNumber {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.RoomNumber]);
            }

            set
            {
                EntityRow[Constants.DataColumns.RoomNumber] = value;
            }
        }

        public override string ToString()
        {
            return SectionCode;
        }
    }
}

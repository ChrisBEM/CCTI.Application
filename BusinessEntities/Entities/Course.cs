using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Course : Entity
    {
        public string Code
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.Code]);
            }

            set
            {
                EntityRow[Constants.DataColumns.Code] = value;
            }
        }

        public string Name
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.Name]);
            }

            set
            { 
                EntityRow[Constants.DataColumns.Name] = value;
            }
        }

        public string Description
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.Description]);
            }

            set
            {
                EntityRow[Constants.DataColumns.Description] = value;
            }
        }

        public Decimal Cost
        {
            get
            {
                return Convert.ToDecimal(EntityRow[Constants.DataColumns.Cost]);
            }

            set
            {
                EntityRow[Constants.DataColumns.Cost] = value;
            }
        }

        public Department Department { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int DepartmentID { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}

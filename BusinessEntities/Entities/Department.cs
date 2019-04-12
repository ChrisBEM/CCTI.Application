using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Department : Entity
    {
        public int ID { get; set; }

        public string Code {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.DeptCode]);


            }

            set
            {
                EntityRow[Constants.DataColumns.DeptCode] = value;

                
            }
        }

        public string Name {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.DeptName]);
            }

            set
            {
                EntityRow[Constants.DataColumns.DeptName] = value;
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}

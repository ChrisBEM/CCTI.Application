using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Student : Entity
    {
        public int ID { get; set; }

        [System.ComponentModel.Browsable(false)]
        public int DepartmentID { get; set; }

        public Department Department { get; set; }

        public string FirstName
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.FirstName]);
            }

            set
            {
                EntityRow[Constants.DataColumns.FirstName] = value;
            }
        }

        public string LastName
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.LastName]);
            }

            set
            {
                EntityRow[Constants.DataColumns.LastName] = value;
            }
        }

        public string Address
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.Address]);
            }

            set
            {
                EntityRow[Constants.DataColumns.Address] = value;
            }
        }

        public string City
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.City]);
            }

            set
            {
                EntityRow[Constants.DataColumns.City] = value;
            }
        }

        public string Province { get; set; }

        public string PostalCode
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.PostalCode]);
            }

            set
            {
                EntityRow[Constants.DataColumns.PostalCode] = value;
            }
        }

        public string Phone
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.Phone]);
            }

            set
            {
                EntityRow[Constants.DataColumns.Phone] = value;
            }
        }

        public string Email
        {
            get
            {
                return Convert.ToString(EntityRow[Constants.DataColumns.Email]);
            }

            set
            {
                EntityRow[Constants.DataColumns.Email] = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}

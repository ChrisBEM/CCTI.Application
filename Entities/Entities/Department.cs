using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCTI.DataAccessTier.Entities
{
    public class Department
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}

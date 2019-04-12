using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Province : Entity
    {
        public string Code { get; set; }

        public string Name { get; set; }
        public string City { get; set; }
    }
}

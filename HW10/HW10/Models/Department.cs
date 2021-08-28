using HW10.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Models
{
    public class Department: CatalogBase, ICloneable
    {
        public Department HeadDepartment { get; set; }
        public string Memo { get; set; }

        public Department()
        {

        }

        public Department(Department source):base(source)
        {
            HeadDepartment = source.HeadDepartment;
            Memo = source.Memo;
        }

        public override Department CloneCatalog()
        {
            return new Department(this);
        }

        public object Clone()
        {
            return new Department(this);
        }

        public override string ToString()
        {
            return $"{Code} {Title}";
        }
    }
}

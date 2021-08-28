using HW10.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Models
{
    public class Employee:Person, ICloneable
    {
        public string Position { get; set; }
        public Department Department { get; set; }

        public Employee()
        {
                
        }

        public Employee(Employee source):base(source)
        {
            Position = source.Position;
            Department = source.Department;
        }

        public override Employee CloneCatalog()
        {
            return new Employee(this);
        }

        new public object Clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"{base.ToString()} - {Position}";
        }
    }
}

using HW10.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Models
{
    public class Person : CatalogBase, ICloneable
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                BuildTitle();
            }
        }
        public string MiddleName
        {
            get
            {
                return _middleName;
            }
            set
            {
                _middleName = value;
                BuildTitle();
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                BuildTitle();
            }
        }
        public DateTime DateOfBirth { get; set; }

        public Person()
        {

        }

        public Person(Person source) : base(source)
        {
            FirstName = source.FirstName;
            MiddleName = source.MiddleName;
            LastName = source.LastName;
            DateOfBirth = source.DateOfBirth;
        }

        public override Person CloneCatalog()
        {
            return new Person(this);
        }

        public object Clone()
        {
            return new Person(this);
        }

        public override string ToString()
        {
            return $"{Title} - {DateOfBirth:dd.MM.yyyy}";
        }

        private void AppendTitlePart(StringBuilder sb, string part)
        {
            if (!string.IsNullOrEmpty(part))
            {
                if (sb.Length > 0)
                {
                    sb.Append(" ");
                }
                sb.Append(part);
            }
        }

        private void BuildTitle()
        {
            var sb = new StringBuilder();

            AppendTitlePart(sb, _firstName);
            AppendTitlePart(sb, _middleName);
            AppendTitlePart(sb, _lastName);

            Title = sb.ToString();
        }

    }
}

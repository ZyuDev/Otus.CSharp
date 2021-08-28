using HW10.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Models
{
    public abstract class CatalogBase : ICatalog, ICatalogClonable
    {
        public Guid Uid { get; set; } = Guid.NewGuid();
        public string Code { get; set; }
        public string Title { get; set; }

        public CatalogBase()
        {

        }

        public CatalogBase(ICatalog source)
        {
            Code = source.Code;
            Title = source.Title;
        }

        public abstract ICatalog CloneCatalog();
       
    }
}

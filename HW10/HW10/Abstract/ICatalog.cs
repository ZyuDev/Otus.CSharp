using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Abstract
{
    public interface ICatalog
    {
        Guid Uid { get; set; }
        string Code { get; set; }
        string Title { get; set; }
    }
}

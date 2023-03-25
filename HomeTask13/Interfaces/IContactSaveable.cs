using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13.Interfaces
{
    internal interface IContactSaveable
    {
        bool Save(IEnumerable<IContact> items);
    }
}

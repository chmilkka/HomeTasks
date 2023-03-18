using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask13
{
    internal class InMemoryContactProvider : IContactProvider
    {
        public IEnumerable<IContact> Get()
        {
            return new List<IContact>();
        }
    }
}

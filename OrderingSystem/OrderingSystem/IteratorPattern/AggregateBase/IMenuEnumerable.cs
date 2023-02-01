using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.IteratorPattern.IteratorBase;

namespace OrderingSystem.IteratorPattern.AggregateBase
{
    public interface IMenuEnumerable
    {
        IMenuIterator GetIterator();
    }
}

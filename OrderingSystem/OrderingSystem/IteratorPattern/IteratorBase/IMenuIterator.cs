using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.CompositePattern.Component;

namespace OrderingSystem.IteratorPattern.IteratorBase
{
    public interface IMenuIterator
    {
        void MoveFirst();

        void Reset();

        bool MoveNext();

        MenuComponent Current { get; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.IteratorPattern.IteratorBase;
using OrderingSystem.IteratorPattern.ConcreteAggregate;
using OrderingSystem.CompositePattern.Component;

namespace OrderingSystem.IteratorPattern.ConcreteIterator
{
    public class MenuEnumerator : IMenuIterator
    {
        private MenuAggregate _aggregate;
        int _position;

        public MenuEnumerator(MenuAggregate aggregate)
        {
            _aggregate = aggregate;
        }
        
        public void MoveFirst()
        {
            if (_aggregate.Count == 0)
            {
                throw new InvalidOperationException();
            }
            _position = 0;
        }

        public void Reset()
        {
            _position = -1;
        }

        public bool MoveNext()
        {
            _position++;
            return _position < _aggregate.Count;
        }

        public MenuComponent Current
        {
            get
            {
                if (_position < _aggregate.Count)
                    return _aggregate[_position];
                throw new InvalidOperationException();
            }
        }
    }
}

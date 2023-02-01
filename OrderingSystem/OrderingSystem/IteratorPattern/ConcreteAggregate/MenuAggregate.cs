using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.CompositePattern.Component;
using OrderingSystem.IteratorPattern.AggregateBase;
using OrderingSystem.IteratorPattern.IteratorBase;
using OrderingSystem.IteratorPattern.ConcreteIterator;

namespace OrderingSystem.IteratorPattern.ConcreteAggregate
{
    public class MenuAggregate : IMenuEnumerable
    {  
        private List<MenuComponent> _components = new List<MenuComponent>();

        public MenuComponent this[int index]
        {
            get { return _components[index]; }
        }       

        public void SetCompoenents(List<MenuComponent> components)
        {
            _components = components;
        }

        public IMenuIterator GetIterator()
        {
            return new MenuEnumerator(this);
        }

        public int Count
        {
            get { return _components.Count; }
        }
    }
}

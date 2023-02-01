using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using OrderingSystem.IteratorPattern.ConcreteIterator;

namespace OrderingSystem.CompositePattern.Component
{
    public abstract class MenuComponent
    {
        public virtual bool IsLeaf { get; set; }
        public virtual string Name { get; set; }
        public virtual double Price { get; set; }
        public virtual bool IsVegetarian { get; set; }
        public virtual int Depth { get; set; }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }


        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }


        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }


        public abstract void Render(int depth);


        //public abstract List<ArrayList> GetInfo(); //list of all the rows to create the datagridview

        public abstract List<MenuComponent> GetAllChildren();

        //public virtual IEnumerator<MenuComponent> CreateEnumerator()
        //{
        //    return new MenuEnumerator();
        //}
    }
}

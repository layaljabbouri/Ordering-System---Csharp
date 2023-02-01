using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.CompositePattern.Component;
using System.Collections;

namespace OrderingSystem.CompositePattern.Leaf
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, double price, bool isveg)
        {
            Name = name;
            Price = price;
            IsVegetarian = isveg;
            IsLeaf = true;
        }

        public MenuItem(string name, double price)
        {
            Name = name;
            Price = price;
            IsLeaf = true;
        }

        public override void Render(int depth)
        {
            Depth = depth;
           
        }

        public override List<MenuComponent> GetAllChildren()
        {
            List<MenuComponent> list = new List<MenuComponent>();

            list.Add(this);
            return list;
        }

        //public override List<ArrayList> GetInfo()
        //{
        //    List<ArrayList> list = new List<ArrayList>();
        //    ArrayList row = new ArrayList();
        //    row.Add(Name);
        //    row.Add(Price);
        //    list.Add(row);
        //    return list;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.CompositePattern.Component;
using System.Collections;

namespace OrderingSystem.CompositePattern.Composite
{
    public class Menu : MenuComponent
    {
        private readonly List<MenuComponent> _menuComponents;


        public Menu(String name)
        {
            Name = name;
            IsLeaf = false;
            _menuComponents = new List<MenuComponent>();
        }


        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }


        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }


        public override MenuComponent GetChild(int i)
        {
            return _menuComponents[i];
        }


        public override void Render(int depth)
        {

            foreach (var component in _menuComponents)
            {
                Depth = depth + 1;
                Render(component.Depth);
            }

        }


        public override List<MenuComponent> GetAllChildren()
        {
            List<MenuComponent> allchildren = new List<MenuComponent>();
            allchildren.Add(this);
            foreach (var component in _menuComponents)
            {
               
               List<MenuComponent> list2 =  component.GetAllChildren();
                allchildren.AddRange(list2);
            }
            
            return allchildren;
        }

        //public override List<ArrayList> GetInfo()
        //{
        //    List<ArrayList> list = new List<ArrayList>();
        //    ArrayList row = new ArrayList();
        //    row.Add(Name);
        //    foreach (var item in _menuComponents)
        //    {
        //        List<ArrayList> list2 = new List<ArrayList>();
        //        list2 = item.GetInfo();
        //        list.AddRange(list2);
        //    }
        //    return list;

        //}

    }
}

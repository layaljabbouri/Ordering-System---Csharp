using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.BuilderPattern.Product
{
    public class Order
    {

        public int orderNumber;
        public DateTime dateTime { get; set; }
        public double total { get; set; }
        public Dictionary<OrderingSystem.CompositePattern.Component.MenuComponent, int> _items { get; set; }
        public String orderStatus { get; set; }

        public Order()
        {
            _items = new Dictionary<CompositePattern.Component.MenuComponent, int>();
        }

        public double GetTotal(bool freeDrink)
        {
            total = 0;
            CompositePattern.Component.MenuComponent item;
            foreach (var currentitem in _items)
            {
                
                item = currentitem.Key;
                double price = currentitem.Value * item.Price; //price of a specific item with quantity 1 or >1
                total += price;
               
            }
            if (freeDrink) //free drink for new customers
            {
                if (_items.Count != 0)
                {
                    total -= _items.Last().Key.Price; //exclude the price of the free drink after being added to the order
                    _items.Last().Key.Price = 0; //in order to print it
                }
               
            }
            
            return total;
        }



    }
}

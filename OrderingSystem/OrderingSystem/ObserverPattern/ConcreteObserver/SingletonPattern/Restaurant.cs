using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.BuilderPattern.Product;
using OrderingSystem.CompositePattern.Component;

namespace OrderingSystem.SingletonPattern
{
    public sealed class Restaurant : ObserverPattern.ObserverBase.IStatusObserverBase //acts as concrete observer
    {
        #region singleton
        private static volatile Restaurant _instance;
        private static object _lockThis = new object();

        //private Restaurant() { }

        public static Restaurant GetRestaurant()
        {
            if (_instance == null)
            {
                lock (_lockThis)
                {
                    if (_instance == null) _instance = new Restaurant();
                }
            }
            return _instance;
        }

        #endregion

        public List<Order> orders = new List<Order>();

        public List<_Staff> staffs = new List<OrderingSystem._Staff>();

        public List<MenuComponent> menus = new List<MenuComponent>();

        public void AddOrder(Order o)
        {
            orders.Add(o);
        }

        public void RemoveOrder(Order o)
        {
            orders.Remove(o);
        }

        public void AddStaff(_Staff s)
        {
            staffs.Add(s);
        }

        public void RemoveStaff(_Staff s)
        {
            staffs.Remove(s);
        }


        #region Concrete observer
        public void Notify(int ordernum, String orderstatus)
        {
            foreach (Order o in orders)
            {
                if (o.orderNumber == ordernum)
                {
                    o.orderStatus = orderstatus;
                }
            }
        }
        #endregion


    }
}

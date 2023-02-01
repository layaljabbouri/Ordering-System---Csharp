using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.BuilderPattern.Product;
using System.Windows.Forms;
using OrderingSystem.SingletonPattern;

namespace OrderingSystem.BuilderPattern.Builder
{
    public abstract class OrderBuilder
    {
        protected Order _order;

        public void CreateOrder()
        {
            _order = new Order();
        }

        public abstract void SetTotal();

        public abstract void SetItems(DataGridView dgv);

        public void SetDateTime()
        {
            _order.dateTime = DateTime.Now;
        }

        public void SetOrderStatus() { _order.orderStatus = "Pending"; }

        public void SetOrderNumber()
        {
            //generate a unique order number
           Restaurant restaurant = Restaurant.GetRestaurant();
            if (restaurant.orders.Count != 0)
            {
                _order.orderNumber = restaurant.orders.Last().orderNumber + 1;
            }
            else _order.orderNumber = 1;
        }

        public Order GetOrder()
        {
            return _order;
        }


    }
}


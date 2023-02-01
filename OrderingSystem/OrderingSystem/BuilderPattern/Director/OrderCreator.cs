using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.BuilderPattern.Builder;
using System.Windows.Forms;

namespace OrderingSystem.BuilderPattern.Director
{
    public class OrderCreator
    {
        private readonly OrderBuilder _builder;

        public OrderCreator(OrderBuilder builder)
        {
            _builder = builder;
        }

        public void CreateOrder(DataGridView dgv)
        {
            _builder.CreateOrder();
            _builder.SetOrderNumber(); //builder
            _builder.SetDateTime(); //builder
            _builder.SetItems(dgv); //concrete builder
            _builder.SetTotal(); //concrete builder
        }
    }
}

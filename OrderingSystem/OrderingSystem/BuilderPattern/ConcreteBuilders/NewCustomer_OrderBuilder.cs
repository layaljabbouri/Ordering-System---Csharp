using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.BuilderPattern.Builder;
using System.Windows.Forms;

namespace OrderingSystem.BuilderPattern.ConcreteBuilders
{
    public class NewCustomer_OrderBuilder: OrderBuilder
    {

        public override void SetItems(DataGridView dgv)
        {
            for (int row = 0; row < dgv.RowCount; row++)
            {
                //dgv.Rows[row].Cells[3].Value != null &&
                if (dgv.Rows[row].Cells[3].Value != null && dgv.Rows[row].Cells[3].Value.ToString() != "" && dgv.Rows[row].Cells[3].Value.ToString() != "0")
                {
                    CompositePattern.Leaf.MenuItem item = new CompositePattern.Leaf.MenuItem(dgv.Rows[row].Cells[0].Value.ToString(), int.Parse(dgv.Rows[row].Cells[1].Value.ToString()));


                    _order._items.Add(item, int.Parse(dgv.Rows[row].Cells[3].Value.ToString()));
                }
            }
            if(_order._items.Count != 0)
            {
                _order._items.Add(new CompositePattern.Leaf.MenuItem("Free Soft Drink", 15000, true), 1); //to add a free drink eza eemil  order
            }
            
        }

        public override void SetTotal()
        {
            _order.total =_order.GetTotal(true); 
        }

    }
}

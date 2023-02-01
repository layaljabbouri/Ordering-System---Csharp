using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderingSystem.BuilderPattern.Builder;
using System.Windows.Forms;

namespace OrderingSystem.BuilderPattern.ConcreteBuilders
{
    public class SpecialCustomer_OrderBuilder : OrderBuilder
    {

        public override void SetItems(DataGridView dgv)
        {
            //_order._items = new Dictionary<CompositePattern.Leaf.MenuItem, int>(); no need,  already done in orderbuilder

            for (int row = 0; row < dgv.RowCount; row++)
            {
                if (dgv.Rows[row].Cells[3].Value != null && dgv.Rows[row].Cells[3].Value.ToString() != "" && dgv.Rows[row].Cells[3].Value.ToString() != "0")
                {
                    CompositePattern.Leaf.MenuItem item = new CompositePattern.Leaf.MenuItem(dgv.Rows[row].Cells[0].Value.ToString(), int.Parse(dgv.Rows[row].Cells[1].Value.ToString()));


                    _order._items.Add(item, int.Parse(dgv.Rows[row].Cells[3].Value.ToString()));
                }
            }
            
        }

        public override void SetTotal()
        {
           _order.total =  0.9*(_order.GetTotal(false)); //10% discount for special customers
        }
        
    }
}

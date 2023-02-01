using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystem.IteratorPattern.ConcreteAggregate;
using OrderingSystem.IteratorPattern.IteratorBase;
using OrderingSystem.CompositePattern.Component;
//using OrderingSystem.CompositePattern.Composite;
//using OrderingSystem.CompositePattern.Leaf;
using OrderingSystem.BuilderPattern.Product;
using OrderingSystem.BuilderPattern.Director;
using OrderingSystem.BuilderPattern.ConcreteBuilders;
using OrderingSystem.BuilderPattern.Builder;
using OrderingSystem.SingletonPattern;


namespace OrderingSystem
{
    public partial class menu : Form
    {
        List<MenuComponent> menuItems;
        Dictionary<CompositePattern.Component.MenuComponent, int> items_qttyToBeModified;
        DataGridView menuDgv = new DataGridView();
        bool isNewCustomer;
        Restaurant restaurant = Restaurant.GetRestaurant();
        
       
        public menu(bool IsNewCustomer)
        {
            InitializeComponent();
            PrintMenu(GetMenu());
            isNewCustomer = IsNewCustomer;
        }

        public menu(Order orderToBeModified, bool IsNewCustomer)
        {
            isNewCustomer = IsNewCustomer;
            InitializeComponent();
            items_qttyToBeModified = new Dictionary<MenuComponent, int>();
            items_qttyToBeModified = orderToBeModified._items;
            PrintMenu(GetMenu());
            orderToBeModified = null;
            items_qttyToBeModified = null;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.menuDgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuDgv_CellEndEdit);
            
        }
       
        public List<MenuComponent> GetMenu()
        {
            menuItems = new List<MenuComponent>();
            MenuComponent _menu = Restaurant.GetRestaurant().menus[0];
            menuItems = _menu.GetAllChildren();
            return menuItems;
        }

        public void PrintMenu(List<MenuComponent> menu)
        {
           

            #region Datagridview initialization
            
            menuDgv.Columns.Add("name", "Name");
            menuDgv.Columns.Add("price", "Price");
            menuDgv.Columns.Add("qty", "");
            menuDgv.Columns.Add("quantity", "Quantity");
            menuDgv.ColumnHeadersVisible = false;
            menuDgv.BackgroundColor = Color.White;
            menuDgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            menuDgv.AutoSize = false;
            menuDgv.ScrollBars = ScrollBars.Vertical;
            menuDgv.AllowUserToResizeColumns = false;
            menuDgv.AllowUserToResizeRows = false;
            menuDgv.Width = centerPanel.Width;
            menuDgv.Height = centerPanel.Height;
            menuDgv.Columns[0].ReadOnly = true;
            menuDgv.Columns[1].ReadOnly = true;
            menuDgv.Columns[2].ReadOnly = true;
            menuDgv.Columns[3].ReadOnly = true;
            menuDgv.Columns[0].Width = 150;
            menuDgv.Columns[1].Width = 100;
            menuDgv.Columns[2].Width = 100;
            menuDgv.Columns[3].Width = 80;
            menuDgv.BackgroundColor = Color.FromArgb(140, 163, 203);
            menuDgv.ForeColor = Color.White;
            centerPanel.Controls.Add(menuDgv);
            menuDgv.Show();
            menuDgv.BorderStyle = BorderStyle.None;
            menuDgv.RowHeadersVisible = false;
            menuDgv.DefaultCellStyle.Font = new Font("Verdana", 10F, FontStyle.Regular);
            #endregion


            //iterator pattern

            MenuAggregate aggregate = new MenuAggregate();
            aggregate.SetCompoenents(menu);

            IMenuIterator iterator = aggregate.GetIterator();
            while (iterator.MoveNext())
            {
                if(iterator.Current.IsLeaf)
                {
                    
                    if (items_qttyToBeModified != null)
                    {
                        bool found = false;
                        int quantity = 0;
                        foreach (var orderitem in items_qttyToBeModified)
                        {
                           MenuComponent comp = orderitem.Key;
                           if (iterator.Current.Name == comp.Name)
                           {
                               quantity = orderitem.Value;
                               found = true;
                               break;
                           }
                        }
                        if(found)
                        {
                            menuDgv.Rows.Add(iterator.Current.Name, iterator.Current.Price, "Quantity", quantity);
                        }
                        else
                        {
                            menuDgv.Rows.Add(iterator.Current.Name, iterator.Current.Price, "Quantity");
                        }
                        
                    }
                    else //if i am not modifying the order; print with no initial quanities
                    {
                        menuDgv.Rows.Add(iterator.Current.Name, iterator.Current.Price, "Quantity");
                    }

                    menuDgv.Rows[menuDgv.RowCount-2].Cells[3].ReadOnly = false; //laean fi row b kun null baad l added
                }
                else
                {
                    menuDgv.Rows.Add(iterator.Current.Name);
                    menuDgv.Rows[menuDgv.RowCount - 2].Cells[3].ReadOnly = true ;
                    menuDgv.Rows[menuDgv.RowCount - 2].DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Bold);
                }

                menuDgv.Rows[menuDgv.RowCount - 2].DefaultCellStyle.BackColor = Color.FromArgb(140, 163, 203);
                
            }

            menuDgv.Rows[menuDgv.RowCount -1 ].DefaultCellStyle.BackColor = Color.FromArgb(140, 163, 203);

        }


       
        public Order GetOrder()
        {
            OrderBuilder builder;
            if (isNewCustomer)
            {
                builder = new NewCustomer_OrderBuilder();
            }
            else
            {
                builder = new SpecialCustomer_OrderBuilder();
            }
            OrderCreator _ordercreator = new OrderCreator(builder);
            _ordercreator.CreateOrder(menuDgv);
            return builder.GetOrder();
        }


        private void menuDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int qtty;
            var s = menuDgv.Rows[row].Cells[3].Value;
            if (s != null)
            {
                if (s.ToString() != "")
                {
                    if (!int.TryParse(s.ToString(), out qtty))
                    {
                        menuDgv.Rows[row].Cells[3].Value = "";
                        MessageBox.Show("Kindly input a valid quantity");
                    }
                    else if (int.Parse(s.ToString()) < 0)
                    {
                        menuDgv.Rows[row].Cells[3].Value = "";
                        MessageBox.Show("Kindly input a valid quantity");
                    }
                    else if (int.Parse(s.ToString()) == 0)
                    {
                        menuDgv.Rows[row].Cells[3].Value = "";
                    }
                }
                
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to reset the order?", "Order Cancelation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                menu m = new menu(isNewCustomer);
                m.Show();
            }
        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {

            Order order = GetOrder();  //builder pattern
            if (order != null && order._items.Count != 0)
            {

                OrderConfirmation orderConfirmation = new OrderConfirmation(order, isNewCustomer);
                orderConfirmation.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select items in order to proceed");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            bool IsEmpty = true;
            for(int i =0; i< menuDgv.RowCount -1; i++)
            {
                if(menuDgv.Rows[i].Cells[3].Value != null && menuDgv.Rows[i].Cells[3].Value.ToString() != "")
                {
                    IsEmpty = false;
                    break;
                }
            }
            if (!IsEmpty)
            {
                if (MessageBox.Show("You will lose all the data. Do you want to continue?", "Back", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Hide();
                    HomePage homepage = new HomePage();
                    homepage.Show();
                }
            }
            else
            {
                this.Hide();
                HomePage homepage = new HomePage();
                homepage.Show();
            }
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        
    }
}

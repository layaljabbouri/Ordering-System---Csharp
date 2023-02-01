using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystem.BuilderPattern.Product;
using OrderingSystem.CompositePattern.Component;
using OrderingSystem.SingletonPattern;

namespace OrderingSystem
{
    public partial class OrderConfirmation : Form
    {
        Order order = new Order();
        DataGridView billDgv;
        bool isNew;
        Restaurant restaurant = Restaurant.GetRestaurant();

        public OrderConfirmation(Order orderToBeConfirmed, bool isnew)
        {
            InitializeComponent();
            isNew = isnew;
            order = orderToBeConfirmed;
        }

        private void OrderConfirmation_Load(object sender, EventArgs e)
        {

            #region bill initialization
            billDgv = new DataGridView();
            billDgv.Columns.Add("name", "Name");
            billDgv.Columns.Add("price", "Price");
            billDgv.Columns.Add("quantity", "Quantity");
            billDgv.Columns.Add("totalprice", "TotalPrice");
            billDgv.ColumnHeadersVisible = false;
            billDgv.BackgroundColor = Color.FromArgb(140, 163, 203);
            billDgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            billDgv.AutoSize = false;
            billDgv.ScrollBars = ScrollBars.Vertical;
            billDgv.AllowUserToResizeColumns = false;
            billDgv.AllowUserToResizeRows = false;
            billDgv.Width = 440;
            billDgv.Height = 600;
            billDgv.Columns[0].ReadOnly = true;
            billDgv.Columns[1].ReadOnly = true;
            billDgv.Columns[2].ReadOnly = true;
            billDgv.Columns[0].Width = 150;
            billDgv.Columns[1].Width = 120;
            billDgv.Columns[2].Width = 50;
            billDgv.Columns[3].Width = 120;
            billPanel.Controls.Add(billDgv);
            billDgv.Show();
            billDgv.BorderStyle = BorderStyle.None;
            billDgv.RowHeadersVisible = false;
            billDgv.DefaultCellStyle.Font = new Font("Verdana", 10F, FontStyle.Regular);
            #endregion

            PrintBill();
            totalTxtBox.Text = order.total.ToString() + " LBP";
            orderNumberTxtBox.Text = order.orderNumber.ToString();
           
        }

        public void PrintBill()
        {
           foreach(var item in order._items)
            {
                MenuComponent m = item.Key;
                billDgv.Rows.Add(m.Name, m.Price, item.Value, m.Price * item.Value);
                billDgv.Rows[billDgv.RowCount - 2].DefaultCellStyle.ForeColor = Color.White;
                billDgv.Rows[billDgv.RowCount - 2].DefaultCellStyle.BackColor = Color.FromArgb(140, 163, 203);
            }
            billDgv.Rows[billDgv.RowCount - 1].DefaultCellStyle.BackColor = Color.FromArgb(140, 163, 203);
            billDgv.ScrollBars = ScrollBars.Vertical;
            billDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            billDgv.Height = billPanel.Height;
        }        

        private void modifyBtn_Click(object sender, EventArgs e)
        {
            menu m = new menu(order,isNew);
            this.Hide();
            m.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to cancel the order?", "Order Cancelation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                order.orderStatus = "Canceled";
                menu m = new menu(isNew);
                m.Show();
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to proceed?", "Order Conformation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                order.orderStatus = "In Progress";
                restaurant.orders.Add(order);
                MessageBox.Show("Your Order Is Now In Progress!");
                menu _menu = new menu(isNew);
                this.Hide();
                _menu.Show();
                
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            menu m = new menu(order, isNew);
            this.Hide();
            m.Show();
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

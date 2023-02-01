using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderingSystem.SingletonPattern;

namespace OrderingSystem.Customer
{
    public partial class TrackOrder : Form
    {
        public TrackOrder()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Hide();
            hp.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            Restaurant restaurant = Restaurant.GetRestaurant();
            int ordernb;
            bool isValid = int.TryParse(ordernumberTxtBox.TextName, out ordernb);
            bool found = false;
            if(isValid)
            {
                foreach(var order in restaurant.orders)
                {
                    if(order.orderNumber == ordernb)
                    {
                        found = true;
                        statusTxtBox.TextName = order.orderStatus;
                    }
                }
                if (!found)
                {
                    statusTxtBox.TextName = "";
                    ordernumberTxtBox.TextName = "";
                    MessageBox.Show("Make sure the order number is correct.");
                }
            }
            else
            {
                statusTxtBox.TextName = "";
                ordernumberTxtBox.TextName = "";
                MessageBox.Show("Kindly input a valid order number");
            }
        }

       
    }
}

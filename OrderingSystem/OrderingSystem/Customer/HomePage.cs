using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class HomePage : Form
    {
        bool isNewCustomer;
        public HomePage()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage wp = new WelcomePage();
            wp.Show();
        }

  

        private void newOrderBtn_Click(object sender, EventArgs e)
        {
            bool oneischecked = oneRadioBtnIsChecked();
            if (!oneischecked) MessageBox.Show("Kindly indicate whether you  are a new or a special customer");
            else
            {
                bool IsNewCustomer = newCustomerRadioBtn.Checked;
                menu m = new menu(IsNewCustomer);
                this.Hide();
                m.Show();
            }
            
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            bool oneischecked = oneRadioBtnIsChecked();
            if (!oneischecked) MessageBox.Show("Kindly indicate whether you  are a new or a special customer");
            else
            {
                bool IsNewCustomer = newCustomerRadioBtn.Checked;
                menu m = new menu(IsNewCustomer);
                this.Hide();
                m.Show();
            }
        }

        private void trackOrderBtn_Click(object sender, EventArgs e)
        {
            Customer.TrackOrder track = new Customer.TrackOrder();
            this.Hide();
            track.Show();
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            Customer.TrackOrder track = new Customer.TrackOrder();
            this.Hide();
            track.Show();
        }

        public bool oneRadioBtnIsChecked()
        {
            if (newCustomerRadioBtn.Checked == false && specialCustomerRadioBtn.Checked == false)
            {
                return false;
            }
            else return true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }
    }
}

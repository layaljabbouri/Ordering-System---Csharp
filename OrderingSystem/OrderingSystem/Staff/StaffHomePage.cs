using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem.Staff
{
    public partial class StaffHomePage : Form
    {
        _Staff staff;

        public StaffHomePage(_Staff s)
        {
            staff = s;
            InitializeComponent();
        }

      
        private void inProgressBtn_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("InProgress", staff);
            this.Hide();
            c.Show();
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("InProgress", staff);
            this.Hide();
            c.Show();
        }

        private void nowServingBtn_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("NowServing",staff);
            this.Hide();
            c.Show();
        }

        private void btnNowServing_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("NowServing",staff);
            this.Hide();
            c.Show();
        }

        private void completedBtn_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("Completed",staff);
            this.Hide();
            c.Show();
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("Completed",staff);
            this.Hide();
            c.Show();
        }

        

        private void closeBtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                WelcomePage wp = new WelcomePage();
                this.Hide();
                wp.Show();
            }
        }

        private void listOfOrdersBtn_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("AllOrders", staff);
            this.Hide();
            c.Show();
        }

        private void btnListOfOrders_Click(object sender, EventArgs e)
        {
            CheckOrders c = new CheckOrders("AllOrders", staff);
            this.Hide();
            c.Show();
        }
    }
}

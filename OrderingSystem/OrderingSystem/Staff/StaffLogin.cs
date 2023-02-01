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

namespace OrderingSystem
{
    public partial class StaffLogin : Form
    {

        Restaurant restaurant = Restaurant.GetRestaurant();
       

        public StaffLogin()
        {
            
            InitializeComponent();
        }
        


        private void proceedBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTextBox.TextName;
            String password = passwordTextBox.TextName;
            bool found = false;
            _Staff staff = new _Staff("","","");
            foreach(var s in restaurant.staffs)
            {
                
                if(username == s.username)
                {
                    if(password == s.password)
                    {
                        found = true;
                        staff = s;
                        
                    }
                    
                }
               
            }
            
            if (!found)
            {
                MessageBox.Show("Invalid Username/Password");
            }
            else
            {
                Staff.StaffHomePage page = new Staff.StaffHomePage(staff);
                this.Hide();
                page.Show();

            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.TextName == "PassWorD")
            {
                passwordTextBox.TextName = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.IsPassword = true;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
           
                if (passwordTextBox.TextName == "")
                {
                    passwordTextBox.TextName = "PassWorD";
                    passwordTextBox.ForeColor = Color.Gray;
                    passwordTextBox.IsPassword = true;
                }
                else
                {
                    passwordTextBox.ForeColor = Color.Black;
                    passwordTextBox.IsPassword = true;
                }
            
        }
   

        private void back_Click(object sender, EventArgs e)
        {
            WelcomePage wp = new WelcomePage();
            this.Hide();
            wp.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you sure you want to exit?","Exit",MessageBoxButtons.YesNo)==DialogResult.Yes)
            Application.Exit();
        }
    }
}

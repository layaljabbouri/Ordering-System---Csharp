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
using OrderingSystem.BuilderPattern.Product;
using OrderingSystem.ObserverPattern.ConcreteSubjects;
//using 

namespace OrderingSystem.Staff
{
    public partial class CheckOrders : Form
    {
        String InProgress_NowServing_Completed;
        DataGridView dgv = new DataGridView();
        Restaurant restaurant = Restaurant.GetRestaurant();
        _Staff staff;
        bool printed = false;
        double total = 0;



        public CheckOrders(String s , _Staff st)
        {
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            staff = st;
            InProgress_NowServing_Completed = s;
            InitializeComponent();
            #region Datagridview initialization
            //dgv = new DataGridView();
            dgv.Columns.Add("orderNumber", "Order Number");
            dgv.Columns.Add("orderDateTime", "Date - Time");
            dgv.Columns.Add("total", "Total");
            dgv.BackgroundColor = Color.White;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.AutoSize = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.Width = centerPanel.Width;
            dgv.Height = centerPanel.Height;
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns[0].Width = 90;
            dgv.Columns[1].Width = 153;
            dgv.Columns[2].Width = 80;
            dgv.BackgroundColor = Color.FromArgb(140, 163, 203);
            dgv.ForeColor = Color.Black;
            centerPanel.Controls.Add(dgv);
            dgv.Show();
            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.Font = new Font("Verdana", 7F, FontStyle.Regular);
            dgv.Height = centerPanel.Height;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            #endregion
        }

        private void CheckOrders_Load(object sender, EventArgs e)
        {
            switch (InProgress_NowServing_Completed)
            {
                case "InProgress":
                    dgvInProgress();
                    headerLbl.Text = "In Progress";
                    break;
                case "NowServing":
                    dgvNowServing();
                    headerLbl.Text = "Now Serving";
                    break;
                case "Completed":
                    dgvCompleted();
                    headerLbl.Text = "Completed";
                    break;

                case "AllOrders":
                    dgvAllOrders();
                    headerLbl.Text = "All orders";
                    break;
            }
           
        }


        public void dgvInProgress()
        {
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.Items.AddRange("In Progress", "Now Serving", "Completed");
            dgv.Columns.Add(dgvCmb);
            dgv.Columns[3].HeaderText = "Status";
            dgv.Columns[3].Name = "Status";
            dgv.Columns[3].ReadOnly = false;
            dgv.Columns[3].Width = 150;
            foreach (Order order in restaurant.orders)
            {
                if(order.orderStatus == "In Progress")
                dgv.Rows.Add(order.orderNumber, order.dateTime, order.total, order.orderStatus);
                dgv.Columns[3].Width = 150;
            }
            printed = true;
            totalLbl.Hide();
            totalTxtBox.Hide();

        }

        public void dgvNowServing()
        {
            DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
            dgvCmb.Items.AddRange("Now Serving", "Completed");
            dgv.Columns.Add(dgvCmb);
            dgv.Columns[3].HeaderText = "Status";
            dgv.Columns[3].Name = "Status";
            dgv.Columns[3].ReadOnly = false;
            dgv.Columns[3].Width = 150;
            foreach (Order order in restaurant.orders)
            {
                if(order.orderStatus == "Now Serving")
                dgv.Rows.Add(order.orderNumber, order.dateTime, order.total, order.orderStatus);
            }
            printed = true;
            totalLbl.Hide();
            totalTxtBox.Hide();
        }

        public void dgvCompleted()
        {
            dgv.Columns.Add("status", "Status");
            foreach (Order order in restaurant.orders)
            {
                if (order.orderStatus == "Completed")
                    dgv.Rows.Add(order.orderNumber, order.dateTime, order.total, "Completed");
                    dgv.Columns[3].Width = 150;
            }
            printed = true;
            totalLbl.Hide();
            totalTxtBox.Hide();
        }

        public void dgvAllOrders()
        {
            dgv.Columns.Add("status", "Status");
            foreach (Order order in restaurant.orders)
            {
                
                dgv.Rows.Add(order.orderNumber, order.dateTime, order.total, order.orderStatus);
                dgv.Columns[3].Width = 150;
                total += order.total;
            }
            printed = true;
            totalLbl.Show();
            totalTxtBox.Show();
            totalTxtBox.Text = total.ToString() + " LBP";
        }



        private void backBtn_Click(object sender, EventArgs e)
        {
            StaffHomePage hp = new StaffHomePage(staff);
            this.Hide();
            hp.Show();
        }
        

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            if (printed)
            {
                if (MessageBox.Show("Are you sure you want to change this order's status?", "Order Status", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    row = e.RowIndex;

                    //observer pattern

                    Publish(row);
                }
            }
            if (printed)
            {
                CheckOrders c = new CheckOrders(InProgress_NowServing_Completed, staff);
                this.Hide();
                c.Show();
            }
            
        }

        public void Publish(int row)
        {
            ConcretePublisher publisher = new ConcretePublisher(); //concrete publisher
            Restaurant restaurant = Restaurant.GetRestaurant(); //concrete observer
            publisher.register(restaurant); 
            publisher.Order(int.Parse(dgv.Rows[row].Cells[0].Value.ToString()), dgv.Rows[row].Cells[3].Value.ToString());
            publisher.Notify();
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Exit",MessageBoxButtons.YesNo) == DialogResult.Yes)
            Application.Exit();
        }

       
    }
}

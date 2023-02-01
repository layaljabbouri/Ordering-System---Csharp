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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();

            //Singleton pattern

            Restaurant restaurant = Restaurant.GetRestaurant();

            restaurant.staffs.Add(new _Staff("staff1.staff1", "staff1", "staff1"));
            restaurant.staffs.Add(new _Staff("staff2.staff2", "staff2", "staff2"));
            restaurant.staffs.Add(new _Staff("staff3.staff3", "staff3", "staff3"));
            restaurant.staffs.Add(new _Staff("staff4.staff4", "staff4", "staff4"));
            restaurant.staffs.Add(new _Staff("staff5.staff5", "staff5", "staff5"));


            //Composite Pattern

            var _menu = new CompositePattern.Composite.Menu("MENU");
            var startersMenu = new CompositePattern.Composite.Menu("STARTERS");
            var saladsMenu = new CompositePattern.Composite.Menu("SALADS");
            var mainDishesMenu = new CompositePattern.Composite.Menu("MAIN DISHES");
            var dessertsMenu = new CompositePattern.Composite.Menu("DESSERTS ");
            var beveragesMenu = new CompositePattern.Composite.Menu("BEVERAGES");

            //submenus in main dishes
            var burgersMenu = new CompositePattern.Composite.Menu("Burgers");
            var pizzaMenu = new CompositePattern.Composite.Menu("Pizza");
            var plattersMenu = new CompositePattern.Composite.Menu("Platters");


            //submenu in beverages
            var hotBeveragesMenu = new CompositePattern.Composite.Menu("Hot Beverages");
            var coldBeveragesMenu = new CompositePattern.Composite.Menu("Cold Beverages");

            _menu.Add(startersMenu);
            _menu.Add(mainDishesMenu);
            _menu.Add(dessertsMenu);
            _menu.Add(beveragesMenu);

            mainDishesMenu.Add(burgersMenu);
            mainDishesMenu.Add(pizzaMenu);
            mainDishesMenu.Add(plattersMenu);
            mainDishesMenu.Add(saladsMenu);

            // appetizers
            startersMenu.Add(new CompositePattern.Leaf.MenuItem("Cheese Rolls", 50000, true));
            startersMenu.Add(new CompositePattern.Leaf.MenuItem("Chicken Strips", 60000, false));
            startersMenu.Add(new CompositePattern.Leaf.MenuItem("Nachos", 50000, true));
            startersMenu.Add(new CompositePattern.Leaf.MenuItem("French Fries", 40000, true));
            startersMenu.Add(new CompositePattern.Leaf.MenuItem("Curly Fries", 50000, true));

            // salads
            saladsMenu.Add(new CompositePattern.Leaf.MenuItem("Tabbouleh", 40000, true));
            saladsMenu.Add(new CompositePattern.Leaf.MenuItem("Quinoa", 40000, true));
            saladsMenu.Add(new CompositePattern.Leaf.MenuItem("Chicken Ceaser", 70000, false));

            //main 
            plattersMenu.Add(new CompositePattern.Leaf.MenuItem("Escalope", 120000, false));
            plattersMenu.Add(new CompositePattern.Leaf.MenuItem("Tawouk", 100000, false));
            plattersMenu.Add(new CompositePattern.Leaf.MenuItem("Cordon Bleu", 130000, false));

            //burgers
            burgersMenu.Add(new CompositePattern.Leaf.MenuItem("Chicken Burger", 90000, false));
            burgersMenu.Add(new CompositePattern.Leaf.MenuItem("Hamburger", 90000, false));
            burgersMenu.Add(new CompositePattern.Leaf.MenuItem("Cheese Burger", 90000, false));

            //pizza
            pizzaMenu.Add(new CompositePattern.Leaf.MenuItem("Lebanese Pizza", 100000, false));
            pizzaMenu.Add(new CompositePattern.Leaf.MenuItem("Pepperoni", 120000, false));
            pizzaMenu.Add(new CompositePattern.Leaf.MenuItem("BBQ Chicken", 130000, false));

            //dessert
            dessertsMenu.Add(new CompositePattern.Leaf.MenuItem("Fondant", 40000, true));
            dessertsMenu.Add(new CompositePattern.Leaf.MenuItem("Pain Perdu", 50000, true));
            dessertsMenu.Add(new CompositePattern.Leaf.MenuItem("Apple Pie", 40000, true));

            //hot beverages
            hotBeveragesMenu.Add(new CompositePattern.Leaf.MenuItem("Tea", 15000, true));
            hotBeveragesMenu.Add(new CompositePattern.Leaf.MenuItem("Coffee", 15000, true));
            hotBeveragesMenu.Add(new CompositePattern.Leaf.MenuItem("Hot chocolate", 15000, true));

            //cold bvgs
            coldBeveragesMenu.Add(new CompositePattern.Leaf.MenuItem("Soft Drinks", 15000, true));
            coldBeveragesMenu.Add(new CompositePattern.Leaf.MenuItem("Apple Juice", 15000, true));
            coldBeveragesMenu.Add(new CompositePattern.Leaf.MenuItem("Lemonade", 15000, true));

            beveragesMenu.Add(hotBeveragesMenu);
            beveragesMenu.Add(coldBeveragesMenu);

            restaurant.menus.Add(_menu);
        }



        private void btnStaff_Click(object sender, EventArgs e)
        {
            StaffLogin login = new StaffLogin();
            this.Hide();
            login.Show();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffLogin login = new StaffLogin();
            this.Hide();
            login.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage page = new HomePage();
            page.Show();
        }

        private void customerBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HomePage page = new HomePage();
            page.Show();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Exit",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

   

       
    }
}

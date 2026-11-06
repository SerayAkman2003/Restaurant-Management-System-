using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_777
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this app?", "Confirmation Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation Messsage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginform= new Form1();
                loginform.Show();

                this.Hide();
            }
        }

        private void dashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void shop_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = true;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void inventory_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = true;
            categoriesForm1.Visible = false;
            customersForm1.Visible = false;
        }

        private void categories_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = true;
            customersForm1.Visible = false;
        }

        private void custemers_btn_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            shopForm1.Visible = false;
            inventoryForm1.Visible = false;
            categoriesForm1.Visible = false;
            customersForm1.Visible = true;
        }
    }
}

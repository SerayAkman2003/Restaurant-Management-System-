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
    public partial class customersForm : UserControl
    {
        public customersForm()
        {
            InitializeComponent();
            displayCustomers();

            
            this.VisibleChanged += new EventHandler(customersForm_VisibleChanged);
        }

        public void displayCustomers()
        {
            customersList cData = new customersList();
            List<customersList> listData = cData.customerListData();
            dataGridView1.DataSource = listData;
        }

        private void customersForm_VisibleChanged(object sender, EventArgs e)
        {
          
            if (this.Visible)
            {
                displayCustomers();
            }
        }
    }
}
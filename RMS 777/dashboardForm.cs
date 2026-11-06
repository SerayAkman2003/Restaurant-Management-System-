using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RMS_777
{
    public partial class dashboardForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Seray Akman\Documents\restarantsystem.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";
        public dashboardForm()
        {
            InitializeComponent();
            displayTotalUsers();
            displayTotalProducts();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayTodaysSales();


        }

        public void refreshData()
        {
            displayTotalUsers();
            displayTotalProducts();
            displayTodaysRevenue();
            displayTotalRevenue();
            displayTodaysSales();
        }


        public void displayTodaysSales()
        {
            customersList cData = new customersList();
            List<customersList> listData = cData.todaysSalescustomerListData();

            dataGridView1.DataSource = listData;
        }
        public void displayTotalUsers()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_totalUsers.Text = count.ToString();
                    }
                }
            }
        }


        public void displayTotalProducts()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT COUNT(id) FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        dashboard_totalProducts.Text = count.ToString();
                    }
                }
            }
        }

        public void displayTodaysRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                
                string selectData = "SELECT SUM(TRY_CAST(REPLACE(total, '$', '') AS DECIMAL(10, 2))) FROM orders WHERE date_order = @date";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    
                    cmd.Parameters.AddWithValue("@date", DateTime.Today);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        decimal revenue = Convert.ToDecimal(result);
                        dashboard_todaysRevenue.Text = "$" + revenue.ToString("0.00");
                    }
                    else
                    {
                        dashboard_todaysRevenue.Text = "$0.00";
                    }
                }
            }
        }


        public void displayTotalRevenue()
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                
                string selectData = "SELECT SUM(TRY_CAST(REPLACE(total, '$', '') AS DECIMAL(10, 2))) FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        decimal revenue = Convert.ToDecimal(result);
                        dashboard_totalRevenue.Text = "$" + revenue.ToString("0.00");
                    }
                    else
                    {
                        dashboard_totalRevenue.Text = "$0.00";
                    }
                }
            }
        }

        private void dashboardForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) 
            {
                refreshData(); 
            }
        }

    }
}

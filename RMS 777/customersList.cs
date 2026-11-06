using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RMS_777
{
    internal class customersList
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Seray Akman\Documents\restarantsystem.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";
        public int id { set; get; }
        public string customerId { set; get; }
        public string productsIds { set; get; }
        public string quantities { set; get; }
        public string prices { set; get; }
        public string totalPrice { set; get; }
        public string dateOrder { set; get; }

        public List<customersList> customerListData()
        {
            List<customersList> listData = new List<customersList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM orders";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customersList cData = new customersList();

                        cData.id = (int)reader["id"];
                        cData.customerId = reader["customerId"].ToString();
                        cData.productsIds = reader["productids"].ToString();
                        cData.quantities = reader["quantities"].ToString();
                        cData.prices = reader["prices"].ToString();
                        cData.totalPrice = reader["total"].ToString();
                        cData.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
        public List<customersList> todaysSalescustomerListData()
        {
            List<customersList> listData = new List<customersList>();

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();

                string selectData = "SELECT * FROM orders WHERE date_order = @date";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    DateTime today = DateTime.Now;
                    String getToday = today.ToString("yyyy-MM-dd");

                    cmd.Parameters.AddWithValue("@date", getToday);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        customersList cData = new customersList();

                        cData.id = (int)reader["id"];
                        cData.customerId = reader["customerId"].ToString();
                        cData.productsIds = reader["productids"].ToString();
                        cData.quantities = reader["quantities"].ToString();
                        cData.prices = reader["prices"].ToString();
                        cData.totalPrice = reader["total"].ToString();
                        cData.dateOrder = ((DateTime)reader["date_order"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);
                    }
                }
            }

            return listData;
        }

    }
}

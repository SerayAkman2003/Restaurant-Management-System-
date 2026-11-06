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
using System.IO;
using System.Globalization;

namespace RMS_777
{
    public partial class shopForm : UserControl
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Seray Akman\Documents\restarantsystem.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True";

        public shopForm()
        {
            InitializeComponent();
            loadProducts();
        }

        public void carditems(int id, string productname, string stock, string price, Image image, string productid, string category, String quantity)
        {
            var card = new cardProduct()
            {
                id = id,
                productName = productname,
                productStock = stock,
                productPrice = price,
                productImage = image,
                productId = productid,
                category = category,
                productQuantity = quantity,
            };

            flowLayoutPanel1.Controls.Add(card);
            card.selectCard += (q, w) =>
            {
                var selectedCard = (cardProduct)q;
                bool flag = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["id"].Value != null && (int)row.Cells["id"].Value == selectedCard.id)
                    {
                        decimal getPrice = decimal.Parse(selectedCard.productPrice.Replace("$", ""), CultureInfo.InvariantCulture);
                        int getQuantity = Convert.ToInt32(selectedCard.productQuantity);

                        row.Cells["Price"].Value = (getPrice * getQuantity).ToString("F2", CultureInfo.InvariantCulture);
                        row.Cells["QTY"].Value = selectedCard.productQuantity;
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    decimal getPrice = decimal.Parse(selectedCard.productPrice.Replace("$", ""), CultureInfo.InvariantCulture);
                    int getQuantity = Convert.ToInt32(selectedCard.productQuantity);
                    dataGridView1.Rows.Add(selectedCard.id, selectedCard.productName, getQuantity, (getPrice * getQuantity).ToString("F2", CultureInfo.InvariantCulture));
                }
                updateTotalprice();
            };
        }

        private void updateTotalprice()
        {
            decimal totalprice = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    totalprice += decimal.Parse(row.Cells["Price"].Value.ToString(), CultureInfo.InvariantCulture);
                }
            }

            shop_total.Text = $"${totalprice.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void loadProducts()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();
                    string selectData = "SELECT * FROM products";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        flowLayoutPanel1.Controls.Clear();

                        foreach (DataRow row in table.Rows)
                        {
                            int id = row["id"] != DBNull.Value ? (int)row["id"] : 0;
                            string productname = row["productname"] != DBNull.Value ? row["productname"].ToString() : "N/A";
                            string stock = row["stock"] != DBNull.Value ? row["stock"].ToString() : "0";
                            string price = row["price"] != DBNull.Value ? row["price"].ToString() : "0.00";
                            string productid = row["productid"] != DBNull.Value ? row["productid"].ToString() : "N/A";
                            string category = row["category"] != DBNull.Value ? row["category"].ToString() : "N/A";

                            Image image = null;
                            if (row["image"] != DBNull.Value)
                            {
                                string imagePath = row["image"].ToString();
                                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                                {
                                    try { image = Image.FromFile(imagePath); }
                                    catch { image = null; }
                                }
                            }

                            carditems(id, productname, stock, $"${price}", image, productid, category, "");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void shop_change_Enter(object sender, EventArgs e)
        {
        }

        private void shop_change_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    decimal getTotal = decimal.Parse(shop_total.Text.Replace("$", ""), CultureInfo.InvariantCulture);
                    decimal getChange = decimal.Parse(shop_change.Text, CultureInfo.CurrentCulture);

                    if (getTotal > getChange)
                    {
                        MessageBox.Show("Invalid: Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        check = false;
                    }
                    else
                    {
                        check = true;
                        shop_amount.Text = $"${(getChange - getTotal).ToString("F2", CultureInfo.InvariantCulture)}";
                    }
                    e.SuppressKeyPress = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool check = false;

        private void shop_placeOrderBtn_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("Invalid: Insufficient Amount", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to proceed?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connection))
                    {
                        connect.Open();
                        int count = 1;
                        using (SqlCommand cData = new SqlCommand("SELECT COUNT(*) FROM orders", connect))
                        {
                            count = Convert.ToInt32(cData.ExecuteScalar()) + 1;
                        }

                        List<string> productIds = new List<string>();
                        List<string> quantities = new List<string>();
                        List<string> prices = new List<string>();

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells["id"].Value != null)
                            {
                                productIds.Add(row.Cells["id"].Value.ToString());
                                quantities.Add(row.Cells["QTY"].Value.ToString());
                                prices.Add(row.Cells["Price"].Value.ToString());
                            }
                        }

                        decimal totalAmount = decimal.Parse(shop_total.Text.Replace("$", ""), CultureInfo.InvariantCulture);

                        string insertData = "INSERT INTO orders (customerId, productids, quantities, prices, total, date_order) VALUES(@cid, @pid, @qty, @price, @total, @date)";
                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@cid", $"CID-{count}");
                            cmd.Parameters.AddWithValue("@pid", string.Join(",", productIds));
                            cmd.Parameters.AddWithValue("@qty", string.Join(",", quantities));
                            cmd.Parameters.AddWithValue("@price", string.Join(",", prices));
                            cmd.Parameters.AddWithValue("@total", totalAmount);
                            cmd.Parameters.AddWithValue("@date", DateTime.Now);

                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                for (int q = 0; q < productIds.Count; q++)
                                {
                                    int currentStock = 0;
                                    using (SqlCommand getSD = new SqlCommand("SELECT stock FROM products WHERE id = @id", connect))
                                    {
                                        getSD.Parameters.AddWithValue("@id", productIds[q]);
                                        currentStock = Convert.ToInt32(getSD.ExecuteScalar());
                                    }

                                    int newStock = currentStock - Convert.ToInt32(quantities[q]);
                                    using (SqlCommand updateCmd = new SqlCommand("UPDATE products SET stock = @qty WHERE id = @id", connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@qty", newStock);
                                        updateCmd.Parameters.AddWithValue("@id", productIds[q]);
                                        updateCmd.ExecuteNonQuery();
                                    }
                                }
                                MessageBox.Show("Order placed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                              
                            }
                        }
                    }
                }
            }

        }

        private int rowIndex = 0;
        private void shop_receiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(printDocument1_BeginPrint);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);
            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            e.Graphics.DrawString("Fairy Mama's Restaurant", headerFont, Brushes.Black, e.MarginBounds.Left + (dataGridView1.Columns.Count / 2) * colWidth, margin + headerMargin, alignCenter);
            count++;
            y += tableMargin;

            string[] header = { "PID", "ProdName", "Qty", "Price" };
            for (int q = 0; q < header.Length; q++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[q], bold, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
            }
            count++;

            while (rowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                if (row.Cells[0].Value == null) break;

                for (int q = 0; q < dataGridView1.Columns.Count; q++)
                {
                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(row.Cells[q].Value.ToString(), font, Brushes.Black, e.MarginBounds.Left + q * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("----------------------------", labelFont).Width;
            y = e.MarginBounds.Bottom - 150;
            e.Graphics.DrawString($"Total Price: \t{shop_total.Text}\nAmount:\t${shop_change.Text}\n\t\t----------\nChange:\t{shop_amount.Text}", labelFont, Brushes.Black, labelX, y);
            e.Graphics.DrawString(DateTime.Now.ToString(), font, Brushes.Black, labelX, y + 100);
        }

        // Shop sayfası her ön plana geldiğinde ürünleri ve stokları veritabanından tazeleyecektir.
        private void shopForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                loadProducts();
            }
        }
    }
}
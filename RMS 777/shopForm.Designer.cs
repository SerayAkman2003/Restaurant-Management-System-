namespace RMS_777
{
    partial class shopForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shopForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop_receiptBtn = new System.Windows.Forms.Button();
            this.shop_placeOrderBtn = new System.Windows.Forms.Button();
            this.shop_amount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shop_change = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shop_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(24, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 709);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(642, 661);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.shop_receiptBtn);
            this.panel2.Controls.Add(this.shop_placeOrderBtn);
            this.panel2.Controls.Add(this.shop_amount);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.shop_change);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.shop_total);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(728, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 709);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prodName,
            this.QTY,
            this.Price});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 372);
            this.dataGridView1.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // prodName
            // 
            this.prodName.HeaderText = "prodName";
            this.prodName.MinimumWidth = 6;
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // shop_receiptBtn
            // 
            this.shop_receiptBtn.BackColor = System.Drawing.Color.Thistle;
            this.shop_receiptBtn.FlatAppearance.BorderSize = 0;
            this.shop_receiptBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.shop_receiptBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.shop_receiptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_receiptBtn.Location = new System.Drawing.Point(23, 642);
            this.shop_receiptBtn.Name = "shop_receiptBtn";
            this.shop_receiptBtn.Size = new System.Drawing.Size(304, 45);
            this.shop_receiptBtn.TabIndex = 8;
            this.shop_receiptBtn.Text = "RECEIPT";
            this.shop_receiptBtn.UseVisualStyleBackColor = false;
            this.shop_receiptBtn.Click += new System.EventHandler(this.shop_receiptBtn_Click);
            // 
            // shop_placeOrderBtn
            // 
            this.shop_placeOrderBtn.BackColor = System.Drawing.Color.Thistle;
            this.shop_placeOrderBtn.FlatAppearance.BorderSize = 0;
            this.shop_placeOrderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.shop_placeOrderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.shop_placeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_placeOrderBtn.Location = new System.Drawing.Point(23, 571);
            this.shop_placeOrderBtn.Name = "shop_placeOrderBtn";
            this.shop_placeOrderBtn.Size = new System.Drawing.Size(304, 45);
            this.shop_placeOrderBtn.TabIndex = 7;
            this.shop_placeOrderBtn.Text = "PLACE ORDER";
            this.shop_placeOrderBtn.UseVisualStyleBackColor = false;
            this.shop_placeOrderBtn.Click += new System.EventHandler(this.shop_placeOrderBtn_Click);
            // 
            // shop_amount
            // 
            this.shop_amount.AutoSize = true;
            this.shop_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shop_amount.Location = new System.Drawing.Point(211, 516);
            this.shop_amount.Name = "shop_amount";
            this.shop_amount.Size = new System.Drawing.Size(40, 20);
            this.shop_amount.TabIndex = 6;
            this.shop_amount.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(133, 516);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Amount";
            // 
            // shop_change
            // 
            this.shop_change.Location = new System.Drawing.Point(211, 481);
            this.shop_change.Name = "shop_change";
            this.shop_change.Size = new System.Drawing.Size(116, 22);
            this.shop_change.TabIndex = 4;
            this.shop_change.Enter += new System.EventHandler(this.shop_change_Enter);
            this.shop_change.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shop_change_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(133, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Change:";
            // 
            // shop_total
            // 
            this.shop_total.AutoSize = true;
            this.shop_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shop_total.Location = new System.Drawing.Point(211, 448);
            this.shop_total.Name = "shop_total";
            this.shop_total.Size = new System.Drawing.Size(40, 20);
            this.shop_total.TabIndex = 2;
            this.shop_total.Text = "0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total($):";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // shopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "shopForm";
            this.Size = new System.Drawing.Size(1100, 766);
            this.VisibleChanged += new System.EventHandler(this.shopForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button shop_placeOrderBtn;
        private System.Windows.Forms.Label shop_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox shop_change;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label shop_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shop_receiptBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

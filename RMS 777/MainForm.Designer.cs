namespace RMS_777
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.custemers_btn = new System.Windows.Forms.Button();
            this.categories_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.shop_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customersForm1 = new RMS_777.customersForm();
            this.categoriesForm1 = new RMS_777.CategoriesForm();
            this.inventoryForm1 = new RMS_777.inventoryForm();
            this.shopForm1 = new RMS_777.shopForm();
            this.dashboardForm1 = new RMS_777.dashboardForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 35);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Restaurant Management System";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.LemonChiffon;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(1295, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(50, 23);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.custemers_btn);
            this.panel2.Controls.Add(this.categories_btn);
            this.panel2.Controls.Add(this.inventory_btn);
            this.panel2.Controls.Add(this.shop_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 766);
            this.panel2.TabIndex = 12;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Plum;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Location = new System.Drawing.Point(12, 662);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(227, 30);
            this.logout_btn.TabIndex = 7;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button6_Click);
            // 
            // custemers_btn
            // 
            this.custemers_btn.BackColor = System.Drawing.Color.Plum;
            this.custemers_btn.FlatAppearance.BorderSize = 0;
            this.custemers_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.custemers_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.custemers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custemers_btn.Location = new System.Drawing.Point(12, 427);
            this.custemers_btn.Name = "custemers_btn";
            this.custemers_btn.Size = new System.Drawing.Size(227, 30);
            this.custemers_btn.TabIndex = 6;
            this.custemers_btn.Text = "Customers";
            this.custemers_btn.UseVisualStyleBackColor = false;
            this.custemers_btn.Click += new System.EventHandler(this.custemers_btn_Click);
            // 
            // categories_btn
            // 
            this.categories_btn.BackColor = System.Drawing.Color.Plum;
            this.categories_btn.FlatAppearance.BorderSize = 0;
            this.categories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.categories_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.categories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories_btn.Location = new System.Drawing.Point(12, 374);
            this.categories_btn.Name = "categories_btn";
            this.categories_btn.Size = new System.Drawing.Size(227, 30);
            this.categories_btn.TabIndex = 5;
            this.categories_btn.Text = "Categories";
            this.categories_btn.UseVisualStyleBackColor = false;
            this.categories_btn.Click += new System.EventHandler(this.categories_btn_Click);
            // 
            // inventory_btn
            // 
            this.inventory_btn.BackColor = System.Drawing.Color.Plum;
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.inventory_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.Location = new System.Drawing.Point(12, 322);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(227, 30);
            this.inventory_btn.TabIndex = 4;
            this.inventory_btn.Text = "Inventory";
            this.inventory_btn.UseVisualStyleBackColor = false;
            this.inventory_btn.Click += new System.EventHandler(this.inventory_btn_Click);
            // 
            // shop_btn
            // 
            this.shop_btn.BackColor = System.Drawing.Color.Plum;
            this.shop_btn.FlatAppearance.BorderSize = 0;
            this.shop_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.shop_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.shop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shop_btn.Location = new System.Drawing.Point(12, 270);
            this.shop_btn.Name = "shop_btn";
            this.shop_btn.Size = new System.Drawing.Size(227, 30);
            this.shop_btn.TabIndex = 3;
            this.shop_btn.Text = "Shop";
            this.shop_btn.UseVisualStyleBackColor = false;
            this.shop_btn.Click += new System.EventHandler(this.shop_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.Plum;
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon;
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LemonChiffon;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Location = new System.Drawing.Point(12, 218);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(227, 30);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome, Admin!";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customersForm1);
            this.panel3.Controls.Add(this.categoriesForm1);
            this.panel3.Controls.Add(this.inventoryForm1);
            this.panel3.Controls.Add(this.shopForm1);
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(257, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 766);
            this.panel3.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RMS_777.Properties.Resources.icons8_user_100;
            this.pictureBox1.Location = new System.Drawing.Point(76, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // customersForm1
            // 
            this.customersForm1.Location = new System.Drawing.Point(-3, 0);
            this.customersForm1.Name = "customersForm1";
            this.customersForm1.Size = new System.Drawing.Size(1100, 766);
            this.customersForm1.TabIndex = 4;
            // 
            // categoriesForm1
            // 
            this.categoriesForm1.Location = new System.Drawing.Point(-3, 0);
            this.categoriesForm1.Name = "categoriesForm1";
            this.categoriesForm1.Size = new System.Drawing.Size(1100, 766);
            this.categoriesForm1.TabIndex = 3;
            // 
            // inventoryForm1
            // 
            this.inventoryForm1.Location = new System.Drawing.Point(-3, 0);
            this.inventoryForm1.Name = "inventoryForm1";
            this.inventoryForm1.Size = new System.Drawing.Size(1100, 766);
            this.inventoryForm1.TabIndex = 2;
            // 
            // shopForm1
            // 
            this.shopForm1.Location = new System.Drawing.Point(-3, 0);
            this.shopForm1.Name = "shopForm1";
            this.shopForm1.Size = new System.Drawing.Size(1100, 766);
            this.shopForm1.TabIndex = 1;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(-3, -3);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(1100, 766);
            this.dashboardForm1.TabIndex = 0;
            this.dashboardForm1.Load += new System.EventHandler(this.dashboardForm1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 801);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button categories_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button shop_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button custemers_btn;
        private System.Windows.Forms.Panel panel3;
        private dashboardForm dashboardForm1;
        private shopForm shopForm1;
        private inventoryForm inventoryForm1;
        private CategoriesForm categoriesForm1;
        private customersForm customersForm1;
    }
}
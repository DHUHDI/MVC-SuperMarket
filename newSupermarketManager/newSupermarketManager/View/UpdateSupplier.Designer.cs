namespace newSupermarketManager.View
{
    partial class UpdateSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSupplier));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1_Cost = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5_Address = new System.Windows.Forms.TextBox();
            this.textBox4_Phone = new System.Windows.Forms.TextBox();
            this.textBox3_Name = new System.Windows.Forms.TextBox();
            this.textBox2_Shop = new System.Windows.Forms.TextBox();
            this.textBox1_GHSID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.comboBox1_Cost);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox5_Address);
            this.groupBox1.Controls.Add(this.textBox4_Phone);
            this.groupBox1.Controls.Add(this.textBox3_Name);
            this.groupBox1.Controls.Add(this.textBox2_Shop);
            this.groupBox1.Controls.Add(this.textBox1_GHSID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(1215, 1006);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "修改供货商信息";
            // 
            // comboBox1_Cost
            // 
            this.comboBox1_Cost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_Cost.FormattingEnabled = true;
            this.comboBox1_Cost.Items.AddRange(new object[] {
            "支付宝",
            "银行卡",
            "微信支付"});
            this.comboBox1_Cost.Location = new System.Drawing.Point(898, 568);
            this.comboBox1_Cost.Margin = new System.Windows.Forms.Padding(8);
            this.comboBox1_Cost.Name = "comboBox1_Cost";
            this.comboBox1_Cost.Size = new System.Drawing.Size(244, 38);
            this.comboBox1_Cost.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(738, 780);
            this.button2.Margin = new System.Windows.Forms.Padding(8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 58);
            this.button2.TabIndex = 22;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(325, 780);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 58);
            this.button1.TabIndex = 21;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5_Address
            // 
            this.textBox5_Address.Location = new System.Drawing.Point(898, 335);
            this.textBox5_Address.Margin = new System.Windows.Forms.Padding(8);
            this.textBox5_Address.MaxLength = 20;
            this.textBox5_Address.Name = "textBox5_Address";
            this.textBox5_Address.Size = new System.Drawing.Size(244, 42);
            this.textBox5_Address.TabIndex = 16;
            // 
            // textBox4_Phone
            // 
            this.textBox4_Phone.Location = new System.Drawing.Point(898, 112);
            this.textBox4_Phone.Margin = new System.Windows.Forms.Padding(8);
            this.textBox4_Phone.MaxLength = 11;
            this.textBox4_Phone.Name = "textBox4_Phone";
            this.textBox4_Phone.Size = new System.Drawing.Size(244, 42);
            this.textBox4_Phone.TabIndex = 17;
            // 
            // textBox3_Name
            // 
            this.textBox3_Name.Location = new System.Drawing.Point(285, 568);
            this.textBox3_Name.Margin = new System.Windows.Forms.Padding(8);
            this.textBox3_Name.MaxLength = 10;
            this.textBox3_Name.Name = "textBox3_Name";
            this.textBox3_Name.Size = new System.Drawing.Size(244, 42);
            this.textBox3_Name.TabIndex = 18;
            // 
            // textBox2_Shop
            // 
            this.textBox2_Shop.Location = new System.Drawing.Point(285, 335);
            this.textBox2_Shop.Margin = new System.Windows.Forms.Padding(8);
            this.textBox2_Shop.MaxLength = 15;
            this.textBox2_Shop.Name = "textBox2_Shop";
            this.textBox2_Shop.Size = new System.Drawing.Size(244, 42);
            this.textBox2_Shop.TabIndex = 19;
            // 
            // textBox1_GHSID
            // 
            this.textBox1_GHSID.Location = new System.Drawing.Point(285, 112);
            this.textBox1_GHSID.Margin = new System.Windows.Forms.Padding(8);
            this.textBox1_GHSID.MaxLength = 5;
            this.textBox1_GHSID.Name = "textBox1_GHSID";
            this.textBox1_GHSID.Size = new System.Drawing.Size(244, 42);
            this.textBox1_GHSID.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "地址：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(708, 575);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "结算方式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(102, 575);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "联系人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "商家名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "供货商ID：";
            // 
            // UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 1006);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateSupplier";
            this.Text = "供货商信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox comboBox1_Cost;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox5_Address;
        public System.Windows.Forms.TextBox textBox4_Phone;
        public System.Windows.Forms.TextBox textBox3_Name;
        public System.Windows.Forms.TextBox textBox2_Shop;
        public System.Windows.Forms.TextBox textBox1_GHSID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
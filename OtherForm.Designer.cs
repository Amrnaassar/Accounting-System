
namespace AccountingApp
{
    partial class OtherForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cancel = new AccountingApp.btnDesign();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invoiceNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nNetProfit = new System.Windows.Forms.Label();
            this.ntPurch = new System.Windows.Forms.Label();
            this.ntSales = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.TextBox();
            this.dtpN = new System.Windows.Forms.DateTimePicker();
            this.apply = new AccountingApp.btnDesign();
            this.invoicetype = new System.Windows.Forms.GroupBox();
            this.rbpurchases = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.invoicetype.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(467, 25);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 40);
            this.Cancel.TabIndex = 111;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label5.Location = new System.Drawing.Point(16, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 110;
            this.label5.Text = "Invoice No";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel4.Location = new System.Drawing.Point(131, 63);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 2);
            this.panel4.TabIndex = 109;
            // 
            // cancelNo
            // 
            this.cancelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cancelNo.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.cancelNo.Location = new System.Drawing.Point(131, 28);
            this.cancelNo.Multiline = true;
            this.cancelNo.Name = "cancelNo";
            this.cancelNo.Size = new System.Drawing.Size(308, 34);
            this.cancelNo.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(140, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(78, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "Search Invoice by";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(684, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(686, 600);
            this.dgv.TabIndex = 104;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(112, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "Invoice No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(17, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 2);
            this.panel2.TabIndex = 102;
            // 
            // CustName
            // 
            this.CustName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.CustName.Location = new System.Drawing.Point(17, 451);
            this.CustName.Multiline = true;
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(308, 35);
            this.CustName.TabIndex = 101;
            this.CustName.TextChanged += new System.EventHandler(this.CustName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label4.Location = new System.Drawing.Point(92, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 100;
            this.label4.Text = "Customer Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.Location = new System.Drawing.Point(17, 370);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 2);
            this.panel3.TabIndex = 99;
            // 
            // invoiceNo
            // 
            this.invoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceNo.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.invoiceNo.Location = new System.Drawing.Point(17, 335);
            this.invoiceNo.Multiline = true;
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Size = new System.Drawing.Size(308, 34);
            this.invoiceNo.TabIndex = 98;
            this.invoiceNo.TextChanged += new System.EventHandler(this.invoiceNo_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nNetProfit);
            this.groupBox2.Controls.Add(this.ntPurch);
            this.groupBox2.Controls.Add(this.ntSales);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.groupBox2.Location = new System.Drawing.Point(367, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 338);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoices";
            // 
            // nNetProfit
            // 
            this.nNetProfit.AutoSize = true;
            this.nNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.nNetProfit.ForeColor = System.Drawing.Color.Red;
            this.nNetProfit.Location = new System.Drawing.Point(24, 280);
            this.nNetProfit.Name = "nNetProfit";
            this.nNetProfit.Size = new System.Drawing.Size(39, 25);
            this.nNetProfit.TabIndex = 100;
            this.nNetProfit.Text = "0.0";
            // 
            // ntPurch
            // 
            this.ntPurch.AutoSize = true;
            this.ntPurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.ntPurch.ForeColor = System.Drawing.Color.Red;
            this.ntPurch.Location = new System.Drawing.Point(24, 176);
            this.ntPurch.Name = "ntPurch";
            this.ntPurch.Size = new System.Drawing.Size(39, 25);
            this.ntPurch.TabIndex = 99;
            this.ntPurch.Text = "0.0";
            // 
            // ntSales
            // 
            this.ntSales.AutoSize = true;
            this.ntSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.ntSales.ForeColor = System.Drawing.Color.Red;
            this.ntSales.Location = new System.Drawing.Point(24, 90);
            this.ntSales.Name = "ntSales";
            this.ntSales.Size = new System.Drawing.Size(39, 25);
            this.ntSales.TabIndex = 98;
            this.ntSales.Text = "0.0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label12.Location = new System.Drawing.Point(25, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 94;
            this.label12.Text = "Total  OF Salse";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label13.Location = new System.Drawing.Point(25, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 20);
            this.label13.TabIndex = 96;
            this.label13.Text = "Net Profit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label14.Location = new System.Drawing.Point(25, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 20);
            this.label14.TabIndex = 95;
            this.label14.Text = "Total  OF Purchases";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(17, 577);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 2);
            this.panel1.TabIndex = 114;
            // 
            // Date
            // 
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.Date.Location = new System.Drawing.Point(17, 541);
            this.Date.Multiline = true;
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(308, 35);
            this.Date.TabIndex = 113;
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // dtpN
            // 
            this.dtpN.CustomFormat = "  MM-yyyy";
            this.dtpN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpN.Location = new System.Drawing.Point(367, 165);
            this.dtpN.Name = "dtpN";
            this.dtpN.Size = new System.Drawing.Size(151, 24);
            this.dtpN.TabIndex = 115;
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.apply.ForeColor = System.Drawing.Color.White;
            this.apply.Location = new System.Drawing.Point(524, 157);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(93, 40);
            this.apply.TabIndex = 116;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // invoicetype
            // 
            this.invoicetype.Controls.Add(this.rbpurchases);
            this.invoicetype.Controls.Add(this.rbSales);
            this.invoicetype.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.invoicetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.invoicetype.Location = new System.Drawing.Point(61, 133);
            this.invoicetype.Name = "invoicetype";
            this.invoicetype.Size = new System.Drawing.Size(200, 105);
            this.invoicetype.TabIndex = 117;
            this.invoicetype.TabStop = false;
            this.invoicetype.Text = "Invoice Type";
            // 
            // rbpurchases
            // 
            this.rbpurchases.AutoSize = true;
            this.rbpurchases.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbpurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.rbpurchases.Location = new System.Drawing.Point(18, 34);
            this.rbpurchases.Name = "rbpurchases";
            this.rbpurchases.Size = new System.Drawing.Size(95, 24);
            this.rbpurchases.TabIndex = 60;
            this.rbpurchases.Text = "Purchases";
            this.rbpurchases.UseVisualStyleBackColor = true;
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Checked = true;
            this.rbSales.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.rbSales.Location = new System.Drawing.Point(18, 65);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(61, 24);
            this.rbSales.TabIndex = 61;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales";
            this.rbSales.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(396, 97);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 118;
            // 
            // OtherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 600);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.invoicetype);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.dtpN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cancelNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.invoiceNo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OtherForm";
            this.Text = "OtherForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.invoicetype.ResumeLayout(false);
            this.invoicetype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private btnDesign Cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cancelNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox invoiceNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nNetProfit;
        private System.Windows.Forms.Label ntPurch;
        private System.Windows.Forms.Label ntSales;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.DateTimePicker dtpN;
        private btnDesign apply;
        private System.Windows.Forms.GroupBox invoicetype;
        private System.Windows.Forms.RadioButton rbpurchases;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

namespace AccountingApp
{
    partial class OldInvoiceForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.invoiceNo = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbpurchases = new System.Windows.Forms.RadioButton();
            this.invoicetype = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cancelNo = new System.Windows.Forms.TextBox();
            this.Cancel = new AccountingApp.btnDesign();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.invoicetype.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(131, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 74;
            this.label3.Text = "Invoice No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(36, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 2);
            this.panel2.TabIndex = 73;
            // 
            // CustName
            // 
            this.CustName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.CustName.Location = new System.Drawing.Point(36, 395);
            this.CustName.Multiline = true;
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(308, 35);
            this.CustName.TabIndex = 72;
            this.CustName.TextChanged += new System.EventHandler(this.CustName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label4.Location = new System.Drawing.Point(111, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 71;
            this.label4.Text = "Customer Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.Location = new System.Drawing.Point(36, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 2);
            this.panel3.TabIndex = 70;
            // 
            // invoiceNo
            // 
            this.invoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invoiceNo.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.invoiceNo.Location = new System.Drawing.Point(36, 279);
            this.invoiceNo.Multiline = true;
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Size = new System.Drawing.Size(308, 34);
            this.invoiceNo.TabIndex = 69;
            this.invoiceNo.TextChanged += new System.EventHandler(this.invoiceNo_TextChanged);
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
            this.dgv.TabIndex = 87;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(97, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "Search Invoice by";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(159, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 91;
            this.label2.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(36, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 2);
            this.panel1.TabIndex = 90;
            // 
            // Date
            // 
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.Date.Location = new System.Drawing.Point(36, 507);
            this.Date.Multiline = true;
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(308, 35);
            this.Date.TabIndex = 89;
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(102, 556);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 92;
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Checked = true;
            this.rbSales.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.rbSales.Location = new System.Drawing.Point(191, 34);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(61, 24);
            this.rbSales.TabIndex = 61;
            this.rbSales.TabStop = true;
            this.rbSales.Text = "Sales";
            this.rbSales.UseVisualStyleBackColor = true;
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
            // invoicetype
            // 
            this.invoicetype.Controls.Add(this.rbpurchases);
            this.invoicetype.Controls.Add(this.rbSales);
            this.invoicetype.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.invoicetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.invoicetype.Location = new System.Drawing.Point(68, 12);
            this.invoicetype.Name = "invoicetype";
            this.invoicetype.Size = new System.Drawing.Size(304, 84);
            this.invoicetype.TabIndex = 93;
            this.invoicetype.TabStop = false;
            this.invoicetype.Text = "Invoice Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 24);
            this.label5.TabIndex = 96;
            this.label5.Text = "Invoice No";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel4.Location = new System.Drawing.Point(135, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 2);
            this.panel4.TabIndex = 95;
            // 
            // cancelNo
            // 
            this.cancelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cancelNo.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.cancelNo.Location = new System.Drawing.Point(135, 124);
            this.cancelNo.Multiline = true;
            this.cancelNo.Name = "cancelNo";
            this.cancelNo.Size = new System.Drawing.Size(308, 34);
            this.cancelNo.TabIndex = 94;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(471, 121);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(150, 40);
            this.Cancel.TabIndex = 97;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OldInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 600);
            this.ControlBox = false;
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cancelNo);
            this.Controls.Add(this.invoicetype);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Date);
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
            this.Name = "OldInvoiceForm";
            this.Text = "OldInvoiceForm";
            this.Load += new System.EventHandler(this.OldInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.invoicetype.ResumeLayout(false);
            this.invoicetype.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox invoiceNo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbpurchases;
        private System.Windows.Forms.GroupBox invoicetype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox cancelNo;
        private btnDesign Cancel;
    }
}
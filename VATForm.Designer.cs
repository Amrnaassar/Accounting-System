
namespace AccountingApp
{
    partial class VATForm
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnAdditem = new AccountingApp.btnDesign();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.invoicetype = new System.Windows.Forms.GroupBox();
            this.vTotal = new System.Windows.Forms.Label();
            this.vPurch = new System.Windows.Forms.Label();
            this.vSale = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NetProfit = new System.Windows.Forms.Label();
            this.tPurch = new System.Windows.Forms.Label();
            this.tSales = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nNetProfit = new System.Windows.Forms.Label();
            this.ntPurch = new System.Windows.Forms.Label();
            this.ntSales = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.invoicetype.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "  dd-MM-yyyy";
            this.dtpFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(145, 64);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(265, 28);
            this.dtpFrom.TabIndex = 89;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "  dd-MM-yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(544, 59);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(265, 28);
            this.dtpTo.TabIndex = 90;
            // 
            // btnAdditem
            // 
            this.btnAdditem.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdditem.FlatAppearance.BorderSize = 0;
            this.btnAdditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdditem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdditem.ForeColor = System.Drawing.Color.White;
            this.btnAdditem.Location = new System.Drawing.Point(959, 39);
            this.btnAdditem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(200, 49);
            this.btnAdditem.TabIndex = 91;
            this.btnAdditem.Text = "Done";
            this.btnAdditem.UseVisualStyleBackColor = false;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 92;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(460, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 26);
            this.label1.TabIndex = 93;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 94;
            this.label2.Text = "Total VAT OF Salse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label4.Location = new System.Drawing.Point(33, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 26);
            this.label4.TabIndex = 95;
            this.label4.Text = "Total VAT OF Purchases";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label5.Location = new System.Drawing.Point(33, 279);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 96;
            this.label5.Text = "Total VAT ";
            // 
            // invoicetype
            // 
            this.invoicetype.Controls.Add(this.vTotal);
            this.invoicetype.Controls.Add(this.vPurch);
            this.invoicetype.Controls.Add(this.vSale);
            this.invoicetype.Controls.Add(this.label2);
            this.invoicetype.Controls.Add(this.label5);
            this.invoicetype.Controls.Add(this.label4);
            this.invoicetype.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.invoicetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.invoicetype.Location = new System.Drawing.Point(145, 165);
            this.invoicetype.Margin = new System.Windows.Forms.Padding(4);
            this.invoicetype.Name = "invoicetype";
            this.invoicetype.Padding = new System.Windows.Forms.Padding(4);
            this.invoicetype.Size = new System.Drawing.Size(367, 416);
            this.invoicetype.TabIndex = 97;
            this.invoicetype.TabStop = false;
            this.invoicetype.Text = "VAT Management";
            // 
            // vTotal
            // 
            this.vTotal.AutoSize = true;
            this.vTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.vTotal.ForeColor = System.Drawing.Color.Red;
            this.vTotal.Location = new System.Drawing.Point(33, 345);
            this.vTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vTotal.Name = "vTotal";
            this.vTotal.Size = new System.Drawing.Size(48, 29);
            this.vTotal.TabIndex = 99;
            this.vTotal.Text = "0.0";
            // 
            // vPurch
            // 
            this.vPurch.AutoSize = true;
            this.vPurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.vPurch.ForeColor = System.Drawing.Color.Red;
            this.vPurch.Location = new System.Drawing.Point(33, 217);
            this.vPurch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vPurch.Name = "vPurch";
            this.vPurch.Size = new System.Drawing.Size(48, 29);
            this.vPurch.TabIndex = 98;
            this.vPurch.Text = "0.0";
            // 
            // vSale
            // 
            this.vSale.AutoSize = true;
            this.vSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.vSale.ForeColor = System.Drawing.Color.Red;
            this.vSale.Location = new System.Drawing.Point(33, 111);
            this.vSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vSale.Name = "vSale";
            this.vSale.Size = new System.Drawing.Size(48, 29);
            this.vSale.TabIndex = 97;
            this.vSale.Text = "0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NetProfit);
            this.groupBox1.Controls.Add(this.tPurch);
            this.groupBox1.Controls.Add(this.tSales);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.groupBox1.Location = new System.Drawing.Point(1191, 165);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(367, 416);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total invoices";
            this.groupBox1.Visible = false;
            // 
            // NetProfit
            // 
            this.NetProfit.AutoSize = true;
            this.NetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.NetProfit.ForeColor = System.Drawing.Color.Red;
            this.NetProfit.Location = new System.Drawing.Point(32, 345);
            this.NetProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NetProfit.Name = "NetProfit";
            this.NetProfit.Size = new System.Drawing.Size(48, 29);
            this.NetProfit.TabIndex = 100;
            this.NetProfit.Text = "0.0";
            // 
            // tPurch
            // 
            this.tPurch.AutoSize = true;
            this.tPurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.tPurch.ForeColor = System.Drawing.Color.Red;
            this.tPurch.Location = new System.Drawing.Point(32, 217);
            this.tPurch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tPurch.Name = "tPurch";
            this.tPurch.Size = new System.Drawing.Size(48, 29);
            this.tPurch.TabIndex = 99;
            this.tPurch.Text = "0.0";
            // 
            // tSales
            // 
            this.tSales.AutoSize = true;
            this.tSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.tSales.ForeColor = System.Drawing.Color.Red;
            this.tSales.Location = new System.Drawing.Point(32, 111);
            this.tSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tSales.Name = "tSales";
            this.tSales.Size = new System.Drawing.Size(48, 29);
            this.tSales.TabIndex = 98;
            this.tSales.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label6.Location = new System.Drawing.Point(33, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 26);
            this.label6.TabIndex = 94;
            this.label6.Text = "Total  OF Salse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label7.Location = new System.Drawing.Point(33, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 96;
            this.label7.Text = "Net Profit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label8.Location = new System.Drawing.Point(33, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 26);
            this.label8.TabIndex = 95;
            this.label8.Text = "Total  OF Purchases";
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
            this.groupBox2.Location = new System.Drawing.Point(668, 165);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(367, 416);
            this.groupBox2.TabIndex = 99;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Normal invoices";
            // 
            // nNetProfit
            // 
            this.nNetProfit.AutoSize = true;
            this.nNetProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.nNetProfit.ForeColor = System.Drawing.Color.Red;
            this.nNetProfit.Location = new System.Drawing.Point(32, 345);
            this.nNetProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nNetProfit.Name = "nNetProfit";
            this.nNetProfit.Size = new System.Drawing.Size(48, 29);
            this.nNetProfit.TabIndex = 100;
            this.nNetProfit.Text = "0.0";
            this.nNetProfit.Click += new System.EventHandler(this.label9_Click);
            // 
            // ntPurch
            // 
            this.ntPurch.AutoSize = true;
            this.ntPurch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.ntPurch.ForeColor = System.Drawing.Color.Red;
            this.ntPurch.Location = new System.Drawing.Point(32, 217);
            this.ntPurch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ntPurch.Name = "ntPurch";
            this.ntPurch.Size = new System.Drawing.Size(48, 29);
            this.ntPurch.TabIndex = 99;
            this.ntPurch.Text = "0.0";
            // 
            // ntSales
            // 
            this.ntSales.AutoSize = true;
            this.ntSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.ntSales.ForeColor = System.Drawing.Color.Red;
            this.ntSales.Location = new System.Drawing.Point(32, 111);
            this.ntSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ntSales.Name = "ntSales";
            this.ntSales.Size = new System.Drawing.Size(48, 29);
            this.ntSales.TabIndex = 98;
            this.ntSales.Text = "0.0";
            this.ntSales.Click += new System.EventHandler(this.ntSales_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label12.Location = new System.Drawing.Point(33, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 26);
            this.label12.TabIndex = 94;
            this.label12.Text = "Total  OF Salse";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label13.Location = new System.Drawing.Point(33, 279);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 26);
            this.label13.TabIndex = 96;
            this.label13.Text = "Net Profit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label14.Location = new System.Drawing.Point(33, 166);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 26);
            this.label14.TabIndex = 95;
            this.label14.Text = "Total  OF Purchases";
            // 
            // VATForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1827, 738);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.invoicetype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdditem);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VATForm";
            this.Text = "VATForm";
            this.invoicetype.ResumeLayout(false);
            this.invoicetype.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private btnDesign btnAdditem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox invoicetype;
        private System.Windows.Forms.Label vTotal;
        private System.Windows.Forms.Label vPurch;
        private System.Windows.Forms.Label vSale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NetProfit;
        private System.Windows.Forms.Label tPurch;
        private System.Windows.Forms.Label tSales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label nNetProfit;
        private System.Windows.Forms.Label ntPurch;
        private System.Windows.Forms.Label ntSales;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
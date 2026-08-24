
namespace AccountingApp
{
    partial class OldVoucherForm
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
            this.invoicetype = new System.Windows.Forms.GroupBox();
            this.rbPayment = new System.Windows.Forms.RadioButton();
            this.rbReciept = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.number = new System.Windows.Forms.TextBox();
            this.invoicetype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // invoicetype
            // 
            this.invoicetype.Controls.Add(this.rbPayment);
            this.invoicetype.Controls.Add(this.rbReciept);
            this.invoicetype.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.invoicetype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.invoicetype.Location = new System.Drawing.Point(108, 30);
            this.invoicetype.Name = "invoicetype";
            this.invoicetype.Size = new System.Drawing.Size(304, 84);
            this.invoicetype.TabIndex = 110;
            this.invoicetype.TabStop = false;
            this.invoicetype.Text = "Voucher Type";
            // 
            // rbPayment
            // 
            this.rbPayment.AutoSize = true;
            this.rbPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.rbPayment.Location = new System.Drawing.Point(18, 34);
            this.rbPayment.Name = "rbPayment";
            this.rbPayment.Size = new System.Drawing.Size(87, 24);
            this.rbPayment.TabIndex = 60;
            this.rbPayment.Text = "Payment";
            this.rbPayment.UseVisualStyleBackColor = true;
            // 
            // rbReciept
            // 
            this.rbReciept.AutoSize = true;
            this.rbReciept.Checked = true;
            this.rbReciept.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbReciept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.rbReciept.Location = new System.Drawing.Point(191, 34);
            this.rbReciept.Name = "rbReciept";
            this.rbReciept.Size = new System.Drawing.Size(77, 24);
            this.rbReciept.TabIndex = 61;
            this.rbReciept.TabStop = true;
            this.rbReciept.Text = "Reciept";
            this.rbReciept.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(92, 556);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(227, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 108;
            this.label2.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(104, 503);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 2);
            this.panel1.TabIndex = 107;
            // 
            // Date
            // 
            this.Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Date.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.Date.Location = new System.Drawing.Point(104, 467);
            this.Date.Multiline = true;
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(308, 35);
            this.Date.TabIndex = 106;
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(165, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "Search Voucher by";
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
            this.label3.Location = new System.Drawing.Point(199, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "Voucher No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(104, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 2);
            this.panel2.TabIndex = 102;
            // 
            // CustName
            // 
            this.CustName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustName.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.CustName.Location = new System.Drawing.Point(104, 355);
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
            this.label4.Location = new System.Drawing.Point(179, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 100;
            this.label4.Text = "Customer Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.Location = new System.Drawing.Point(104, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 2);
            this.panel3.TabIndex = 99;
            // 
            // number
            // 
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.number.Location = new System.Drawing.Point(104, 239);
            this.number.Multiline = true;
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(308, 34);
            this.number.TabIndex = 98;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // OldVoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 600);
            this.ControlBox = false;
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
            this.Controls.Add(this.number);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OldVoucherForm";
            this.Text = "OldVoucherForm";
            this.Load += new System.EventHandler(this.OldVoucherForm_Load);
            this.invoicetype.ResumeLayout(false);
            this.invoicetype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox invoicetype;
        private System.Windows.Forms.RadioButton rbPayment;
        private System.Windows.Forms.RadioButton rbReciept;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox number;
    }
}
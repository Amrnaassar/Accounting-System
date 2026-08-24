
namespace AccountingApp
{
    partial class ProductsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbType = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbamount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new AccountingApp.btnDesign();
            this.btUpdate = new AccountingApp.btnDesign();
            this.btnAddPru = new AccountingApp.btnDesign();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbPart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(33, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.Location = new System.Drawing.Point(131, 213);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 2);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label2.Location = new System.Drawing.Point(159, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Add product";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(131, 187);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(340, 28);
            this.tbName.TabIndex = 1;
            this.tbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyUp);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label3.Location = new System.Drawing.Point(33, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label4.Location = new System.Drawing.Point(33, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel2.Location = new System.Drawing.Point(131, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 2);
            this.panel2.TabIndex = 20;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbPrice.Location = new System.Drawing.Point(131, 250);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(340, 28);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPrice_KeyUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel3.Location = new System.Drawing.Point(131, 345);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 2);
            this.panel3.TabIndex = 22;
            // 
            // tbType
            // 
            this.tbType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbType.Location = new System.Drawing.Point(131, 315);
            this.tbType.Margin = new System.Windows.Forms.Padding(4);
            this.tbType.Multiline = true;
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(340, 28);
            this.tbType.TabIndex = 3;
            this.tbType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbType_KeyUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel4.Location = new System.Drawing.Point(131, 400);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 2);
            this.panel4.TabIndex = 29;
            // 
            // tbamount
            // 
            this.tbamount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbamount.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbamount.Location = new System.Drawing.Point(131, 370);
            this.tbamount.Margin = new System.Windows.Forms.Padding(4);
            this.tbamount.Multiline = true;
            this.tbamount.Name = "tbamount";
            this.tbamount.Size = new System.Drawing.Size(340, 28);
            this.tbamount.TabIndex = 4;
            this.tbamount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbamount_KeyUp);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label5.Location = new System.Drawing.Point(33, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 26);
            this.label5.TabIndex = 27;
            this.label5.Text = "Amount";
            // 
            // tbsearch
            // 
            this.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbsearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.Location = new System.Drawing.Point(131, 59);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbsearch.Multiline = true;
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(340, 28);
            this.tbsearch.TabIndex = 31;
            this.tbsearch.TextChanged += new System.EventHandler(this.onTextItemChange);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label6.Location = new System.Drawing.Point(33, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 26);
            this.label6.TabIndex = 30;
            this.label6.Text = "Search";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Location = new System.Drawing.Point(870, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lime;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(957, 950);
            this.dgv.TabIndex = 58;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel5.Location = new System.Drawing.Point(131, 89);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(340, 2);
            this.panel5.TabIndex = 59;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(143, 614);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 49);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btUpdate.FlatAppearance.BorderSize = 0;
            this.btUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(143, 558);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(200, 49);
            this.btUpdate.TabIndex = 24;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btnAddPru
            // 
            this.btnAddPru.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddPru.FlatAppearance.BorderSize = 0;
            this.btnAddPru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPru.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPru.ForeColor = System.Drawing.Color.White;
            this.btnAddPru.Location = new System.Drawing.Point(143, 501);
            this.btnAddPru.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPru.Name = "btnAddPru";
            this.btnAddPru.Size = new System.Drawing.Size(200, 49);
            this.btnAddPru.TabIndex = 5;
            this.btnAddPru.Text = "Add";
            this.btnAddPru.UseVisualStyleBackColor = false;
            this.btnAddPru.Click += new System.EventHandler(this.btnAddPru_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel6.Location = new System.Drawing.Point(131, 455);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 2);
            this.panel6.TabIndex = 62;
            // 
            // tbPart
            // 
            this.tbPart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPart.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.tbPart.Location = new System.Drawing.Point(131, 426);
            this.tbPart.Margin = new System.Windows.Forms.Padding(4);
            this.tbPart.Multiline = true;
            this.tbPart.Name = "tbPart";
            this.tbPart.Size = new System.Drawing.Size(340, 28);
            this.tbPart.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.label7.Location = new System.Drawing.Point(33, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 60;
            this.label7.Text = "Part";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1827, 950);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tbPart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tbamount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnAddPru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private btnDesign btnAddPru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbType;
        private btnDesign btUpdate;
        private btnDesign btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbamount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbPart;
        private System.Windows.Forms.Label label7;
    }
}
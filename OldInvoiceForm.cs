using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class OldInvoiceForm : Form
    {
        public DataTable dt = new DataTable();

        SqlCommand cmd = new SqlCommand();
        public OldInvoiceForm()
        {
            InitializeComponent();
            progressBar1.Hide();

        }

        private void OldInvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void invoiceNo_TextChanged(object sender, EventArgs e)
        {
            if (invoiceNo.Text != "" && new Func().IsNumber(invoiceNo.Text))
            {
                dgv.Visible = true;
                DBquery pr = new DBquery();
                if(rbSales.Checked==true)
                pr.searchInvID(invoiceNo.Text);
                if (rbpurchases.Checked == true)
                    pr.searchInvPID(invoiceNo.Text);

                dgv.DataSource = pr.dt;
                dgv.Columns[0].HeaderText = "InvoiceNo";
                dgv.Columns[1].HeaderText = "Customer Name";
                dgv.Columns[2].HeaderText = "Date";
                dgv.Columns[3].HeaderText = "Total";
                dgv.Columns[4].HeaderText = "Cancel";


            }
        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {
            dgv.Visible = true;
            DBquery pr = new DBquery();
            if (rbSales.Checked == true)
                pr.searchInvName(CustName.Text);
            if (rbpurchases.Checked == true)
                pr.searchInvPName(CustName.Text);
            dgv.DataSource = pr.dt;
            dgv.Columns[0].HeaderText = "InvoiceNo";
            dgv.Columns[1].HeaderText = "Customer Name";
            dgv.Columns[2].HeaderText = "Date";
            dgv.Columns[3].HeaderText = "Total";
            dgv.Columns[4].HeaderText = "Cancel";

        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            dgv.Visible = true;
            DBquery pr = new DBquery();
            if (rbSales.Checked == true)
                pr.searchInvDate(Date.Text);
            if (rbpurchases.Checked == true)
                pr.searchInvPDate(Date.Text); 
            dgv.DataSource = pr.dt;
            dgv.Columns[0].HeaderText = "InvoiceNo";
            dgv.Columns[1].HeaderText = "Customer Name";
            dgv.Columns[2].HeaderText = "Date";
            dgv.Columns[3].HeaderText = "Total";
            dgv.Columns[4].HeaderText = "Cancel";

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0&&rbSales.Checked==true)
            {
               

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                int InvoiceID = int.Parse(row.Cells[0].Value.ToString());
                printInv pr = new printInv();
                PrintForm prf = new PrintForm();
                DBquery qr = new DBquery();

                DialogResult dialogResult = MessageBox.Show("Do you want to Print Invoice", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    progressBar1.Show();
                    qr.PrintInvoice(InvoiceID); 
                    pr.SetDataSource(qr.dt);
                    prf.crystalReportViewer1.ReportSource = pr;                    
                    //pr.PrintOptions.PrinterName = "Canon MG3600 series Printer WS";
                    //pr.PrintToPrinter(1, false, 0, 0);                   
                    prf.Show();

                }
                else
                {
                    progressBar1.Show();
                    qr.PrintInvoice(InvoiceID);
                    pr.SetDataSource(qr.dt);
                    prf.crystalReportViewer1.ReportSource = pr;
                    prf.Show();
                }
                progressBar1.Hide();


            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (rbSales.Checked == true)
            {

                if (cancelNo.Text != "" && new Func().IsNumber(cancelNo.Text) == true)
                {
                    Cancel1();
                    Cancel2();
                    try
                    {
                            cmd.Connection = ConnectDB.cn;
                            ConnectDB.cn.Open();
                        foreach (DataRow row in dt.Rows)
                        {

                                cmd.Parameters.Clear();

                                cmd.CommandText = $"UPDATE Items SET amount=amount+@qty WHERE id = @id";
                                //MessageBox.Show(row["itemID"].ToString() + "|" + row["Qty"].ToString());

                                cmd.Parameters.Add("@id", int.Parse(row["itemID"].ToString()));
                            cmd.Parameters.Add("@qty", double.Parse(row["Qty"].ToString()));

                                cmd.ExecuteNonQuery();
                                cmd.Parameters.Clear();

                        }               
                            ConnectDB.cn.Close();

                    }
                    catch (Exception ex)
                    { MessageBox.Show(ex.Message); ConnectDB.cn.Close(); }
                    Cancel3();

                    cancelNo.Text = "";
                    MessageBox.Show("Done");

                }


            }
            else
            {
                if (cancelNo.Text != "" && new Func().IsNumber(cancelNo.Text) == true)
                {
                    CancelP1();
                    
                    cancelNo.Text = "";
                    MessageBox.Show("Done,please reduce items of invoice from stock ");

                }
            }
          

        }

        private void Cancel1()
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE InvoiceS SET cancel = 'Cancel' WHERE id = @id";

            cmd.Parameters.Add("@id", int.Parse(cancelNo.Text));


            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { cmd.Parameters.Clear(); ConnectDB.cn.Close(); }
            cmd.Parameters.Clear();
            ConnectDB.cn.Close();



        }
        private void Cancel2()
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"Select itemID,Qty from InvoiceItem where InvoiceItem.invoiceID=@id";
            cmd.Parameters.Add("@id", int.Parse(cancelNo.Text));
            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();


        }
        private void Cancel3()
        {
            SqlCommand c = new SqlCommand();
            c.Connection = ConnectDB.cn;
            c.CommandText = $"UPDATE InvoiceItem SET cancel = 'Cancel' WHERE invoiceID = @id" ;

            c.Parameters.Add("@id", int.Parse(cancelNo.Text));


            ConnectDB.cn.Open();
            try
            {
                c.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();
        }

        private void CancelP1()
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE InvoicePurch SET cancel = 'Cancel' WHERE invoice_id = @id and normal ='YES'";

            cmd.Parameters.Add("@id", int.Parse(cancelNo.Text));


            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { cmd.Parameters.Clear(); ConnectDB.cn.Close(); }
            cmd.Parameters.Clear();
            ConnectDB.cn.Close();



        }

       
    }
}

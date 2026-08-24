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
     
    public partial class OtherForm : Form
    {
        public DataTable dt = new DataTable();

        SqlCommand cmd = new SqlCommand();
        public OtherForm()
        {
            InitializeComponent();
            progressBar1.Hide();
        }

        private void invoiceNo_TextChanged(object sender, EventArgs e)
        {
            if (invoiceNo.Text != "" && new Func().IsNumber(invoiceNo.Text))
            {
                dgv.Visible = true;
                DBquery pr = new DBquery();
                if(rbSales.Checked==true)
                    pr.searchInvNID(invoiceNo.Text);
                if (rbpurchases.Checked == true)
                    pr.searchInvNPID(invoiceNo.Text);


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
                pr.searchInvNName(CustName.Text);
            if (rbpurchases.Checked == true)
                pr.searchInvNPName(CustName.Text);
           
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
                pr.searchInvNDate(Date.Text);
            if (rbpurchases.Checked == true)
                pr.searchInvNPDate(Date.Text);

            dgv.DataSource = pr.dt;
            dgv.Columns[0].HeaderText = "InvoiceNo";
            dgv.Columns[1].HeaderText = "Customer Name";
            dgv.Columns[2].HeaderText = "Date";
            dgv.Columns[3].HeaderText = "Total";
            dgv.Columns[4].HeaderText = "Cancel";

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (cancelNo.Text != "" && new Func().IsNumber(cancelNo.Text) == true)
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

           


        }
        private void Cancel1()
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE InvoiceSN SET cancel = 'Cancel' WHERE id = @id";

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
            dt.Rows.Clear();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"Select itemID,Qty from InvoiceItemN where InvoiceItemN.invoiceID=@id";
            cmd.Parameters.Add("@id", int.Parse(cancelNo.Text));
            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();


        }
        private void CancelP1()
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE InvoicePurch SET cancel = 'Cancel' WHERE invoice_id = @id and normal ='NO'";

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


        private void apply_Click(object sender, EventArgs e)
        {
            string x = dtpN.Text;
          //  MessageBox.Show(x);
            double sNot = double.Parse(calSales(x.Trim()).ToString());
            double PNot = double.Parse(calPurchases(x.Trim()).ToString());

            ntSales.Text = sNot.ToString();
            ntPurch.Text = PNot.ToString();
            nNetProfit.Text = (sNot-PNot).ToString();
        }

        public decimal calSales(String x)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(total)FROM InvoiceSN where MONTH(date)=@x and cancel is NULL";
            cmd.Parameters.Add("@x", dtpN.Value.Month);

            ConnectDB.cn.Open();
            decimal number = 0;
            try
            {
                dt.Load(cmd.ExecuteReader());
                number = dt.Rows[0].Field<decimal>(0);
            }
            catch (Exception e)
            {
                cmd.Parameters.Clear();
                ConnectDB.cn.Close();
            }

            cmd.Parameters.Clear();
            ConnectDB.cn.Close();

            return number;

        }
        public decimal calPurchases(String x)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
              cmd.CommandText = $"SELECT SUM(total)FROM InvoicePurch where MONTH(date)=@x and normal='NO' and cancel is NULL";
            cmd.Parameters.Add("@x", dtpN.Value.Month);

            ConnectDB.cn.Open();
            decimal number = 0;
            try
            {
                dt.Load(cmd.ExecuteReader());
                number = dt.Rows[0].Field<decimal>(0);
            }
            catch (Exception e)
            {
                cmd.Parameters.Clear();
                ConnectDB.cn.Close();
            }

            cmd.Parameters.Clear();
            ConnectDB.cn.Close();

            return number;

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && rbSales.Checked == true)
            {


                DataGridViewRow row = dgv.Rows[e.RowIndex];
                int InvoiceID = int.Parse(row.Cells[0].Value.ToString());
                printInvNotNormal pr = new printInvNotNormal();
                PrintForm prf = new PrintForm();
                DBquery qr = new DBquery();

                DialogResult dialogResult = MessageBox.Show("Do you want to Print Invoice", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    progressBar1.Show();
                    qr.PrintInvoiceNot(InvoiceID);
                    pr.SetDataSource(qr.dt);
                    prf.crystalReportViewer1.ReportSource = pr;
                    //pr.PrintOptions.PrinterName = "Canon MG3600 series Printer WS";
                    //pr.PrintToPrinter(1, false, 0, 0);                   
                    prf.Show();

                }
               
                progressBar1.Hide();


            }
        }
    }
}

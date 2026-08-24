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
    public partial class VATForm : Form
    {
        string[] manths = { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
        public VATForm()
        {
            InitializeComponent();
        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {

            double vs = 0, vp = 0, vt = 0, ts = 0, tp = 0, netProfit = 0, nts = 0, ntp = 0;

            vs += double.Parse(calVATSales().ToString());
                vp += double.Parse(calVATPurchases().ToString());
                ts += double.Parse(calSales().ToString());
                tp += double.Parse(calPurchases().ToString());
                nts += double.Parse(calNSales().ToString());
                ntp += double.Parse(calNPurchases().ToString());
            

            vSale.Text = vs.ToString();
            vPurch.Text = vp.ToString();
            vTotal.Text = (vs-vp).ToString();
            tSales.Text = ts.ToString();
            tPurch.Text = tp.ToString();
            NetProfit.Text = (ts-tp).ToString();
            ntSales.Text = nts.ToString();
            ntPurch.Text = ntp.ToString();
            nNetProfit.Text = (nts - ntp).ToString();

        }
        public decimal calVATSales()
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(vat)FROM InvoiceS where InvoiceS.date between @x and @y and cancel is NULL";
            cmd.Parameters.Add("@x", dtpFrom.Value);
            cmd.Parameters.Add("@y", dtpTo.Value);

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
        public decimal calVATPurchases()
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(vat)FROM InvoicePurch where InvoicePurch.date  between @x and @y and normal='YES' and cancel is NULL";
            cmd.Parameters.Add("@x", dtpFrom.Value);
            cmd.Parameters.Add("@y", dtpTo.Value);
            ConnectDB.cn.Open();
            decimal number = 0;
           
                dt.Load(cmd.ExecuteReader());
                number = dt.Rows[0].Field<decimal>(0);
            
          

            cmd.Parameters.Clear();
            ConnectDB.cn.Close();

            return number;

        }
        public decimal calSales()
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(total)FROM InvoiceS where InvoiceS.date  between @x and @y and cancel is NULL";
            cmd.Parameters.Add("@x", dtpFrom.Value);
            cmd.Parameters.Add("@y", dtpTo.Value);
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
        public decimal calPurchases()
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(total)FROM InvoicePurch where InvoicePurch.date  between @x and @y  and cancel is NULL";
            cmd.Parameters.Add("@x", dtpFrom.Value);
            cmd.Parameters.Add("@y", dtpTo.Value);
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
        public decimal calNSales()
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(total)FROM InvoiceS where InvoiceS.date  between @x and @y  and cancel is NULL";
            cmd.Parameters.Add("@x", dtpFrom.Value);
            cmd.Parameters.Add("@y", dtpTo.Value);
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
        public decimal calNPurchases()
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(total)FROM InvoicePurch where InvoicePurch.date  between @x and @y and normal='YES' and cancel is NULL";
            cmd.Parameters.Add("@x", dtpFrom.Value);
            cmd.Parameters.Add("@y", dtpTo.Value);
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
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void ntSales_Click(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

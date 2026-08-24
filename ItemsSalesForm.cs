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
    public partial class ItemsSalesForm : Form
    {
        public ItemsSalesForm()
        {
            InitializeComponent();
        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            itemOrder(dtpFrom.Value.Month);


        }

        public void itemOrder(int x)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            
            cmd.CommandText = $"SELECT name, SUM(Qty) FROM[ShopDB].[dbo].[InvoiceItemN] INNER JOIN[ShopDB].[dbo].[InvoiceSN] ON InvoiceSN.id = InvoiceItemN.invoiceID and InvoiceSN.cancel is NULL and  InvoiceSN.date between @x and @y  GROUP BY name HAVING SUM(Qty) > 0 ORDER BY SUM(Qty) DESC";
            cmd.Parameters.Add("@x", dtpFrom.Value);
            cmd.Parameters.Add("@y", dtpTo.Value);

            ConnectDB.cn.Open();
            
                dt.Load(cmd.ExecuteReader());
                dgv.DataSource = dt;
                dgv.Columns[0].HeaderText = "Name";
                dgv.Columns[1].HeaderText = "Total Sales";
               
          

            cmd.Parameters.Clear();
            ConnectDB.cn.Close();

             

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ItemsSalesForm_Load(object sender, EventArgs e)
        {
  
        }
    }
}

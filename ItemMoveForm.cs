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
    public partial class ItemMoveForm : Form
    {
        int itemID = 0, ID = 0;
        DBquery qr = new DBquery();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public ItemMoveForm()
        {
            InitializeComponent();
        }

        private void custName_TextChanged(object sender, EventArgs e)
        {
            dgvitem.Visible = true;
            DBquery pr = new DBquery();
            pr.showitems(ItemName.Text);
            dgvitem.DataSource = pr.dt;
            dgvitem.Columns[0].HeaderText = "itemNo";
            dgvitem.Columns[1].HeaderText = "Name";
            dgvitem.Columns[2].HeaderText = "Type";
            if (dgvitem.Rows.Count == 0)
                dgvitem.Visible = false;
        }

        private void ItemMoveForm_Load(object sender, EventArgs e)
        {

        }
        public DataTable call(int x)
        {

            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select name,date,custName,details,price,Qty from ItemMove WHERE ItemID = @id";
            cmd.Parameters.Add("@id", x);

            ConnectDB.cn.Open();
 

            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

            return dt;

        }
        public decimal calAmount(int x)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT amount FROM Items where id=@x";
            cmd.Parameters.Add("@x", x);

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
        public decimal calprice(int x)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT price FROM Items where id=@x";
            cmd.Parameters.Add("@x", x);

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

        private void ItemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                DataGridViewRow row = dgvitem.Rows[0];
                int id = int.Parse(row.Cells[0].Value.ToString());
                amounttb.Text = calAmount(id).ToString();
                pricetb.Text = calprice(id).ToString();

                //   dgv.Rows.Clear();
                // dgv.Columns.Clear();
                dgv.DataSource = call(id);
                dgv.Columns[0].HeaderText = "Name";
                dgv.Columns[1].HeaderText = "Date";
                dgv.Columns[2].HeaderText = "Customer Name";
                dgv.Columns[3].HeaderText = "Details";
                dgv.Columns[4].HeaderText = "Price";
                dgv.Columns[5].HeaderText = "Qty";

            }

        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvitem.Rows[e.RowIndex];
                int id = int.Parse(row.Cells[0].Value.ToString());
                amounttb.Text = calAmount(id).ToString();
                pricetb.Text = calprice (id).ToString();

                //   dgv.Rows.Clear();
                // dgv.Columns.Clear();
                dgv.DataSource = call(id);
                dgv.Columns[0].HeaderText = "Name";
                dgv.Columns[1].HeaderText = "Date";
                dgv.Columns[2].HeaderText = "Customer Name";
                dgv.Columns[3].HeaderText = "Details";
                dgv.Columns[4].HeaderText = "Price";
                dgv.Columns[5].HeaderText = "Qty";

            }
        }
    }
}

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
   
    public partial class FinancialForm : Form
    {
        int CustID = 0, ID = 0,cellID=0;
        DBquery qr = new DBquery();
         DataTable dt = new DataTable();

        SqlCommand cmd = new SqlCommand();
        public FinancialForm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void custName_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.Visible = true;
            DBquery pr = new DBquery();
            pr.searchCustomerInvoice(custName.Text);
            dgvCustomer.DataSource = pr.dt;
            dgvCustomer.Columns[0].HeaderText = "Customer TRN";
            dgvCustomer.Columns[1].HeaderText = "Name";
            dgvCustomer.Columns[2].HeaderText = "No.";

            if (dgvCustomer.Rows.Count == 0)
                dgvCustomer.Visible = true;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    ID = int.Parse(row.Cells[0].Value.ToString());
                   
                }
                CustID  = int.Parse(row.Cells[2].Value.ToString());

                custName.Text = (row.Cells[1].Value.ToString());
                dgvCustomer.Visible = true;
               // MessageBox.Show(ID + "");
                debits.Text = calDebit(CustID).ToString();
                credits.Text = calCredit(CustID).ToString();

                balance.Text = ((double.Parse(debits.Text)) - (double.Parse(credits.Text))).ToString();

               // dgv.Rows.Clear();
               // dgv.Columns.Clear();
                dgv.DataSource = Accounting(CustID);
                dgv.Columns[0].HeaderText = "Id";
                dgv.Columns[1].HeaderText = "Date";
                dgv.Columns[2].HeaderText = "Description";
                dgv.Columns[3].HeaderText = "Debit";
                dgv.Columns[4].HeaderText = "Credit";


            }
        }


        public DataTable Accounting(int x)
        {

            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,date,details,debit,credit from Account WHERE custID = @id  order by convert(datetime, [date], 103) Desc";
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

        public decimal calDebit(int  x)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(debit)FROM Account where custID=@x ";
            cmd.Parameters.Add("@x", CustID);

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

        private void custName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    DataGridViewRow row = dgvCustomer.Rows[0];
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        ID = int.Parse(row.Cells[0].Value.ToString());

                    }
                    CustID = int.Parse(row.Cells[2].Value.ToString());

                    custName.Text = (row.Cells[1].Value.ToString());
                    dgvCustomer.Visible = true;
                    // MessageBox.Show(ID + "");
                    debits.Text = calDebit(CustID).ToString();
                    credits.Text = calCredit(CustID).ToString();

                    balance.Text = ((double.Parse(debits.Text)) - (double.Parse(credits.Text))).ToString();

                    //   dgv.Rows.Clear();
                    // dgv.Columns.Clear();
                    dgv.DataSource = Accounting(CustID);
                    dgv.Columns[0].HeaderText = "Date";
                    dgv.Columns[1].HeaderText = "Description";
                    dgv.Columns[2].HeaderText = "Debit";
                    dgv.Columns[3].HeaderText = "Credit";

            }


        }

        private void FinancialForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPru_Click(object sender, EventArgs e)
        {
            DBquery qr = new DBquery();

            if (tbCredit.Text != ""&& new Func().IsNumber(tbCredit.Text) == true)
            {
                qr.InsertAccount(dateTimePicker1, CustID, custName.Text, tbDetails.Text, double.Parse(tbCredit.Text), 0);

            }
            else if (tbDebit.Text != "" && new Func().IsNumber(tbDebit.Text) == true)
            {
                qr.InsertAccount(dateTimePicker1, CustID, custName.Text, tbDetails.Text,0, double.Parse(tbDebit.Text));

            }
            else
            {
                MessageBox.Show("Something Wrong");
            }
            tbDetails.Text = "";
            tbDebit.Text = "";
            tbCredit.Text = "";
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgv.Rows[e.RowIndex];
                cellID = int.Parse(row.Cells[0].Value.ToString());
                dateTimePicker1.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                tbDetails.Text = row.Cells[2].Value.ToString();
                tbDebit.Text = row.Cells[3].Value.ToString();
                tbCredit.Text = row.Cells[4].Value.ToString();



            }
        }

        public void Updateitem(int id)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE Account SET date = @date, details = @details,credit=@credit ,debit=@debit WHERE id = @iditem";
            cmd.Parameters.Add("@iditem", id);
            cmd.Parameters.Add("@date", dateTimePicker1.Value);
            cmd.Parameters.Add("@details", tbDetails.Text);
            cmd.Parameters.Add("@credit", double.Parse(tbCredit.Text));
            cmd.Parameters.Add("@debit", double.Parse(tbDebit.Text));

            ConnectDB.cn.Open();
            
                cmd.ExecuteReader();
          
            ConnectDB.cn.Close();


            tbCredit.Text = "";
            tbDebit.Text = "";
            tbDetails.Text = "";
            cellID = 0;

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Updateitem(cellID);

        }

        public decimal calCredit(int x)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT SUM(credit) FROM[ShopDB].[dbo].[Account] where custID = @x"
;
            cmd.Parameters.Add("@x", CustID);
           // cmd.Parameters.Add("@x", "%كاش%");

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




    }
}

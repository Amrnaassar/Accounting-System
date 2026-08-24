using NumberToWord;
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
    public partial class ReceiptVForm : Form
    {
        int CustID = 0, ID = 0,voID=0;
        DBquery qr = new DBquery();
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        public ReceiptVForm()
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));

            InitializeComponent();
            CheqDate.Text = "";
            voID = qr.thisReceiptV();
           vid.Text= (voID +1)+ "";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (Date.Text == "" || Amount.Text == "" || custName.Text == "" )
            {
                MessageBox.Show("Empity field");
            }
            else if (new Func().IsNumber(Amount.Text) == false)
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                voID++;
                Decimal a;
                if (new Func().IsNumberDouble(Amount.Text))
                    a = Decimal.Parse(Amount.Text + "0");
                else
                {
                    a = Decimal.Parse(Amount.Text);
                }
                a = Math.Round(a, 2);
                ToWord toWord = new ToWord(Convert.ToDecimal(a), currencies[0]);
                string arabic = toWord.ConvertToArabic();

                string d = "";
                if ( Bank.Text != "")
                    d = CheqDate.Text;

                insertReceiptV(voID,Date.Text, Details.Text, double.Parse(Amount.Text),
                    custName.Text, "", arabic, CheqNo.Text, d, Bank.Text);

                DBquery qr = new DBquery();
                
                string s = "سند قبض رقم " + qr.thisReceiptV();
                // MessageBox.Show(s);
                qr.InsertAccount(Date, ID, custName.Text, s, double.Parse(Amount.Text),0);
                

                DialogResult dialogResult = MessageBox.Show("Do you want to Print Receipt Voucher", "Print Receipt Voucher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    print(true);

                }
                
                Amount.Text = "";
                custName.Text = "";
                Details.Text = "";
                CheqDate.Text = "";
                CheqNo.Text = "";
                Bank.Text = "";
            }

          
        }

        private void print(bool f)
        {
            CRreceipt crp = new CRreceipt();
            PrintForm prf = new PrintForm();
            DBquery qr = new DBquery();
            qr.PrintReceiptV(qr.thisReceiptV());
            crp.SetDataSource(qr.dt);
            prf.crystalReportViewer1.ReportSource = crp;
            /*
            if (f)
            {
                crp.PrintOptions.PrinterName = "Canon MG3600 series Printer WS";
                crp.PrintToPrinter(1, false, 0, 0);
            }*/
            prf.Show();
        }
        private void insertReceiptV(int voID,string date, string details, double total, string custName, string custID
            , string NoInWords, string cheqNo, string cheqDate, string Bank)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"Insert into ReceiptVoucher( id,date, details, total, custName, custID, NoInWords, cheqNo, cheqDate, Bank)values " +
                "( @id, @date, @details, @total, @custName, @custID, @NoInWords, @cheqNo, @cheqDate, @Bank)";
            cmd.Parameters.Add("@id", voID);
            cmd.Parameters.Add("@date", Date.Value);
            cmd.Parameters.Add("@details", details);
            cmd.Parameters.Add("@total", total);
            cmd.Parameters.Add("@custName", custName);
            cmd.Parameters.Add("@custID", custID);
            cmd.Parameters.Add("@NoInWords", NoInWords);
            cmd.Parameters.Add("@cheqNo", cheqNo);
            cmd.Parameters.Add("@cheqDate", cheqDate);
            cmd.Parameters.Add("@Bank", Bank);

            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }


            ConnectDB.cn.Close();
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
                dgvCustomer.Visible = false;
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    CustID = int.Parse(row.Cells[0].Value.ToString());

                }
                ID = int.Parse(row.Cells[2].Value.ToString());

               // MessageBox.Show(ID + "");
                custName.Text = (row.Cells[1].Value.ToString());
                dgvCustomer.Visible = false;
            }
        }
    }
}

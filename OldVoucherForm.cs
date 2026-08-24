using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class OldVoucherForm : Form
    {
        public OldVoucherForm()
        {
            InitializeComponent();
            progressBar1.Hide();
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            if (number.Text != "" && new Func().IsNumber(number.Text))
            {
                dgv.Visible = true;
                DBquery pr = new DBquery();
                if (rbReciept.Checked == true)
                    pr.searchVoRID(number.Text);
                if (rbPayment.Checked == true)
                    pr.searchVoPID(number.Text);

                dgv.DataSource = pr.dt;
                dgv.Columns[0].HeaderText = "VoucherNo";
                dgv.Columns[1].HeaderText = "Customer Name";
                dgv.Columns[2].HeaderText = "Date";
                dgv.Columns[3].HeaderText = "Amount";
                //dgv.Columns[4].HeaderText = "Cancel";


            }
        }

        private void CustName_TextChanged(object sender, EventArgs e)
        {
            dgv.Visible = true;
            DBquery pr = new DBquery();
            if (rbReciept.Checked == true)
                pr.searchVoRName(CustName.Text);
            if (rbPayment.Checked == true)
                pr.searchVopName(CustName.Text);

            dgv.DataSource = pr.dt;
            dgv.Columns[0].HeaderText = "VoucherNo";
            dgv.Columns[1].HeaderText = "Customer Name";
            dgv.Columns[2].HeaderText = "Date";
            dgv.Columns[3].HeaderText = "Amount";
        }

        private void Date_TextChanged(object sender, EventArgs e)
        {
            dgv.Visible = true;
            DBquery pr = new DBquery();
            if (rbReciept.Checked == true)
                pr.searchVoRNDate(Date.Text);
            if (rbPayment.Checked == true)
                pr.searchVoPDate(Date.Text);

            dgv.DataSource = pr.dt;
            dgv.Columns[0].HeaderText = "VoucherNo";
            dgv.Columns[1].HeaderText = "Customer Name";
            dgv.Columns[2].HeaderText = "Date";
            dgv.Columns[3].HeaderText = "Amount";
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && rbPayment.Checked == true)
            {


                DataGridViewRow row = dgv.Rows[e.RowIndex];
                int ID = int.Parse(row.Cells[0].Value.ToString());
                printInv pr = new printInv();
                PrintForm prf = new PrintForm();
                DBquery qr = new DBquery();

                DialogResult dialogResult = MessageBox.Show("Do you want to Print Payment Voucher", "Print Payment Voucher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    progressBar1.Show();
                    CRpayment crp = new CRpayment();
                   
                    // MessageBox.Show(qr.thisPaymentV()+"");
                    qr.PrintPaymentV(ID);
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
               
                progressBar1.Hide();


            }
            if (e.RowIndex >= 0 && rbReciept.Checked == true)
            {


                DataGridViewRow row = dgv.Rows[e.RowIndex];
                int ID = int.Parse(row.Cells[0].Value.ToString());
                printInv pr = new printInv();
                PrintForm prf = new PrintForm();
                DBquery qr = new DBquery();

                DialogResult dialogResult = MessageBox.Show("Do you want to Print Receipt Voucher", "Print Receipt Voucher", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    progressBar1.Show();
                    CRreceipt crp = new CRreceipt();
                    
                    qr.PrintReceiptV(ID);
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

                progressBar1.Hide();


            }
        }

        private void printP()
        {
            CRpayment crp = new CRpayment();
            PrintForm prf = new PrintForm();
            DBquery qr = new DBquery();
            // MessageBox.Show(qr.thisPaymentV()+"");
            qr.PrintPaymentV(qr.thisPaymentV());
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

        private void OldVoucherForm_Load(object sender, EventArgs e)
        {

        }
    }
}

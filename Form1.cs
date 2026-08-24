using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          



            // this.TopMost = true;
            // WindowState = FormWindowState.Maximized;
        }
        public void loadform(object Form)
        {

            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnDesign1_Click(object sender, EventArgs e)
        {
            loadform(new InvoiceForm());


        }

      

        private void btnDesign2_Click(object sender, EventArgs e)
        {
            loadform(new ProductsForm());
        }

        private void btnDesign5_Click(object sender, EventArgs e)
        {
            /*
            this.Close();
            Thread th = new Thread(openform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();*/

            loadform(new OldVoucherForm());
        }

        
       

        private void btnDesign3_Click(object sender, EventArgs e)
        {
            loadform(new FinancialForm());
        }

        
        private void openform(object obj)
        {
            Application.Run(new Login());

        }

        private void Custmers_Click(object sender, EventArgs e)
        {
            loadform(new CustomersForm());

        }

        private void oldInvoice_Click(object sender, EventArgs e)
        {
            loadform(new OldInvoiceForm());
        }

        private void btnDesign3_Click_1(object sender, EventArgs e)
        {
            loadform(new VATForm());
        }

        

        private void btnDesign4_Click(object sender, EventArgs e)
        {
            loadform(new FinancialForm());
        }

        private void btnDesign5_Click_1(object sender, EventArgs e)
        {
            loadform(new ItemsSalesForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDesign7_Click(object sender, EventArgs e)
        {
            loadform(new PaymentVForm());

        }

        private void btnDesign6_Click(object sender, EventArgs e)
        {
            loadform(new ReceiptVForm());
        }

        private void btnDesign8_Click(object sender, EventArgs e)
        {
            loadform(new OtherForm());
        }

        private void btnDesign9_Click(object sender, EventArgs e)
        {
            loadform(new UpdateInvForm());

        }

        private void btnDesign10_Click(object sender, EventArgs e)
        {
            loadform(new ItemMoveForm());

        }
    }
}

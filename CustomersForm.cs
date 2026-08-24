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
    public partial class CustomersForm : Form
    {
       bool select =false;
        public CustomersForm()
        {
            InitializeComponent();
            showCustomers();
        }

        private void showCustomers()
        {
            DBquery pr = new DBquery();
            pr.showCustomers();
            dgvCustomer.DataSource = pr.dt;
            dgvCustomer.Columns[0].HeaderText = "CustomerNo";
            dgvCustomer.Columns[1].HeaderText = "Name";
            dgvCustomer.Columns[2].HeaderText = "Phone";
            dgvCustomer.Columns[3].HeaderText = "TRN";
        }
        private void clearDetails()
        {
            tbName.Text = "";
            tbPhone.Text = "";
            tbfax.Text = "";
        }
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" )
            {
                MessageBox.Show("Empity field");
            }
            else
            {
                DBquery add = new DBquery();
                add.InsertCusomer(tbName.Text, tbPhone.Text, tbfax.Text);
                dgvCustomer.Refresh();
                showCustomers();
                clearDetails();
            }


        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
           
            if (select == true)
            {
                int id = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());

                if (tbName.Text == "")
                {
                    MessageBox.Show("Empity field");
                }
                else
                {
                    new DBquery().UpdateCustomer(id,tbName.Text, tbPhone.Text, tbfax.Text);
                    dgvCustomer.Refresh();
                    showCustomers();
                    select = false;
                    clearDetails();
                }
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                tbName.Text = row.Cells[1].Value.ToString();
                tbPhone.Text = row.Cells[2].Value.ToString();
                tbfax.Text = row.Cells[3].Value.ToString();

                select = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (select == true)
            {
                int id = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());

                if (tbName.Text == "" )
                {
                    MessageBox.Show("Empity field");
                }
                else
                {
                    new DBquery().deleteCustomer(id);
                    dgvCustomer.Refresh();
                    showCustomers();
                    select = false;
                    clearDetails();
                }
            }

        }
        private void onTextCustomerChange(object sender, EventArgs e)
        {
            DBquery pr = new DBquery();
            pr.searchCustomer(tbsearch.Text);
            dgvCustomer.DataSource = pr.dt;
            dgvCustomer.Columns[0].HeaderText = "CustomerNo";
            dgvCustomer.Columns[1].HeaderText = "Name";
            dgvCustomer.Columns[2].HeaderText = "Phone";
            dgvCustomer.Columns[3].HeaderText = "Fax";

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }
    }
}

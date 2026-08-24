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
    public partial class ProductsForm : Form
    {
        bool select = false;
        int id = -1;
        public ProductsForm()
        {
            InitializeComponent();

            showItems();

        }
        private void clearDetails()
        {
            tbName.Text = "";
            tbPrice.Text = "";
            tbType.Text = "";
            tbamount.Text = "";
            tbPart.Text = "";
        }
        private void showItems()
        {
            DBquery pr = new DBquery();
            pr.showProducts();
            dgv.DataSource = pr.dt;
            dgv.Columns[0].HeaderText = "itemNo";
            dgv.Columns[1].HeaderText = "Name";
            dgv.Columns[2].HeaderText = "Price";
            dgv.Columns[3].HeaderText = "Type";
            dgv.Columns[4].HeaderText = "Amount";
            dgv.Columns[5].HeaderText = "Part";



        }

        private void btnAddPru_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == "" || tbPrice.Text == "" || tbType.Text == ""||tbPart.Text=="")
                {
                    MessageBox.Show("Empity field");
                }
                else if (new Func().IsNumber(tbPrice.Text) == false || new Func().IsNumber(tbamount.Text) == false)
                {
                    MessageBox.Show("Invalid input");
                }
                else
                {
                    DBquery add = new DBquery();
                    add.Insertitem(tbName.Text, double.Parse(tbPrice.Text), tbType.Text,
                        double.Parse(tbamount.Text),tbPart.Text);
                    dgv.Refresh();
                    showItems();
                    clearDetails();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {


            if (select == false)
            {
                MessageBox.Show("Please Select Item");

            }
            else
            {
                try
                {
                    id = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
                    if (tbName.Text == "" || tbPrice.Text == "" || tbType.Text == "" || tbamount.Text == "")
                    {
                        MessageBox.Show("Empity field");
                    }
                    else if (new Func().IsNumber(tbPrice.Text) == false || new Func().IsNumber(tbamount.Text) == false)
                    {
                        MessageBox.Show("Invalid input");
                    }
                    else
                    {
                        new DBquery().Updateitem(id, tbName.Text, double.Parse(tbPrice.Text),
                            tbType.Text, double.Parse(tbamount.Text), tbPart.Text);
                        showItems();

                        dgv.Refresh();
                        clearDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           
            if (select == false)
            {
                MessageBox.Show("Please Select Item");

            }
            else
            {
                try
                {
                    id = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
                    if (tbName.Text == "" || tbPrice.Text == "" || tbType.Text == "")
                    {
                        MessageBox.Show("Empity field");
                    }
                    else if (new Func().IsNumber(tbPrice.Text) == false || new Func().IsNumber(tbamount.Text) == false)
                    {
                        MessageBox.Show("Invalid input");
                    }
                    else
                    {
                        new DBquery().deleteitem(id);
                        showItems();

                        dgv.Refresh();
                        clearDetails();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }

        }

        private void onTextItemChange(object sender, EventArgs e)
        {
            try { 
            DBquery pr = new DBquery();
            pr.searchitem(tbsearch.Text);
            dgv.DataSource = pr.dt;
            dgv.Columns[0].HeaderText = "itemNo";
            dgv.Columns[1].HeaderText = "Name";
            dgv.Columns[2].HeaderText = "Price";
            dgv.Columns[3].HeaderText = "Type";
            dgv.Columns[4].HeaderText = "Amount";
            dgv.Columns[5].HeaderText = "Part";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                tbName.Text = row.Cells[1].Value.ToString();
                tbPrice.Text = row.Cells[2].Value.ToString();
                tbType.Text = row.Cells[3].Value.ToString();
                tbamount.Text = row.Cells[4].Value.ToString();
                tbPart.Text = row.Cells[5].Value.ToString();

                select = true;
            }

        }

        private void tbName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                this.SelectNextControl(tbName, true, true, true, true);
            }
        }

        private void tbPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(tbPrice, true, true, true, true);
            }
        }

        private void tbType_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(tbType, true, true, true, true);
            }

        }

        private void tbamount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(tbamount, true, true, true, true);

               
            }
           
        }
    }
}

using NumberToWord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class InvoiceForm : Form
    {
        int itemID = 0, CustID=0,InvoiceID=0,IDP=-1, IDIn=-1, IDN = -1, IDOutN=-1,No=0;
        DBquery qr = new DBquery();
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        public InvoiceForm()
        {
            InitializeComponent();
            // label13.Visible = false;
            //InvID.Visible = false;
            //panel13.Visible = false;
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
           // currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia));
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            //currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            itemVat.Text = "5";
            Discount.Text = "0";
            dgvCustomer.ReadOnly = true;
            dgvInvoice.ReadOnly = true;
            dgvSearchitem.ReadOnly = true;
            //MessageBox.Show(SystemInformation.VirtualScreen.Width + "|" + SystemInformation.VirtualScreen.Height);
            IDIn = qr.thisInvoice();
            IDP = qr.thisInvoicePu();
            IDN= qr.thisInvoiceN();
            IDOutN= qr.thisInvoiceOut();



        

        }



        private void searchItem(object sender, EventArgs e)
        {
            dgvSearchitem.Visible = true;
            DBquery pr = new DBquery();
            pr.showitems(itemName.Text);
            dgvSearchitem.DataSource = pr.dt;
            dgvSearchitem.Columns[0].HeaderText = "itemNo";
            dgvSearchitem.Columns[1].HeaderText = "Name";
            dgvSearchitem.Columns[2].HeaderText = "Type";
            if (dgvSearchitem.Rows.Count == 0)
                dgvSearchitem.Visible = false;
        }

        private void searchCustomer(object sender, EventArgs e)
        { 
            dgvCustomer.Visible = true;
            DBquery pr = new DBquery();
            pr.searchCustomerInvoice(custName.Text);
            dgvCustomer.DataSource = pr.dt;
            dgvCustomer.Columns[0].HeaderText = "Customer TRN";
            dgvCustomer.Columns[1].HeaderText = "Name";
            dgvCustomer.Columns[2].HeaderText = "NO.";

            if (dgvCustomer.Rows.Count==0)
                dgvCustomer.Visible = false;

        }

        private void dgvSearchitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSearchitem.Rows[e.RowIndex];
                itemID = int.Parse(row.Cells[0].Value.ToString());

                itemName.Text = ((row.Cells[1].Value.ToString()) + " - " + (row.Cells[2].Value.ToString()) );
                dgvSearchitem.Visible = false;
            }

        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            Additem();
        }



        private void apply_Click(object sender, EventArgs e)
        {
            if (Discount.Text == "" )
            {
                MessageBox.Show("Empity field");
            }
            else if (new Func().IsNumber(Discount.Text) == false )
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                if(rbNormal.Checked==true)
                Tvat.Text = (double.Parse(Tvat.Text.ToString()) - (double.Parse(Discount.Text.ToString()) * 0.05)).ToString();


                Ttotal.Text = (double.Parse(Ttotal.Text.ToString()) - (double.Parse(Discount.Text.ToString()))).ToString();
                Tdiscount.Text= (double.Parse(Tdiscount.Text.ToString()) + (double.Parse(Discount.Text.ToString()))).ToString();
                Discount.Text = "0";
            }
        }
        private bool checkedItemExist(int id)
        {
            bool f = false;
            foreach (DataGridViewRow row in dgvInvoice.Rows)
            {
                int itemID = int.Parse(row.Cells[0].Value.ToString());
                if (id == itemID)
                {
                    f = true;
                    break;
                }
            }

            return f;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

             if (new Func().IsNumber(InvID.Text) == false || InvID.Text == ""&& (rbpurchases.Checked == true))
                MessageBox.Show("Invalid or Empty Invoice No");
            else
            {
                DBquery qr = new DBquery();
                SqlCommand cmd = new SqlCommand();
                Decimal a;
               if ( new Func().IsNumberDouble(Ttotal.Text))
                 a=Decimal.Parse(Ttotal.Text+"0" );
               else
                    a = Decimal.Parse(Ttotal.Text );

                a = Math.Round(a, 2);

                ToWord toWord = new ToWord(Convert.ToDecimal(a), currencies[0]);
                string arabic = toWord.ConvertToArabic();
               // MessageBox.Show(arabic + "");

               

                
               //  MessageBox.Show(arabic);

                string s = "",nor="NO";
                if (rbNormal.Checked == true)
                    nor = "YES";

                if (rbSales.Checked == true)
                    s = rbSales.Text;
                else if (rbpurchases.Checked == true)
                { 
                    s = rbpurchases.Text;
                    label13.Visible = true;
                    InvID.Visible = true;
                    panel13.Visible = true;
                }
                else
                { MessageBox.Show("Select type of Invoice"); return; }


              

                if (rbSales.Checked == true)
                {

                    
                       
                   
                    if (rbNormal.Checked == true)
                    {

                        IDOutN++;

                            qr.InsertInvoice(IDOutN, dateTimePicker1, Details.Text, custName.Text, CustID,
                               (double.Parse(Ttotal.Text.ToString())),
                               (double.Parse(Tsubtotal.Text.ToString())),
                               (double.Parse(Tdiscount.Text.ToString())),
                               (double.Parse(Tvat.Text.ToString())), s, "IN", arabic);
                            InvoiceID = IDOutN;
                            if (custName.Text != "")
                            {
                                string de = "فاتورة مبيعات رقم   " + IDIn;

                                //  MessageBox.Show(de);
                                qr.InsertAccount(dateTimePicker1, No, custName.Text, de, double.Parse(Ttotal.Text), double.Parse(Ttotal.Text));

                            }
                        
                      
                    }
                    else
                    {
                        
                            IDN++;

                            qr.InsertInvoiceSN(IDN, dateTimePicker1, Details.Text, custName.Text, CustID,
                               (double.Parse(Ttotal.Text.ToString())),
                               (double.Parse(Tsubtotal.Text.ToString())),
                               (double.Parse(Tdiscount.Text.ToString())),
                               (double.Parse(Tvat.Text.ToString())), s, nor, arabic);
                            InvoiceID = IDN;

                            if (custName.Text != "")
                            {
                                string de = "فاتورة غ مبيعات  رقم   " + IDN;

                                //  MessageBox.Show(de);
                                qr.InsertAccount(dateTimePicker1, No, custName.Text, de, double.Parse(Ttotal.Text), double.Parse(Ttotal.Text));

                            }
                        
                    }
                }
                if (rbpurchases.Checked == true)
                {
                    IDP++;
                    if ( new Func().IsNumber(InvID.Text) == false|| InvID.Text=="")
                        MessageBox.Show("Invalid input");
                    else
                        qr.InsertInvoicePurch(IDP,int.Parse(InvID.Text),dateTimePicker1, Details.Text, custName.Text, CustID,
                          (double.Parse(Ttotal.Text.ToString())),
                          (double.Parse(Tsubtotal.Text.ToString())),
                          (double.Parse(Tdiscount.Text.ToString())),
                          (double.Parse(Tvat.Text.ToString())), nor, arabic);
                    if (custName.Text != "")
                    {
                        string de = "فاتورة مشتريات رقم   " + int.Parse(InvID.Text);

                        // MessageBox.Show(de);
                        qr.InsertAccount(dateTimePicker1, No, custName.Text, de, double.Parse(Ttotal.Text), 0);
                    }

                    InvoiceID = IDP;
                }


                bool f = false;

                try
                {

                    cmd.Connection = ConnectDB.cn;
                    ConnectDB.cn.Open();


                    foreach (DataGridViewRow row in dgvInvoice.Rows)
                    {
                        int itemID = int.Parse(row.Cells[0].Value.ToString());
                        int invoiceID = InvoiceID;
                        string name = row.Cells[1].Value.ToString();
                        double Qty = double.Parse(row.Cells[2].Value.ToString());
                        double price = double.Parse(row.Cells[3].Value.ToString());

                        double subtotal = double.Parse(row.Cells[4].Value.ToString());
                        double VAT = double.Parse(row.Cells[5].Value.ToString());
                        double total = double.Parse(row.Cells[6].Value.ToString());

                        string de = "";
                        if (rbpurchases.Checked == true)
                        {
                            invoiceID = int.Parse(InvID.Text);
                            

                             de = "فاتورة مشتريات رقم   " + invoiceID;

                           

                        }
                        if (rbSales.Checked == true)
                        {
                            if (rbNormal.Checked == false)
                            {
                                
                                 de = "فاتورة مبيعات غ رقم   " + invoiceID;


                            }
                            else
                            {
                               

                                 de = "فاتورة مبيعات  رقم   " + invoiceID;


                            }
                        }

                        cmd.CommandText = $"Insert into ItemMove(date,ItemID,custName,details,price,Qty,name)" +
                             $"values (@date,@ItemID,@custName,@details,@price,@Qty,@name)";
                        
                        

                        cmd.Parameters.Add("@date", dateTimePicker1.Value);
                        cmd.Parameters.Add("@details", de);
                        cmd.Parameters.Add("@price", price);
                        cmd.Parameters.Add("@Qty", Qty);
                        cmd.Parameters.Add("@name", name);

                        

                        cmd.Parameters.Add("@custName", custName.Text);
                        cmd.Parameters.Add("@ItemID", itemID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }
                    ConnectDB.cn.Close();
                    ConnectDB.cn.Open();

                    foreach (DataGridViewRow row in dgvInvoice.Rows)
                    {
                        int itemID = int.Parse(row.Cells[0].Value.ToString());
                        int invoiceID = InvoiceID;
                        string name = row.Cells[1].Value.ToString();
                        double Qty = double.Parse(row.Cells[2].Value.ToString());
                        double price = double.Parse(row.Cells[3].Value.ToString());

                        double subtotal = double.Parse(row.Cells[4].Value.ToString());
                        double VAT = double.Parse(row.Cells[5].Value.ToString());
                        double total = double.Parse(row.Cells[6].Value.ToString());

                        if (rbpurchases.Checked == true)
                        {
                            invoiceID = int.Parse(InvID.Text);
                            cmd.CommandText = $"Insert into InvoicePItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                            $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";

                            string de = "فاتورة مشتريات رقم   " + invoiceID;



                        }
                        if (rbSales.Checked == true)
                        {
                            if (rbNormal.Checked == false)
                            {
                                cmd.CommandText = $"Insert into InvoiceItemN(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                                  $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
                                string de = "فاتورة مبيعات غ رقم   " + IDN;


                            }
                            else
                            {
                                cmd.CommandText = $"Insert into InvoiceItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                                   $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";

                                string de = "فاتورة مبيعات  رقم   " + IDN;


                            }
                        }
                        cmd.Parameters.Add("@itemID", itemID);
                        cmd.Parameters.Add("@invoiceID", invoiceID);
                        cmd.Parameters.Add("@name", name);
                        cmd.Parameters.Add("@Qty", Qty);
                        cmd.Parameters.Add("@price", price);
                        cmd.Parameters.Add("@stotal", subtotal);
                        cmd.Parameters.Add("@IVAT", VAT);
                        cmd.Parameters.Add("@Itotal", total);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }

                    ConnectDB.cn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ConnectDB.cn.Close();

                }

                try
                {
                    cmd.Connection = ConnectDB.cn;
                    ConnectDB.cn.Open();


                    if (s == "Sales")
                    {
                        foreach (DataGridViewRow row in dgvInvoice.Rows)
                        {
                            int itemID = int.Parse(row.Cells[0].Value.ToString());
                            double Qty = double.Parse(row.Cells[2].Value.ToString());

                            cmd.Connection = ConnectDB.cn;
                            cmd.CommandText = $"UPDATE Items SET amount=amount-@amount WHERE id = @id";

                            cmd.Parameters.Add("@amount", Qty);
                            cmd.Parameters.Add("@id", itemID);

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvInvoice.Rows)
                        {
                            int itemID = int.Parse(row.Cells[0].Value.ToString());
                            double Qty = double.Parse(row.Cells[2].Value.ToString());

                            cmd.Connection = ConnectDB.cn;
                            cmd.CommandText = $"UPDATE Items SET amount=amount+@amount WHERE id = @id";

                            cmd.Parameters.Add("@amount", Qty);
                            cmd.Parameters.Add("@id", itemID);

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                        }
                    }

                    ConnectDB.cn.Close();
                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.Message);
                    ConnectDB.cn.Close();

                }

                if (rbSales.Checked==true&&rbNormal.Checked==true)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Print Invoice", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        printInvo(true);

                    }
                }
                if (rbSales.Checked == true && rbNormal.Checked == false)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Print Invoice", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        printInvNotNormal pr = new printInvNotNormal();
                        PrintForm prf = new PrintForm();
                        

                        qr.PrintInvoiceNot(InvoiceID);
                        pr.SetDataSource(qr.dt);
                        prf.crystalReportViewer1.ReportSource = pr;
                        //pr.PrintOptions.PrinterName = "Canon MG3600 series Printer WS";
                        //pr.PrintToPrinter(1, false, 0, 0);                   
                        prf.Show();

                    }
                }


                dgvInvoice.DataSource = null;
                dgvInvoice.Rows.Clear();
                itemID = 0; CustID = 0; InvoiceID = 0;
                Tsubtotal.Text = "0";
                Tdiscount.Text = "0";
                Ttotal.Text = "0";
                Tvat.Text = "0";
                InvID.Text = "";
                custName.Text = "";
                //custName.Text = "";
                invTypeBox.Visible = true;
            }
        }

        private void printInvo(bool f)
        {
            printInv pr = new printInv();
            PrintForm prf = new PrintForm();
            qr.PrintInvoice(InvoiceID);
            pr.SetDataSource(qr.dt);
            prf.crystalReportViewer1.ReportSource = pr;
            if (f)
            {
               //  pr.PrintOptions.PrinterName = "Canon MG3600 series Printer WS";
                // pr.PrintToPrinter(1, false, 0, 0);
            }
            prf.Show();
        }

        private void rbpurchases_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void rbSales_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDesign1_Click(object sender, EventArgs e)
        {
           
            if (rbpurchases.Checked == true)
            {

                if (new Func().IsNumber(InvID.Text) == false || InvID.Text == "")
                    MessageBox.Show("Invalid input");
                else
                    invTypeBox.Visible = false;
            }
            else
                invTypeBox.Visible = false;

            if (rbSales.Checked == true)
            {
                if (rbNormal.Checked == true)
                {
                 //   if (Out.Checked == false)
                   //     tbNo.Text = (IDIn + 1).ToString();
                    //else
                    //{
                        tbNo.Text = (IDOutN + 1).ToString();
                    //}
                }
                else
                {
                    tbNo.Text = (IDN + 1).ToString();
                }
            }
            else
            {
                tbNo.Text = InvID.Text;

            }

        }

        private void itemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(itemName, true, true, true, true);


                DataGridViewRow row = dgvSearchitem.Rows[0];
                    itemID = int.Parse(row.Cells[0].Value.ToString());

                    itemName.Text = ((row.Cells[1].Value.ToString()) + " - " + (row.Cells[2].Value.ToString()) );
                    dgvSearchitem.Visible = false;                

            }
        }

        private void itemPrice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(itemPrice, true, true, true, true);
                Additem();
            }

        }

        private void Additem()
        {

             if (itemName.Text == "" || itemPrice.Text == "" || itemQty.Text == "" || itemVat.Text == "")
            {
                MessageBox.Show("Empity field");
            }
            else if (new Func().IsNumber(itemPrice.Text) == false || new Func().IsNumber(itemQty.Text) == false
                || new Func().IsNumber(itemVat.Text) == false || double.Parse(itemQty.Text) <= 0)
            {
                MessageBox.Show("Invalid input");
            }         
            else
            {
                if ((rbpurchases.Checked != true) &&
                decimal.Parse(itemQty.Text) > qr.hasEnough(itemID))
                {
                    MessageBox.Show("You have just " + qr.hasEnough(itemID) + " in store");

                }

                double p = 0, q = 0
                 , vat = 0, Ivat = 0,
                 subtotal = 0, total = 0;

                if (included.Checked == true)
                {
                    vat = double.Parse(itemVat.Text);
                    p = double.Parse(itemPrice.Text) / (1 + vat / 100);

                    q = double.Parse(itemQty.Text);
                    Ivat = p * q * vat / 100;

                    subtotal = p * q; total = (p * q) + ((p * q) * vat) / 100;

                }
                else
                {
                    p = double.Parse(itemPrice.Text); q = double.Parse(itemQty.Text);
                    vat = double.Parse(itemVat.Text); Ivat = ((p * q) * vat) / 100;
                    subtotal = p * q; total = (p * q) + ((p * q) * vat) / 100;
                }

                if (rbNormal.Checked == false)
                {
                    Ivat = 0;
                    vat = 0;
                    total = subtotal;
                }

                p = Math.Round(p, 2);
                q = Math.Round(q, 2);
                Ivat = Math.Round(Ivat, 2);
                vat = Math.Round(vat, 2);
                subtotal = Math.Round(subtotal, 2);
                total = Math.Round(total, 2);

                InvoiceItem x = new InvoiceItem(itemID, q, p, subtotal, Ivat, total, itemName.Text);
                dgvInvoice.Rows.Add(x.itemID, x.name, x.qty, x.price, x.subtotal, x.vat, x.total);
                itemName.Text = "";
                itemPrice.Text = ""; itemQty.Text = ""; itemVat.Text = "5";
                dgvSearchitem.Visible = false;


                Tsubtotal.Text = (double.Parse(Tsubtotal.Text.ToString()) + subtotal).ToString();

                Tvat.Text = (double.Parse(Tvat.Text.ToString()) + Ivat).ToString();

                Ttotal.Text = (double.Parse(Ttotal.Text.ToString()) + total).ToString();



            }

        }
        private void itemQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(itemQty, true, true, true, true);
                
            }
        }

        private void custName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                    DataGridViewRow row = dgvCustomer.Rows[0];
                    if (row.Cells[0].Value.ToString() != "")
                    {
                        CustID = int.Parse(row.Cells[0].Value.ToString());
                    }
                No = int.Parse(row.Cells[2].Value.ToString());

                custName.Text = (row.Cells[1].Value.ToString());
                    dgvCustomer.Visible = false;
             

            }
        }

        private void Discount_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Discount.Text == "")
                {
                    MessageBox.Show("Empity field");
                }
                else if (new Func().IsNumber(Discount.Text) == false)
                {
                    MessageBox.Show("Invalid input");
                }
                else
                {

                    Ttotal.Text = (double.Parse(Ttotal.Text.ToString()) - (double.Parse(Discount.Text.ToString()))).ToString();
                    Tvat.Text = (double.Parse(Tvat.Text.ToString()) - (double.Parse(Discount.Text.ToString()) * 0.05)).ToString();
                    Tdiscount.Text = (double.Parse(Tdiscount.Text.ToString()) + (double.Parse(Discount.Text.ToString()))).ToString();
                    Discount.Text = "0";
                }

            }
        }
        private void itemVat_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IDN = qr.thisInvoiceN();
            IDOutN = qr.thisInvoiceOut();

            if (Out.Checked == false)
                tbNo.Text = (IDIn + 1).ToString();
            else
            {
               
                tbNo.Text = (IDOutN + 1).ToString();
            }


        }



        private void radioButton1_Click(object sender, EventArgs e)
        {
           
           
        }

       

      

        private void dgvSearchitem_CellContentClick(object sender, KeyPressEventArgs e)
        {
             
        }


        private void included_CheckedChanged(object sender, EventArgs e)
        {
           // if (included.Checked == true) { included.Checked = false; return; }
           // else if (included.Checked == false) { included.Checked = true; return; }

        }

        private void dgvInvoice_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInvoice.Rows[e.RowIndex];

                DialogResult dialogResult = MessageBox.Show("Do you want to delete item", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    Tsubtotal.Text = (double.Parse(Tsubtotal.Text) - double.Parse(row.Cells[4].Value.ToString())).ToString();
                    Tvat.Text = (double.Parse(Tvat.Text) - double.Parse(row.Cells[5].Value.ToString())).ToString();
                    Ttotal.Text = (double.Parse(Ttotal.Text) - double.Parse(row.Cells[6].Value.ToString())).ToString();

                    foreach (DataGridViewRow item in this.dgvInvoice.SelectedRows)
                    {
                        dgvInvoice.Rows.RemoveAt(item.Index);
                    }

                    dgvInvoice.Refresh();
                }
            }
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
                No = int.Parse(row.Cells[2].Value.ToString());

                custName.Text =(row.Cells[1].Value.ToString());
                dgvCustomer.Visible = false;
            }
            else
                dgvCustomer.Visible = false;

        }
    }
}

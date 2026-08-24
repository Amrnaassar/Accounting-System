using NumberToWord;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    public partial class UpdateInvForm : Form
    {
        DataTable O_table = new DataTable();
        int itemID = 0, CustID = 0, InvoiceID = 0, IDP = -1, IDIn = -1, IDN = -1, IDOut = -1, No = 0;
        string normal = "",numinWords="";
        DBquery qr = new DBquery();
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        public UpdateInvForm()
        {
            InitializeComponent();
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            itemVat.Text = "5";
            Discount.Text = "0";
            dgvCustomer.ReadOnly = true;
            dgvInvoice.ReadOnly = true;
            dgvSearchitem.ReadOnly = true;

        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInvoice.Rows[e.RowIndex];
                DialogResult dialogResult = MessageBox.Show("Do you want to delete item", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    Tsubtotal.Text= (double.Parse(Tsubtotal.Text)- double.Parse(row.Cells[4].Value.ToString())).ToString();
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

        private void btnFinish_Click(object sender, EventArgs e)
        {
            invTypeBox.Visible = true;

            SqlCommand cmd = new SqlCommand();

            
                if (rbSales.Checked == true)
                {

                    if (rbNormal.Checked == true)
                    {
                       

                        cmd.Connection = ConnectDB.cn;
                        ConnectDB.cn.Open();

                        foreach (DataRow row in O_table.Rows)
                        {
                            int itemID = int.Parse(row[0].ToString());
                            double Qty = double.Parse(row[2].ToString());

                            cmd.Connection = ConnectDB.cn;
                            cmd.CommandText = $"UPDATE Items SET amount=amount+@amount WHERE id = @id";

                            cmd.Parameters.Add("@amount", Qty);
                            cmd.Parameters.Add("@id", itemID);

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                        }

                        ConnectDB.cn.Close();

                        UpdateSalseNormal();

                    }
                    else
                    {
                        UpdateSalseNOTNormal();

                        cmd.Connection = ConnectDB.cn;
                        ConnectDB.cn.Open();

                        foreach (DataRow row in O_table.Rows)
                        {
                            int itemID = int.Parse(row[0].ToString());
                            double Qty = double.Parse(row[2].ToString());

                            cmd.Connection = ConnectDB.cn;
                            cmd.CommandText = $"UPDATE Items SET amount=amount+@amount WHERE id = @id";

                            cmd.Parameters.Add("@amount", Qty);
                            cmd.Parameters.Add("@id", itemID);

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                        }

                        ConnectDB.cn.Close();

                    }


                }
                else
                {
                    UpdatePurch();
                    cmd.Connection = ConnectDB.cn;
                    ConnectDB.cn.Open();

                    foreach (DataRow row in O_table.Rows)
                    {
                        int itemID = int.Parse(row[0].ToString());
                        double Qty = double.Parse(row[2].ToString());

                        cmd.Connection = ConnectDB.cn;
                        cmd.CommandText = $"UPDATE Items SET amount=amount-@amount WHERE id = @id";

                        cmd.Parameters.Add("@amount", Qty);
                        cmd.Parameters.Add("@id", itemID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();

                    }

                    ConnectDB.cn.Close();
                }


            

            dgvInvoice.DataSource = null;
            dgvInvoice.Rows.Clear();
            itemID = 0; CustID = 0; InvoiceID = 0;
            Tsubtotal.Text = "0";
            Tdiscount.Text = "0";
            Ttotal.Text = "0";
            Tvat.Text = "0";
            custName.Text = "";

        }

        private void UpdateSalseNormal()
        {
            Decimal a=0;
            if (new Func().IsNumberDouble(Ttotal.Text))
                a = Decimal.Parse(Ttotal.Text + "0");
            else
                a = Decimal.Parse(Ttotal.Text);

            a = Math.Round(a, 2);

            ToWord toWord = new ToWord(Convert.ToDecimal(a), currencies[0]);
            string arabic = toWord.ConvertToArabic();

            InvoiceID = int.Parse(tbNo.Text);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE InvoiceS SET date = @date, details = @details,total=@total"+
                                " ,subTotal=@subTotal,discount=@discount,vat=@vat,custName=@custName" +
                                ",custID=@custID,NoInWords=@NoInWords WHERE id = @id";
            cmd.Parameters.Add("@date", dateTimePicker1.Value);
            cmd.Parameters.Add("@details", Details.Text);
            cmd.Parameters.Add("@total", (double.Parse(Ttotal.Text.ToString())));
            cmd.Parameters.Add("@id", InvoiceID);
            cmd.Parameters.Add("@subTotal", (double.Parse(Tsubtotal.Text.ToString())));
            cmd.Parameters.Add("@discount", (double.Parse(Tdiscount.Text.ToString())));
            cmd.Parameters.Add("@vat", (double.Parse(Tvat.Text.ToString())));
            cmd.Parameters.Add("@custName", custName.Text);
            cmd.Parameters.Add("@custID", CustID);
            cmd.Parameters.Add("@NoInWords", arabic);

            ConnectDB.cn.Open();
            cmd.ExecuteReader();    
            ConnectDB.cn.Close();
            cmd.Parameters.Clear();

            cmd.Connection = ConnectDB.cn;
            ConnectDB.cn.Open();

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

            ConnectDB.cn.Close();



            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"DELETE FROM InvoiceItem WHERE invoiceID = @id";

            cmd.Parameters.Add("@id", InvoiceID);
            ConnectDB.cn.Open();
            
                cmd.ExecuteReader();
            
            ConnectDB.cn.Close();

            cmd.Parameters.Clear();
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

                    if (rbpurchases.Checked == true)
                    {
                        cmd.CommandText = $"Insert into InvoicePItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                        $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
                    }
                    if (rbSales.Checked == true)
                    {
                        if (rbNormal.Checked == false)
                            cmd.CommandText = $"Insert into InvoiceItemN(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                            $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
                        else
                            cmd.CommandText = $"Insert into InvoiceItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                             $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
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




        }
        private void UpdateSalseNOTNormal()
        {
            Decimal a = 0;
            if (new Func().IsNumberDouble(Ttotal.Text))
                a = Decimal.Parse(Ttotal.Text + "0");
            else
                a = Decimal.Parse(Ttotal.Text);

            a = Math.Round(a, 2);

            ToWord toWord = new ToWord(Convert.ToDecimal(a), currencies[0]);
            string arabic = toWord.ConvertToArabic();

            InvoiceID = int.Parse(tbNo.Text);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE InvoiceSN SET date = @date, details = @details,total=@total" +
                                " ,subTotal=@subTotal,discount=@discount,vat=@vat,custName=@custName" +
                                ",custID=@custID,NoInWords=@NoInWords WHERE id = @id";
            cmd.Parameters.Add("@date", dateTimePicker1.Value);
            cmd.Parameters.Add("@details", Details.Text);
            cmd.Parameters.Add("@total", (double.Parse(Ttotal.Text.ToString())));
            cmd.Parameters.Add("@id", InvoiceID);
            cmd.Parameters.Add("@subTotal", (double.Parse(Tsubtotal.Text.ToString())));
            cmd.Parameters.Add("@discount", (double.Parse(Tdiscount.Text.ToString())));
            cmd.Parameters.Add("@vat", (double.Parse(Tvat.Text.ToString())));
            cmd.Parameters.Add("@custName", custName.Text);
            cmd.Parameters.Add("@custID", CustID);
            cmd.Parameters.Add("@NoInWords", arabic);

            ConnectDB.cn.Open();
            cmd.ExecuteReader();
            ConnectDB.cn.Close();
            cmd.Parameters.Clear();


            cmd.Connection = ConnectDB.cn;
            ConnectDB.cn.Open();

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

            ConnectDB.cn.Close();



            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"DELETE FROM InvoiceItemN WHERE invoiceID = @id";

            cmd.Parameters.Add("@id", InvoiceID);
            ConnectDB.cn.Open();

            cmd.ExecuteReader();

            ConnectDB.cn.Close();

            cmd.Parameters.Clear();
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

                    if (rbpurchases.Checked == true)
                    {
                        cmd.CommandText = $"Insert into InvoicePItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                        $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
                    }
                    if (rbSales.Checked == true)
                    {
                        if (rbNormal.Checked == false)
                            cmd.CommandText = $"Insert into InvoiceItemN(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                            $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
                        else
                            cmd.CommandText = $"Insert into InvoiceItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                             $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
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




        }

        private void UpdatePurch()
        {
            Decimal a = 0;
            if (new Func().IsNumberDouble(Ttotal.Text))
                a = Decimal.Parse(Ttotal.Text + "0");
            else
                a = Decimal.Parse(Ttotal.Text);

            a = Math.Round(a, 2);

            ToWord toWord = new ToWord(Convert.ToDecimal(a), currencies[0]);
            string arabic = toWord.ConvertToArabic();

            InvoiceID = int.Parse(tbNo.Text);
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE InvoicePurch SET date = @date, details = @details,total=@total" +
                                " ,subTotal=@subTotal,discount=@discount,vat=@vat,custName=@custName" +
                                ",custID=@custID,NoInWords=@NoInWords WHERE invoice_id = @id";
            cmd.Parameters.Add("@date", dateTimePicker1.Value);
            cmd.Parameters.Add("@details", Details.Text);
            cmd.Parameters.Add("@total", (double.Parse(Ttotal.Text.ToString())));
            cmd.Parameters.Add("@id", InvoiceID);
            cmd.Parameters.Add("@subTotal", (double.Parse(Tsubtotal.Text.ToString())));
            cmd.Parameters.Add("@discount", (double.Parse(Tdiscount.Text.ToString())));
            cmd.Parameters.Add("@vat", (double.Parse(Tvat.Text.ToString())));
            cmd.Parameters.Add("@custName", custName.Text);
            cmd.Parameters.Add("@custID", CustID);
            cmd.Parameters.Add("@NoInWords", arabic);

            ConnectDB.cn.Open();
            cmd.ExecuteReader();
            ConnectDB.cn.Close();
            cmd.Parameters.Clear();



            cmd.Connection = ConnectDB.cn;
            ConnectDB.cn.Open();

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

            ConnectDB.cn.Close();






            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"DELETE FROM InvoicePItem WHERE invoiceID = @id";

            cmd.Parameters.Add("@id", InvoiceID);
            ConnectDB.cn.Open();

            cmd.ExecuteReader();

            ConnectDB.cn.Close();

            cmd.Parameters.Clear();
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

                    if (rbpurchases.Checked == true)
                    {
                        cmd.CommandText = $"Insert into InvoicePItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                        $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
                    }
                    if (rbSales.Checked == true)
                    {
                        if (rbNormal.Checked == false)
                            cmd.CommandText = $"Insert into InvoiceItemN(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                            $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
                        else
                            cmd.CommandText = $"Insert into InvoiceItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                             $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
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

        private void apply_Click(object sender, EventArgs e)
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

        private void applySalseNormal()
        {
            dgvInvoice.Rows.Clear();
            
            DataTable dt = new DataTable();
            DataTable d = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT  [itemID],[invoiceID],[name],[Qty],[price],[itemsubtotal],[itemVAT],[itemtotal],[cancel] FROM[ShopDB].[dbo].[InvoiceItem] where[invoiceID] =@id";
            cmd.Parameters.Add("@id",  int.Parse(UpdateNo.Text) );

            ConnectDB.cn.Open();
            
                dt.Load(cmd.ExecuteReader());
         
            ConnectDB.cn.Close();
            cmd.Parameters.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int itemID = int.Parse(row[0].ToString());
                double p = 0, q = 0
                , vat = 0, Ivat = 0,
                subtotal = 0, total = 0;
                q = double.Parse(row[3].ToString());
                p = double.Parse(row[4].ToString());
                subtotal = double.Parse(row[5].ToString());
                Ivat = double.Parse(row[6].ToString());
                total = double.Parse(row[7].ToString());
               string name = (row[2].ToString());

                InvoiceItem x = new InvoiceItem(itemID, q, p, subtotal, Ivat, total, name);

                dgvInvoice.Rows.Add(x.itemID, x.name, x.qty, x.price, x.subtotal, x.vat, x.total);

            }
           
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT [id],[date],[details],[total],[subTotal],[discount],[vat],[custName],[custID],[type],[normal],[NoInWords],[cancel] FROM[ShopDB].[dbo].[InvoiceS]  where[id] = @id";
            cmd.Parameters.Add("@id", int.Parse(UpdateNo.Text));

            ConnectDB.cn.Open();
         
                d.Load(cmd.ExecuteReader());
            ConnectDB.cn.Close();
            cmd.Parameters.Clear();

            foreach (DataRow r in d.Rows)
            {
                tbNo.Text = r[0].ToString();
                String[] arr = r[1].ToString().Trim().Split('-');

                CultureInfo culture = new CultureInfo("en-US");
                DateTime tempDate = Convert.ToDateTime(r[1].ToString(), culture);
                dateTimePicker1.Value = tempDate; 
                
                Details.Text = r[2].ToString();
                Ttotal.Text = r[3].ToString();
                Tsubtotal.Text = r[4].ToString();
                Tdiscount.Text = r[5].ToString();
                Tvat.Text = r[6].ToString();
                custName.Text = r[7].ToString();
                CustID = int.Parse(r[8].ToString());
                normal= r[10].ToString();
                numinWords= r[11].ToString();
                break;
            }

            
        }

        private void tbNo_Click(object sender, EventArgs e)
        {

        }

       
        private void itemName1_TextChanged(object sender, EventArgs e)
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

        private void btnDesign1_Click(object sender, EventArgs e)
        {

            {
                invTypeBox.Visible = false;


                SqlCommand cmd = new SqlCommand();
                if (rbSales.Checked == true)
                {

                    if (rbNormal.Checked == true)
                    {
                        applySalseNormal();



                    }
                    else
                    {
                        applySalseNOTNormal();


                    }


                }
                else
                {
                    applyPurch();

                }

                foreach (DataGridViewColumn col in dgvInvoice.Columns)
                {
                    O_table.Columns.Add(col.Name);
                }

                foreach (DataGridViewRow row in dgvInvoice.Rows)
                {
                    DataRow dRow = O_table.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    O_table.Rows.Add(dRow);
                }

             //   MessageBox.Show(O_table.Rows.Count + "");


            }
        }

        private void included1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

       

      

        private void dgvSearchitem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(itemName, true, true, true, true);


                DataGridViewRow row = dgvSearchitem.Rows[0];
                itemID = int.Parse(row.Cells[0].Value.ToString());

                itemName.Text = ((row.Cells[1].Value.ToString()) + " - " + (row.Cells[2].Value.ToString()));
                dgvSearchitem.Visible = false;

            }
        }

        private void applyPurch()
        {

            dgvInvoice.Rows.Clear();

            DataTable dt = new DataTable();
            DataTable d = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT  [itemID],[invoiceID],[name],[Qty],[price],[itemsubtotal],[itemVAT],[itemtotal] FROM [ShopDB].[dbo].[InvoicePItem] where[invoiceID] =@id";
            cmd.Parameters.Add("@id", int.Parse(UpdateNo.Text));

            ConnectDB.cn.Open();

            dt.Load(cmd.ExecuteReader());

            ConnectDB.cn.Close();
            cmd.Parameters.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int itemID = int.Parse(row[0].ToString());
                double p = 0, q = 0
                , vat = 0, Ivat = 0,
                subtotal = 0, total = 0;
                q = double.Parse(row[3].ToString());
                p = double.Parse(row[4].ToString());
                subtotal = double.Parse(row[5].ToString());
                Ivat = double.Parse(row[6].ToString());
                total = double.Parse(row[7].ToString());
                string name = (row[2].ToString());

                InvoiceItem x = new InvoiceItem(itemID, q, p, subtotal, Ivat, total, name);

                dgvInvoice.Rows.Add(x.itemID, x.name, x.qty, x.price, x.subtotal, x.vat, x.total);

            }

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT * FROM[ShopDB].[dbo].[InvoicePurch]  where [invoice_id] = @id";
            cmd.Parameters.Add("@id", int.Parse(UpdateNo.Text));

            ConnectDB.cn.Open();

            d.Load(cmd.ExecuteReader());
            ConnectDB.cn.Close();
            cmd.Parameters.Clear();

            foreach (DataRow r in d.Rows)
            {
                tbNo.Text = r[1].ToString();
                String[] arr = r[2].ToString().Trim().Split('-');


                dateTimePicker1.Value = DateTime.Parse(r[2].ToString());

                Details.Text = r[3].ToString();
                Ttotal.Text = r[4].ToString();
                Tsubtotal.Text = r[5].ToString();
                Tdiscount.Text = r[6].ToString();
                Tvat.Text = r[7].ToString();
                custName.Text = r[8].ToString();
                CustID = int.Parse(r[9].ToString());
                normal = r[10].ToString();
                numinWords = r[11].ToString();
                break;
            }


        }
        private void applySalseNOTNormal()
        {
            dgvInvoice.Rows.Clear();

            DataTable dt = new DataTable();
            DataTable d = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT  [itemID],[invoiceID],[name],[Qty],[price],[itemsubtotal],[itemVAT],[itemtotal] FROM [ShopDB].[dbo].[InvoiceItemN] where[invoiceID] =@id";
            cmd.Parameters.Add("@id", int.Parse(UpdateNo.Text));

            ConnectDB.cn.Open();

            dt.Load(cmd.ExecuteReader());

            ConnectDB.cn.Close();
            cmd.Parameters.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int itemID = int.Parse(row[0].ToString());
                double p = 0, q = 0
                , vat = 0, Ivat = 0,
                subtotal = 0, total = 0;
                q = double.Parse(row[3].ToString());
                p = double.Parse(row[4].ToString());
                subtotal = double.Parse(row[5].ToString());
                Ivat = double.Parse(row[6].ToString());
                total = double.Parse(row[7].ToString());
                string name = (row[2].ToString());

                InvoiceItem x = new InvoiceItem(itemID, q, p, subtotal, Ivat, total, name);

                dgvInvoice.Rows.Add(x.itemID, x.name, x.qty, x.price, x.subtotal, x.vat, x.total);

            }

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"SELECT * FROM[ShopDB].[dbo].[InvoiceSN]  where[id] = @id";
            cmd.Parameters.Add("@id", int.Parse(UpdateNo.Text));

            ConnectDB.cn.Open();

            d.Load(cmd.ExecuteReader());
            ConnectDB.cn.Close();
            cmd.Parameters.Clear();

            foreach (DataRow r in d.Rows)
            {
                tbNo.Text = r[0].ToString();
                String[] arr = r[1].ToString().Trim().Split('-');


                dateTimePicker1.Value = DateTime.Parse(r[1].ToString());

                Details.Text = r[2].ToString();
                Ttotal.Text = r[3].ToString();
                Tsubtotal.Text = r[4].ToString();
                Tdiscount.Text = r[5].ToString();
                Tvat.Text = r[6].ToString();
                custName.Text = r[7].ToString();
                CustID = int.Parse(r[8].ToString());
                normal = r[10].ToString();
                numinWords = r[11].ToString();
                break;
            }


        }

        private void UpdateInvForm_Load(object sender, EventArgs e)
        {

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
        private void btnAdditem1_Click(object sender, EventArgs e)
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

                double p = 0, q = 0
                 , vat = 0, Ivat = 0,
                 subtotal = 0, total = 0;

                if (included.Checked == true)
                {
                    vat = double.Parse(itemVat.Text);
                    p = double.Parse(itemPrice.Text) / (1 + vat / 100);

                    Ivat = p * vat / 100;
                    q = double.Parse(itemQty.Text);
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
            if (included.Checked == true) { included.Checked = false; }
        }

      

        private void dgvSearchitem1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSearchitem.Rows[e.RowIndex];
                itemID = int.Parse(row.Cells[0].Value.ToString());

                itemName.Text = ((row.Cells[1].Value.ToString()) + " - " + (row.Cells[2].Value.ToString()));

                dgvSearchitem.Visible = false;
            }
        }

        private void custName_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.Visible = true;
            DBquery pr = new DBquery();
            pr.searchCustomerInvoice(custName.Text);
            dgvCustomer.DataSource = pr.dt;
            dgvCustomer.Columns[0].HeaderText = "Customer TRN";
            dgvCustomer.Columns[1].HeaderText = "Name";
            dgvCustomer.Columns[2].HeaderText = "NO.";

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
                    No = int.Parse(row.Cells[2].Value.ToString());
                }
                custName.Text = (row.Cells[1].Value.ToString());
                dgvCustomer.Visible = false;
            }
            else
                dgvCustomer.Visible = false;
        }



        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemVat1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemQty1_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl(itemName, true, true, true, true);
            }
        }

        private void itemQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(itemQty, true, true, true, true);
            }

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemPrice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Details_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

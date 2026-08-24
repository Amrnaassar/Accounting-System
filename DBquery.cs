using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApp
{
    class DBquery
    {
        public DataTable dt = new DataTable();
        public DataTable dt2 = new DataTable();

        SqlCommand cmd = new SqlCommand();


        public void PrintInvoice(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"PrintInvoice";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            ConnectDB.cn.Open();
            dt.Clear();
            dt.Load(cmd.ExecuteReader());
            ConnectDB.cn.Close();
        }
        public void PrintInvoiceNot(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"PrintInvNotNormal";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            ConnectDB.cn.Open();
            dt.Clear();
            dt.Load(cmd.ExecuteReader());
            ConnectDB.cn.Close();
        }
        public void PrintPaymentV(int id)
        {
            dt.Rows.Clear();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"PrPaymentVoucher";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            ConnectDB.cn.Open();
            dt.Clear();
            dt.Load(cmd.ExecuteReader());
            ConnectDB.cn.Close();
        }
        public void PrintReceiptV(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = $"PrReceiptVoucher";

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            ConnectDB.cn.Open();
            dt.Clear();
            dt.Load(cmd.ExecuteReader());
            ConnectDB.cn.Close();
        }
        public void showProducts()
        {
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select * from Items";

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();
        }
        public void showCustomers()
        {
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select * from Customers";

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();
        }

        public void Insertitem(string name, double price, string type, double amount, string part)
        {
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"Insert into Items(name,price,type,amount,part)values (@name,@price,@type,@amount,@part)";
            cmd.Parameters.Add("@name", name);
            cmd.Parameters.Add("@price", price);
            cmd.Parameters.Add("@type", type);
            cmd.Parameters.Add("@amount", amount);
            cmd.Parameters.Add("@part", part);

            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }


            ConnectDB.cn.Close();

        }
        public void Updateitem(int id, string name, double price, string type, double amount, string part
            )
        {
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE Items SET name = @name, price = @price,type=@type ,amount=@amount,part=@part WHERE id = @id";
            cmd.Parameters.Add("@name", name);
            cmd.Parameters.Add("@price", price);
            cmd.Parameters.Add("@type", type);
            cmd.Parameters.Add("@id", id);
            cmd.Parameters.Add("@amount", amount);
            cmd.Parameters.Add("@part", part);

            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void deleteitem(int id)
        {
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"DELETE FROM Items WHERE id = @id";

            cmd.Parameters.Add("@id", id);
            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvID(String name)
        {
            int id = 0;
            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);
            else return;
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total,cancel from InvoiceS WHERE id LIKE @id";
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }

        public void searchVoRName(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total from ReceiptVoucher WHERE CustName LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchVopName(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total from PaymentVoucher WHERE CustName LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchVoPDate(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total from PaymentVoucher WHERE date LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchVoRNDate(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total from ReceiptVoucher WHERE date LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchVoPID(String name)
        {
            int id = 0;
            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);
            else return;
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total from PaymentVoucher WHERE id LIKE @id";
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchVoRID(String name)
        {
            int id = 0;
            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);
            else return;
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total from ReceiptVoucher WHERE id LIKE @id";
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvNID(String name)
        {
            int id = 0;
            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);
            else return;
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total,cancel from InvoiceSN WHERE id LIKE @id";
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvNPID(String name)
        {
            int id = 0;
            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);
            else return;
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select invoice_id,custName,date,total,cancel from InvoicePurch WHERE invoice_id LIKE @id and normal='NO'";
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }

        public void searchInvName(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total,cancel from InvoiceS WHERE CustName LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvNName(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total,cancel from InvoiceSN WHERE CustName LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public DataTable Accounting(int x)
        {

            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select date,details,debit,credit from Account WHERE custID = @id";
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
        public void searchInvNPName(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select invoice_id,custName,date,total,cancel from InvoicePurch  WHERE CustName LIKE @id and normal='NO'";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvDate(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total,cancel from InvoiceS WHERE date LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvNDate(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,custName,date,total,cancel from InvoiceSN WHERE date LIKE @id";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvNPDate(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select invoice_id,custName,date,total,cancel from InvoicePurch WHERE date LIKE @id and normal='NO'";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }

        public void searchInvPID(String name)
        {
            int id = 0;
            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);
            else return;
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select invoice_id,custName,date,total,cancel from InvoicePurch WHERE invoice_id LIKE @id and normal='YES'";
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvPName(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select invoice_id,custName,date,total,cancel from InvoicePurch WHERE CustName LIKE @id and normal='YES'";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchInvPDate(String x)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select invoice_id,custName,date,total,cancel from InvoicePurch WHERE date LIKE @id and normal='YES'";
            cmd.Parameters.Add("@id", "%" + x + "%");

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchitem(String name)
        {
            int id = 0;

            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);


            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select * from Items WHERE name LIKE @name OR id LIKE @id OR part LIKE @name";
            cmd.Parameters.Add("@name", "%" + name + "%");
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void showitems(String name)
        {
            int id = 0;

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select id,name,type from Items WHERE name LIKE @name";

            cmd.Parameters.Add("@name", "%" + name + "%");
            ConnectDB.cn.Open();

            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();
        }
        public void InsertCusomer(string name, string phone, string Fax)
        {
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"Insert into Customers(CustName,Phone,Fax)values (@name,@Phone,@Fax)";
            cmd.Parameters.Add("@name", name);
            cmd.Parameters.Add("@Phone", phone);
            cmd.Parameters.Add("@Fax", Fax);

            ConnectDB.cn.Open();

            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void UpdateCustomer(int id, string name, string phone, string Fax)
        {
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE Customers SET CustName = @name, Phone = @Phone,Fax=@Fax WHERE id = @id";
            cmd.Parameters.Add("@name", name);
            cmd.Parameters.Add("@Phone", phone);
            cmd.Parameters.Add("@Fax", Fax);
            cmd.Parameters.Add("@id", id);


            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void deleteCustomer(int id)
        {
            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"DELETE FROM Customers WHERE id = @id";

            cmd.Parameters.Add("@id", id);
            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchCustomer(String name)
        {
            int id = 0;

            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);


            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select * from Customers WHERE CustName LIKE @name OR id LIKE @id";
            cmd.Parameters.Add("@name", "%" + name + "%");
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void searchCustomerInvoice(String name)
        {
            int id = 0;

            if (name != "" && new Func().IsNumber(name) == true) id = int.Parse(name);


            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"select Fax,CustName,id from Customers WHERE CustName LIKE @name OR Fax LIKE @id";
            cmd.Parameters.Add("@name", "%" + name + "%");
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                dt.Load(cmd.ExecuteReader());
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }

        public void InsertInvoice(int id, DateTimePicker date, string details, string custName, int custID, double total, double subtotal,
            double discount, double vat, string s, string nor, string NIW)
        {

            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"Insert into InvoiceS(id,date,details,total,subTotal,discount,vat,custName,custID,type,normal,NoInWords)" +
                $"values (@id,@date,@details,@total,@subTotal,@discount,@vat,@custName,@custID,@type,@normal,@NIW)";
            cmd.Parameters.Add("@id", id);
            cmd.Parameters.Add("@date", date.Value);
            cmd.Parameters.Add("@details", details);
            cmd.Parameters.Add("@total", total);
            cmd.Parameters.Add("@subTotal", subtotal);
            cmd.Parameters.Add("@discount", discount);
            cmd.Parameters.Add("@vat", vat);
            cmd.Parameters.Add("@custName", custName);
            cmd.Parameters.Add("@custID", custID);
            cmd.Parameters.Add("@type", s);
            cmd.Parameters.Add("@normal", nor);
            cmd.Parameters.Add("@NIW", NIW);

            ConnectDB.cn.Open();


            cmd.ExecuteReader();

            ConnectDB.cn.Close();

        }

        public void InsertInvoiceSN(int id, DateTimePicker date, string details, string custName, int custID, double total, double subtotal,
          double discount, double vat, string s, string nor, string NIW)
        {
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"Insert into InvoiceSN(id,date,details,total,subTotal,discount,vat,custName,custID,type,normal,NoInWords)" +
                $"values (@id,@date,@details,@total,@subTotal,@discount,@vat,@custName,@custID,@type,@normal,@NIW)";
            cmd.Parameters.Add("@id", id);
            cmd.Parameters.Add("@date", date.Value);
            cmd.Parameters.Add("@details", details);
            cmd.Parameters.Add("@total", total);
            cmd.Parameters.Add("@subTotal", subtotal);
            cmd.Parameters.Add("@discount", discount);
            cmd.Parameters.Add("@vat", vat);
            cmd.Parameters.Add("@custName", custName);
            cmd.Parameters.Add("@custID", custID);
            cmd.Parameters.Add("@type", s);
            cmd.Parameters.Add("@normal", nor);
            cmd.Parameters.Add("@NIW", NIW);

            ConnectDB.cn.Open();

            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }
        public void InsertInvoicePurch(int id, int invID, DateTimePicker date, string details, string custName, int custID, double total, double subtotal,
            double discount, double vat, string nor, string NIW)
        {
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"Insert into InvoicePurch(id,invoice_id,date,details,total,subTotal,discount,vat,custName,custID,normal,NoInWords)" +
                $"values (@id,@invID,@date,@details,@total,@subTotal,@discount,@vat,@custName,@custID,@normal,@NIW)";
            cmd.Parameters.Add("@id", id);
            cmd.Parameters.Add("@invID", invID);
            cmd.Parameters.Add("@date", date.Value);
            cmd.Parameters.Add("@details", details);
            cmd.Parameters.Add("@total", total);
            cmd.Parameters.Add("@subTotal", subtotal);
            cmd.Parameters.Add("@discount", discount);
            cmd.Parameters.Add("@vat", vat);
            cmd.Parameters.Add("@custName", custName);
            cmd.Parameters.Add("@custID", custID);
            cmd.Parameters.Add("@normal", nor);
            cmd.Parameters.Add("@NIW", NIW);

            ConnectDB.cn.Open();


            cmd.ExecuteReader();

            ConnectDB.cn.Close();

        }
        public decimal hasEnough(int id)
        {
            DataTable dth = new DataTable();
            dt.Rows.Clear();
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"SELECT amount FROM Items WHERE id LIKE @id";
            ConnectDB.cn.Open();
            cmd.Parameters.Add("@id", id);
            decimal number = -1;
            try
            {
                dth.Load(cmd.ExecuteReader());
                number = dth.Rows[0].Field<decimal>(0);
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
        public void Decamount(int id, double amount)
        {

            cmd.Connection = ConnectDB.cn;
            cmd.CommandText = $"UPDATE Items SET amount=amount-@amount WHERE id = @id";

            cmd.Parameters.Add("@amount", amount);
            cmd.Parameters.Add("@id", id);

            ConnectDB.cn.Open();
            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            cmd.Parameters.Clear();
            ConnectDB.cn.Close();

        }
        public int thisInvoiceN()
        {
            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"SELECT TOP 1 id FROM[ShopDB].[dbo].[InvoiceSN] where normal != 'OUT' ORDER BY id DESC";

            ConnectDB.cn.Open();
            int number = 4357;
            try
            {
                dt.Load(cmd.ExecuteReader()); number = dt.Rows[0].Field<int>(0);
            }
            catch { ConnectDB.cn.Close(); }

            ConnectDB.cn.Close();
            return number;

        }
        public int thisInvoice()
        {
            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"SELECT TOP 1 id FROM[ShopDB].[dbo].[InvoiceS] where normal='IN' ORDER BY id DESC";

            ConnectDB.cn.Open();
            int number = 0;
            try
            {
                dt.Load(cmd.ExecuteReader()); number = dt.Rows[0].Field<int>(0);
            }
            catch { ConnectDB.cn.Close(); }

            ConnectDB.cn.Close();
            return number;

        }
        public int thisInvoiceOut()
        {
            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"SELECT TOP 1 id FROM[ShopDB].[dbo].[InvoiceS]  ORDER BY id DESC";

            ConnectDB.cn.Open();
            int number = 10531;
            try
            {
                dt.Load(cmd.ExecuteReader()); 
                number = dt.Rows[0].Field<int>(0);
            }
            catch { ConnectDB.cn.Close(); }

            ConnectDB.cn.Close();
            return number;

        }
        public int thisInvoicePu()
        {
            DataTable dt = new DataTable();
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"SELECT TOP 1 id FROM[ShopDB].[dbo].[InvoicePurch] ORDER BY id DESC";

            ConnectDB.cn.Open();
            int number = 0;
            try
            {
                dt.Load(cmd.ExecuteReader());
                number = dt.Rows[0].Field<int>(0);
            }
            catch { ConnectDB.cn.Close(); }

            ConnectDB.cn.Close();
            return number;

        }
        public int thisPaymentV()
        {
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"SELECT TOP 1 id FROM PaymentVoucher ORDER BY id DESC";

            ConnectDB.cn.Open();
            int number = 637;
            try
            {
                dt.Load(cmd.ExecuteReader());
                number = dt.Rows[0].Field<int>(0);
            }
            catch { ConnectDB.cn.Close(); }

            ConnectDB.cn.Close();
            return number;

        }
        public int thisReceiptV()
        {
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"SELECT TOP 1 id FROM ReceiptVoucher ORDER BY id DESC";

            ConnectDB.cn.Open();
            int number = 11;
            try
            {
                dt.Load(cmd.ExecuteReader());
                number = dt.Rows[0].Field<int>(0);
            }
            catch { ConnectDB.cn.Close(); }

            ConnectDB.cn.Close();
            return number;

        }
        public void InsertInvoiceItem(int itemID, int invoiceID, string name, double Qty, double price,
            double subtotal, double VAT, double total)
        {
            cmd.Connection = ConnectDB.cn;

            cmd.CommandText = $"Insert into InvoiceItem(itemID,invoiceID,name,Qty,price,itemsubtotal,itemVAT,itemtotal)" +
                $"values (@itemID,@invoiceID,@name,@Qty,@price,@stotal,@IVAT,@Itotal)";
            cmd.Parameters.Add("@itemID", itemID);
            cmd.Parameters.Add("@invoiceID", invoiceID);
            cmd.Parameters.Add("@name", name);
            cmd.Parameters.Add("@Qty", Qty);
            cmd.Parameters.Add("@price", price);
            cmd.Parameters.Add("@stotal", subtotal);
            cmd.Parameters.Add("@IVAT", VAT);
            cmd.Parameters.Add("@Itotal", total);

            ConnectDB.cn.Open();

            try
            {
                cmd.ExecuteReader();
            }
            catch { ConnectDB.cn.Close(); }
            ConnectDB.cn.Close();

        }

        public void InsertAccount(DateTimePicker date, int custID, string custName, string details, double credit, double debit)
        {
            cmd.Connection = ConnectDB.cn;
            cmd.Parameters.Clear();

            cmd.CommandText = $"Insert into Account(date,custID,custName,details,credit,debit)" +
                $"values (@date,@custID,@custName,@details,@credit,@debit)";

            cmd.Parameters.Add("@date", date.Value);
            cmd.Parameters.Add("@details", details);
            cmd.Parameters.Add("@credit", credit);
            cmd.Parameters.Add("@debit", debit);

            cmd.Parameters.Add("@custName", custName);
            cmd.Parameters.Add("@custID", custID);


            ConnectDB.cn.Open();


            cmd.ExecuteReader();

            cmd.Parameters.Clear();
            ConnectDB.cn.Close();

        }



    }
}

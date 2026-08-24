using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApp
{
    class InvoiceItem
    {
       public int itemID;
       public double qty, price, subtotal, vat, total;
       public string name;

        public InvoiceItem(int itemID,  double qty, double price,
            double subtotal, double vat, double total, string name)
        {
            this.itemID = itemID;
            this.qty = qty;
            this.price = price;
            this.subtotal = subtotal;
            this.vat = vat;
            this.total = total;
            this.name = name;
        }
    }
}

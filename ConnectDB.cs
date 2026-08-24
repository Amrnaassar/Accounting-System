using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccountingApp
{
    class ConnectDB
    {
        public static SqlConnection cn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ShopDB; Integrated Security=True;MultipleActiveResultSets=true");

       // public static SqlConnection cn =new SqlConnection("Data Source=DESKTOP-IOJ7RS1\\SQLEXPRESS;Initial Catalog=ShopDB; Integrated Security=True;MultipleActiveResultSets=true");
    }
}

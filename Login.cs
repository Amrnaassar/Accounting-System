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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDesign1_Click(object sender, EventArgs e)
        {
            /*
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectDB.cn;
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.CommandText = $"loginEmp";

            cmd.Parameters.Add("@empCode", SqlDbType.Int).Value =int.Parse(tbCode.Text.ToString());
            ConnectDB.cn.Open();
            
            dt.Load(cmd.ExecuteReader());
            */
            if(tbCode.Text.ToString()!="123456")
            {
                MessageBox.Show("Error");
            }
            else
            {
                this.Close();
                Thread th = new Thread(openform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
               
               
            }
            ConnectDB.cn.Close();
        }

        private void openform(object obj)
        {
            Application.Run( new Form1());
           
        }

        private void tbCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

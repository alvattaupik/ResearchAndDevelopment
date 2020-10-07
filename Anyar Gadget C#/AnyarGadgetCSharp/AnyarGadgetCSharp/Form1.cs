using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AnyarGadgetCSharp
{




    public partial class Form1 : Form
    {

        class Koneksi
        {
            public System.Data.SqlClient.SqlConnection GetKoneksi()
            {
                //System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
                //conn.ConnectionString = "Data Source=10.1.0.53; Initial Catalog=DB_EMAIL;user=sa; Password=h0spit4lity#";
                //return conn;

                try
                {
                    SqlConnection SqlConn = new SqlConnection();
                    SqlConn.ConnectionString = "Data Source=10.1.0.53;" +
                                               "Initial Catalog=DB_EMAIL;" +
                                               "User Id=sa;" +
                                               "Password=h0spit4lity#;";
                    if (SqlConn.State == ConnectionState.Open) SqlConn.Close();
                    SqlConn.Open();
                    return SqlConn;
                   
                    //MessageBox.Show("Connection successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ups..something wrong, " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }






        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
         

        }
    }
}

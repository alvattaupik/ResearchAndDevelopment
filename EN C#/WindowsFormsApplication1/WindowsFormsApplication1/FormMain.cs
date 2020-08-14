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

namespace WindowsFormsApplication1
{
    public partial class FormMain : Form
    {


        public FormMain()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            
            connetionString = "Data Source=10.1.0.53;Initial Catalog=DB_EMAIL;User ID=sa;Password=h0spit4lity#";
            connection = new SqlConnection(connetionString);

            string query = "Select * from UserLogin";

            try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();

                    dAdapter.Fill(ds);

                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = ds.Tables[0];


                    MessageBox.Show("Koneksi Berhasil Terhubung!!");
                    connection.Close();
                }
                catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
        }


    }





}

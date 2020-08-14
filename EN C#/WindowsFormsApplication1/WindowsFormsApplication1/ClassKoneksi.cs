using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
   public class Connection_Query  
    {  
  
        string ConnectionString = "Data Source=10.1.0.53;" +
                                  "Initial Catalog=DB_EMAIL;" +
                                  "User id=sa;" +
                                  "Password=h0spit4lity#;MultipleActiveResultSets=True";
        SqlConnection conn;  
  
        public void OpenConection()  
        {  
            conn = new SqlConnection(ConnectionString);  
            conn.Open();  
        }  
  
  
        public void CloseConnection()  
        {  
            conn.Close();  
        }  
  
  
        public void ExecuteQueries(string Query_)  
        {  
            SqlCommand cmd = new SqlCommand(Query_,conn);  
            cmd.ExecuteNonQuery();  
        }  
  
  
        public SqlDataReader DataReader(string Query_)  
        {  
            SqlCommand cmd = new SqlCommand(Query_,conn);  
            SqlDataReader dr = cmd.ExecuteReader();  
            return dr;  
        }  
  
  
        public object ShowDataInGridView(string Query_)  
        {  
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);  
            DataSet ds = new DataSet();  
            dr.Fill(ds);  
            object dataum = ds.Tables[0];  
            return dataum;  
        }  
    }  
}  


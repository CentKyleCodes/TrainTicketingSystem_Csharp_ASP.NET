using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTuto
{
    internal class Functions
    {
        SqlConnection Con;
        SqlDataAdapter Sda;
        DataTable dt;
        SqlCommand Cmd;
        string ConStr;
        public Functions()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kylev\source\repos\TrainTuto\TrainTuto\TrainTutoDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }
        public int setData(string Query)
        {
            int Cnt = 0;
            if(Con.State == ConnectionState.Closed) 
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        } 
    }
}

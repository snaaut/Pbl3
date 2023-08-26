using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DataBase
    {
        private static string stringConnectSql = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=PBL3New;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnectSql);
        }
        public DataTable LoadData(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlconnection = GetSqlConnection())
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                sqlconnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(data);
                sqlconnection.Close();
            }
            return data;

        }
        public void EditData(string query)
        {
            using (SqlConnection sqlconnection = GetSqlConnection())
            {
                sqlconnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
                sqlCommand.ExecuteNonQuery(); //thực thi câu truy vấn
                sqlconnection.Close();
            }
        }
        //public int LoadDataInt(string query )
        //{
        //    using (SqlConnection sqlconnection = GetSqlConnection())
        //    {
        //        sqlconnection.Open();
        //        SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
        //        sqlCommand.ExecuteScalar()
            }
        //public float GetData(string query)
        //{
        //    using (SqlConnection sqlconnection = GetSqlConnection())
        //    {
               
        //        sqlconnection.Open();
        //        SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
        //        sqlCommand.ExecuteScalar();
        //        sqlconnection.Close();
        //    }
        //}
        //public void AddKH(KhachHang KH,string query)
        //{
        //    using (SqlConnection sqlconnection = GetSqlConnection())
        //    {
        //        sqlconnection.Open();
        //    }
        //}
    }



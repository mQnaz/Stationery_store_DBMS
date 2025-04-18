using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybanhang.DAL
{
    internal class DBHelper
    {
        private readonly string ConnStr = "Data Source=GiaHuy\\SQLEXPRESS;Initial Catalog=Do_An_Cuoi_Ki;Integrated Security=True";
        private SqlConnection conn;
        private SqlCommand cmd;

        public DBHelper()
        {
            conn = new SqlConnection(ConnStr);
            cmd = conn.CreateCommand();
        }

    
        public DataSet ExecuteQueryDataSet(string query, CommandType commandType)
        {
            DataSet ds = new DataSet();
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                cmd.CommandText = query;
                cmd.CommandType = commandType;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi khi truy vấn dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return ds;
        }

        public bool MyExecuteNonQuery(string query, CommandType commandType, ref string error)
        {
            bool result = false;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                conn.Open();
                cmd.CommandText = query;
                cmd.CommandType = commandType;
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConnStr);
        }
    }
}


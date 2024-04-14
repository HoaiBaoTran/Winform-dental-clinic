using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_DentalClinic.DAO
{
    internal class DataInteraction
    {
        // Chuoi lien ket
        string stringConnection = @"Data Source=DESKTOP-H3R0OEQ;Initial Catalog=QuanLyPhongKham;Integrated Security=True;";
        //string stringConnection = @"Data Source=DESKTOP-MJ8P9VM\HOAIBAO;Initial Catalog=QuanLyPhongKham;Integrated Security=True";
        SqlConnection conn = null;
        // Mo ket noi

        void openConnection()
        {
            conn = new SqlConnection(stringConnection);
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        // Khai bao va thuc hien lenh Sql
        // Select
        public DataTable readData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            openConnection();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, conn);
            sqlData.Fill(dt);
            closeConnect();
            return dt;
        }

        // Insert, Update, Delete
        public void changeData(string sqlChange)
        {
            openConnection();
            SqlCommand sqlCom = new SqlCommand();
            sqlCom.Connection = conn;
            sqlCom.CommandText = sqlChange;
            sqlCom.ExecuteNonQuery();
            closeConnect();
            sqlCom.Dispose();
        }

        // Dong ket noi
        void closeConnect()
        {
            conn.Close();
            conn.Dispose();
        }

        public DataTable getDataTableDenByPat(string procName, string patID)
        {
            DataTable dt = new DataTable();
            openConnection();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PatID", SqlDbType.VarChar).Value = patID;
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            closeConnect();
            return dt;
        }

    }
}

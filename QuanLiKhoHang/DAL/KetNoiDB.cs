﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class KetNoiDB
    {
        public static SqlConnection connect;

        public KetNoiDB()
        {

        }
        //Data Source=DESKTOP-I5PP1IK;Initial Catalog=QuanLyKhoHang;Integrated Security=True
        public bool isConnected()
        {
            if (connect != null && connect.State == ConnectionState.Open)
                return true;
            // else 
            return false;
        }
        public void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection(@"Data Source=DESKTOP-I5PP1IK;Initial Catalog=QuanLyKhoHang;Integrated Security=True ");

            if (KetNoiDB.connect.State != ConnectionState.Open)
                KetNoiDB.connect.Open();
        }

        public void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
            }
        }

        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();

            }
            catch
            {

            }

        }
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public string GetValue(string strSQL)
        {

            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiKhoHang
{
  public class KetnoiDB
    { 
        public static SqlConnection connect;
          public bool isConnected()
        {
            if (connect != null && connect.State == ConnectionState.Open)
                return true;
           // else 
            return false;
        }
        public static void MoKetNoi()
        {
            if (KetnoiDB.connect == null)
                KetnoiDB.connect = new SqlConnection("@Data Source = DESKTOP - I5PP1IK; Initial Catalog = QuanLiKhoHang; Integrated Security = True ");
            if (KetnoiDB.connect.State != ConnectionState.Open)
                KetnoiDB.connect.Open();
        }

        public void DongKetNoi()
        {
            if (KetnoiDB.connect != null)
            {
                if (KetnoiDB.connect.State == ConnectionState.Open)
                    KetnoiDB.connect.Close();
            }
        }

        
    }
}

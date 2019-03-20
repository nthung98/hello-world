using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;
namespace QuanLiKhoHang
{
    public partial class HoaDonNhap : Form
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }
        BUS_ChiTietHDNhap busCThdn = new BUS_ChiTietHDNhap();
        BUS_HDNhap bushdn = new BUS_HDNhap();
        BUS_Vendor busvd = new BUS_Vendor();
        void HienThi(string where)
        {
            dataGridView1.DataSource = bushdn.LayTTHD(where);

        }
        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThi("");
        }
    }
}

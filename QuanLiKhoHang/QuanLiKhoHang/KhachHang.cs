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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        BUS_KhachHang bus = new BUS_KhachHang();
        E_KhachHang ec = new E_KhachHang();
        bool themmoi;
        void KhoaDieuKhien()
        {
            txt_MaKH.Enabled = false;
            txt_TenKH.Enabled = false;
            txt_SDT.Enabled = false;
            txt_CMT.Enabled = false;
            txt_ADDRESS.Enabled = false;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        void MoDieuKhien()
        {
            txt_MaKH.Enabled = true;
            txt_TenKH.Enabled = true;
            txt_SDT.Enabled = true;
            txt_CMT.Enabled = true;
            txt_ADDRESS.Enabled = true;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
        }
        void SetNull()
        {
            txt_MaKH.Text = "";
            txt_TenKH.Text = "";
            txt_SDT.Text = "";
            txt_CMT.Text = "";
        }
        void HienThi(string where)
        {
            dataGridView1.DataSource = bus.TaoBang(where);
        }
        private void KhachHang_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi("");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
            themmoi = true;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            themmoi = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaKH = txt_MaKH.Text;
                bus.XoaDuLieu(ec);
                KhoaDieuKhien();
                SetNull();
            }
            catch
            {

                MessageBox.Show("Không xóa được dữ liệu");
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txt_MaKH.Text == "" || txt_TenKH.Text == "")
            {
                MessageBox.Show("Phải nhập dữ liệu");
                return;
            }
            if (themmoi == true)
            {
                try
                {


                 ec.MaKH = txt_MaKH.Text;
                    ec.TenKH = txt_TenKH.Text;
                    ec.SDT = txt_SDT.Text;
                    ec.ADDRESS = txt_ADDRESS.Text;
                    bus.ThemDuLieu(ec);

                }
                catch { return; }
            }
            else
            {
                if (themmoi == true)
                {
                    try
                    {


                        ec.MaKH = txt_MaKH.Text;
                        ec.TenKH = txt_TenKH.Text;
                        ec.SDT = txt_SDT.Text;
                        ec.ADDRESS = txt_ADDRESS.Text;
                        bus.SuaDuLieu(ec);

                    }
                    catch { return; }
                }
            }
            SetNull();
            KhoaDieuKhien();
            HienThi("");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KhoaDieuKhien();
            try {
                
                txt_MaKH.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenKH.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                txt_SDT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_CMT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_ADDRESS.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();



            }
            catch { }
        }
    }
}

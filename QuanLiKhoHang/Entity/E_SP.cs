using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_SP
    {

        private string _MaSP;
        private string _TenSP;
        private string _HinhDang;
        private string _Color;
        private string _Price;
        private string _MaLoaiSP;
        private string _SoLuong;

        public string MaSP { get => _MaSP; set => _MaSP = value; }
        public string TenSP { get => _TenSP; set => _TenSP = value; }
        public string HinhDang { get => _HinhDang; set => _HinhDang = value; }
        public string Color { get => _Color; set => _Color = value; }
        public string Price { get => _Price; set => _Price = value; }
        public string MaLoaiSP { get => _MaLoaiSP; set => _MaLoaiSP = value; }
        public string SoLuong { get => _SoLuong; set => _SoLuong = value; }
    }
}

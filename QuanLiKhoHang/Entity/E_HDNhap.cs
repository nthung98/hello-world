using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class E_HDNhap
    {

        private string _MaHDN;
        private string _NgayNhap;
        private string _TongTienNhap;
        private string _MaNCC;
        private string _MaNV;

        public string MaHDN { get => _MaHDN; set => _MaHDN = value; }
        public string NgayNhap { get => _NgayNhap; set => _NgayNhap = value; }
        public string TongTienNhap { get => _TongTienNhap; set => _TongTienNhap = value; }
        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
    }
}

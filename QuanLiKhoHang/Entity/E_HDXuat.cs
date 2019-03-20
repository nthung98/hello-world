using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class E_HDXuat
    {

        private string _MaHDX;
        private string _NgayXuat;
        private string _TongTienXuat;
        private string _MaKH;
        private string _MaNV;

        public string MaHDX { get => _MaHDX; set => _MaHDX = value; }
        public string NgayXuat { get => _NgayXuat; set => _NgayXuat = value; }
        public string TongTienXuat { get => _TongTienXuat; set => _TongTienXuat = value; }
        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
    }
}

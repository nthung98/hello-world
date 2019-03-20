using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_KhachHang
    {

        private string _MaKH;
        private string _TenKH;
        private string _ADDRESS;
        private string _SDT;
        private string _CCCD;

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string ADDRESS { get => _ADDRESS; set => _ADDRESS = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string CCCD { get => _CCCD; set => _CCCD = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_LoaiSP
    {

        private string _MaLoaiSP;
        private string _TenLoaiSP;
        private string _DVT;
        private string _GhiChu;
        private string _MaKho;

        public string MaLoaiSP { get => _MaLoaiSP; set => _MaLoaiSP = value; }
        public string TenLoaiSP { get => _TenLoaiSP; set => _TenLoaiSP = value; }
        public string DVT { get => _DVT; set => _DVT = value; }
        public string GhiChu { get => _GhiChu; set => _GhiChu = value; }
        public string MaKho { get => _MaKho; set => _MaKho = value; }
    }
}

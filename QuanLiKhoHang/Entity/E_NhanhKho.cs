using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class E_NhanhKho
    {

        private string _Makho;
        private string _TenKho;
        private string _DiaChi;
        private string _SDT;

        public string Makho { get => _Makho; set => _Makho = value; }
        public string TenKho { get => _TenKho; set => _TenKho = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}

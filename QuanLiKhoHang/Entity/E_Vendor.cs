using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class E_Vendor
    {

        private string _MaNCC;
        private string _TenNCC;
        
        private string _ADDRESS;
        private string _SDT;

        public string MaNCC { get => _MaNCC; set => _MaNCC = value; }
        public string TenNCC { get => _TenNCC; set => _TenNCC = value; }
        public string ADDRESS { get => _ADDRESS; set => _ADDRESS = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
    }
}

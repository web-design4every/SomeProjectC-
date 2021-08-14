using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class VatLieu
    {
        public int MaSo { get; set; }
        public string TenVatLieu { get; set; }
        public DonViTinh DVT { get; set; }
        public int SLTon { get; set; }
        public float GiaNhap { get; set; }
        public float GiaBan { get; set; }
    }
}

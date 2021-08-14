using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class ThongTinPhieuNhap
    {
        public PhieuNhap MaNhap { get; set; }
        public VatLieu MaVL { get; set; }
        public NhaCungCap MaNCC { get; set; }
        public int SL { get; set; }
        public float DonGia { get; set; }
        public float TongTien { get; set; }
    }
}

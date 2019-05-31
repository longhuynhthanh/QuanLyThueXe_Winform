using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class XeMay : Xe
    {
        private int LoaiXe; // 0 là xe 100cc, 1 là 250cc
        private string BienSoXe;
        
        public int LOAIXE
        {
            get { return LoaiXe; }
            set { LoaiXe = value; }
        }
        public string BIENSOXE
        {
            get { return BienSoXe; }
            set { BienSoXe = value; }
        }

        public XeMay()
        {

        }
        public XeMay(string masonguoithue, string hoten, double sogiothue, int loaixe, string biensoxe) : base(masonguoithue, hoten, sogiothue)
        {
            LoaiXe = loaixe;
            BienSoXe = biensoxe;
        }

        public double TinhTienThueXe()
        {
            double Tong = 0;
            if (LoaiXe == 0)
            {
                Tong += 100000;
            }
            else
            {
                Tong += 200000;
            }
            return (Tong + (SoGioThue - 1) * 100000);
        }
    }
}

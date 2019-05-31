using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class Xe
    {
        protected string MaSoNguoiThue, HoTenNguoiThueXe;
        protected double SoGioThue;

        public string MASONGUOITHUE
        {
            get { return MaSoNguoiThue; }
            set { MaSoNguoiThue = value; }
        }

        public string HOTENNGUOITHUEXE
        {
            get { return HoTenNguoiThueXe; }
            set { HoTenNguoiThueXe = value; }
        }
        public double SOGIOTHUE
        {
            get { return SoGioThue; }
            set { SoGioThue = value; }
        }

        public Xe()
        {

        }
        public Xe(string masonguoithue, string hoten, double sogiothue)
        {
            MaSoNguoiThue = masonguoithue;
            HoTenNguoiThueXe = hoten;
            SoGioThue = sogiothue;
        }
    }
}

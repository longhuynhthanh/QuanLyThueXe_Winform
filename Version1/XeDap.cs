using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class XeDap : Xe
    {
        public XeDap()
        {

        }
        public XeDap(string masonguoithue, string hoten, double sogiothue) : base(masonguoithue, hoten, sogiothue)
        {

        }

        public double TinhTienThueXe()
        {
            return 10000 + (SoGioThue * 8000);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Version1
{
    class CuaHangChoThue
    {
        private List<XeDap> DSXeDap = new List<XeDap>();
        private List<XeMay> DSXeMay = new List<XeMay>();

        public List<XeDap> DSXEDAP
        {
            get { return DSXeDap; }
            set { DSXeDap = value; }
        }
        public List<XeMay> DSXEMAY
        {
            get { return DSXeMay; }
            set { DSXeMay = value; }
        }
        public double TinhTienThueXeDap(string ma)
        {
            double Tien = 0;
            for (int i = 0; i < DSXEDAP.Count; i++)
            {
                if (DSXEDAP[i].MASONGUOITHUE == ma)
                {
                    Tien += DSXEDAP[i].TinhTienThueXe();
                    break;
                }
            }
            return Tien;
        }
        public double TinhTienChoThueXeMay(string ma)
        {
            double Tien = 0;
            int SoLuong_XeMay = DSXeMay.Count;
            for (int i = 0; i < SoLuong_XeMay; i++)
            {
                if (DSXeMay[i].MASONGUOITHUE == ma)
                {
                    Tien += DSXeMay[i].TinhTienThueXe();
                    break;
                }
            }
            return Tien;
        }
        public bool KiemTraBiTrung(string ma)
        {
            int SoLuong_XeDap = DSXeDap.Count;
            int SoLuong_XeMay = DSXeMay.Count;
            for (int i = 0; i < SoLuong_XeDap; i++)
            {
                if (DSXeDap[i].MASONGUOITHUE == ma)
                {
                    return false;
                }
            }
            for (int i = 0; i < SoLuong_XeMay; i++)
            {
                if (DSXeMay[i].MASONGUOITHUE == ma)
                {
                    return false;
                }
            }
            return true;
        }
        public XeMay TimXeMay(string ma)
        {
            XeMay xemay = new XeMay();
            int SoLuong_XeMay = DSXeMay.Count;
            for (int i = 0; i < SoLuong_XeMay; i++)
            {
                if (DSXeMay[i].MASONGUOITHUE == ma)
                {
                    xemay = DSXeMay[i];
                    break;
                }
            }
            return xemay;
        }
        public XeDap TimXeDap(string ma)
        {
            XeDap xedap = new XeDap();
            int SoLuong_XeDap = DSXeDap.Count;
            for (int i = 0; i < SoLuong_XeDap; i++)
            {
                if (DSXeDap[i].MASONGUOITHUE == ma)
                {
                    xedap = DSXeDap[i];
                    break;
                }
            }
            return xedap;
        }
    }
}

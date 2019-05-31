using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CuaHangChoThue cuahang = new CuaHangChoThue();
        double SoGioThue, SoTienThueXe;

        private void rdbXeDap_CheckedChanged(object sender, EventArgs e)
        {
            gbLoaiXe.Visible = false;
            lblBienSo.Visible = false;
            txtBienSo.Visible = false;
        }

        private void rdbXeMay_CheckedChanged(object sender, EventArgs e)
        {
            gbLoaiXe.Visible = true;
            lblBienSo.Visible = true;
            txtBienSo.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text == "")
            {
                MessageBox.Show("Bạn chưa điền vào mã số", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaSo.Focus();
            }
            else if (txtHoTenNguoiThue.Text == "")
            {
                MessageBox.Show("Bạn chưa điền vào họ tên người thuê", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTenNguoiThue.Focus();
            }
            else if (txtSoGioThue.Text == "")
            {
                MessageBox.Show("Bạn chưa điền vào số giờ thuê", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoGioThue.Focus();
            }
            else if (rdbXeDap.Checked == false && rdbXeMay.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn loại xe", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rdbXeMay.Checked == true && rdb100cc.Checked == false && rdb250cc.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn loại xe máy", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rdbXeMay.Checked == true && txtBienSo.Text == "")
            {
                MessageBox.Show("Bạn chưa điền vào biển số xe", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBienSo.Focus();
            }
            else
            {
                bool check = cuahang.KiemTraBiTrung(txtMaSo.Text);
                if (check == false)
                {
                    MessageBox.Show("Mã đã bị trùng, xin kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaSo.Focus();
                }
                else
                {
                    try
                    {
                        SoGioThue = double.Parse(txtSoGioThue.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi Kiểu dữ liệu, xin kiểm tra lại");
                        txtSoGioThue.Clear();
                        txtSoGioThue.Focus();
                        return;
                    }
                    if (rdbXeDap.Checked)
                    {
                        XeDap xedap = new XeDap(txtMaSo.Text, txtHoTenNguoiThue.Text, SoGioThue);
                        cuahang.DSXEDAP.Add(xedap);
                        SoTienThueXe = cuahang.TinhTienThueXeDap(txtMaSo.Text);
                    }
                    else
                    {
                        if (rdb100cc.Checked)
                        {
                            XeMay xemay = new XeMay(txtMaSo.Text, txtHoTenNguoiThue.Text, SoGioThue, 0, txtBienSo.Text);
                            cuahang.DSXEMAY.Add(xemay);
                            SoTienThueXe = cuahang.TinhTienChoThueXeMay(txtMaSo.Text);
                        }
                        else
                        {
                            XeMay xemay = new XeMay(txtMaSo.Text, txtHoTenNguoiThue.Text, SoGioThue, 1, txtBienSo.Text);
                            cuahang.DSXEMAY.Add(xemay);
                            SoTienThueXe = cuahang.TinhTienChoThueXeMay(txtMaSo.Text);
                        }
                    }
                    string[] arr = new string[5];
                    arr[0] = txtMaSo.Text;
                    arr[1] = txtHoTenNguoiThue.Text;
                    arr[2] = SoGioThue.ToString();
                    if (rdbXeDap.Checked)
                    {
                        arr[3] = "Xe Đạp";
                    }
                    else
                    {
                        arr[3] = "Xe Máy";
                    }
                    arr[4] = SoTienThueXe.ToString();

                    ListViewItem item = new ListViewItem(arr);
                    lsvXe.Items.Add(item);
                }
            }
        }
        XeMay xemaydangchon;
        XeDap xedapdangchon;
        private void lsvXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvXe.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvXe.SelectedItems[0]; // để mặc định là 0 thì khi lick vào các dòng khác trên list view sẽ tự song965 cập nhật.
                string ma = item.SubItems[0].Text;
                txtMaSo.Text = ma;
                txtHoTenNguoiThue.Text = item.SubItems[1].Text;
                txtSoGioThue.Text = item.SubItems[2].Text;
                if (item.SubItems[3].Text == "Xe Đạp")
                {
                    rdbXeDap.Checked = true;
                    xedapdangchon = cuahang.TimXeDap(ma);
                }
                else
                {
                    rdbXeMay.Checked = true;
                    xemaydangchon = cuahang.TimXeMay(ma);
                    if (xemaydangchon.LOAIXE == 0)
                    {
                        rdb100cc.Checked = true;
                    }
                    else
                    {
                        rdb250cc.Checked = true;
                    }
                    txtBienSo.Text = xemaydangchon.BIENSOXE;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (xemaydangchon != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ma = xemaydangchon.MASONGUOITHUE;
                    cuahang.DSXEMAY.Remove(xemaydangchon); // Xóa ở mảng xe máy.
                    xemaydangchon = null;
                    // xóa trên list view
                    for (int i = 0; i < lsvXe.Items.Count; i++)
                    {
                        if (lsvXe.Items[i].SubItems[0].Text == ma)
                        {
                            lsvXe.Items.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
           else if (xedapdangchon != null)
            {
                if (MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string ma = xedapdangchon.MASONGUOITHUE;
                    cuahang.DSXEDAP.Remove(xedapdangchon);
                    xedapdangchon = null;

                    for (int i = 0; i < lsvXe.Items.Count; i++)
                    {
                        if (lsvXe.Items[i].SubItems[0].Text == ma)
                        {
                            lsvXe.Items.RemoveAt(i);
                            break;
                        }
                    }
                }
            }
            if (lsvXe.Items.Count == 0)
            {
                txtMaSo.Clear();
                txtMaSo.Focus();
                txtHoTenNguoiThue.Clear();
                txtSoGioThue.Clear();
                if (rdbXeDap.Checked == true)
                {
                    rdbXeDap.Checked = false;
                }
                else
                {
                    rdbXeMay.Checked = false;
                    rdb100cc.Checked = false;
                    rdb250cc.Checked = false;
                    txtBienSo.Clear(); 
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (xedapdangchon != null)
            {
                xedapdangchon.MASONGUOITHUE = txtMaSo.Text;
                xedapdangchon.HOTENNGUOITHUEXE = txtHoTenNguoiThue.Text;
                xedapdangchon.SOGIOTHUE = double.Parse(txtSoGioThue.Text);
                SoTienThueXe = cuahang.TinhTienThueXeDap(xedapdangchon.MASONGUOITHUE);
                // thêm xe đang chọn vào ds xe trong mảng
                for (int i = 0; i < cuahang.DSXEDAP.Count; i++)
                {
                    if (cuahang.DSXEDAP[i].MASONGUOITHUE == xedapdangchon.MASONGUOITHUE)
                    {
                        cuahang.DSXEDAP[i] = xedapdangchon;
                        break;
                    }
                }
                // thêm vào trong list view
                ListViewItem item = lsvXe.SelectedItems[0];
                item.SubItems[1].Text = xedapdangchon.HOTENNGUOITHUEXE;
                item.SubItems[2].Text = xedapdangchon.SOGIOTHUE.ToString();
                item.SubItems[4].Text = SoTienThueXe.ToString();
            }
            else if (xemaydangchon != null)
            {
                xemaydangchon.MASONGUOITHUE = txtMaSo.Text;
                xemaydangchon.HOTENNGUOITHUEXE = txtHoTenNguoiThue.Text;
                xemaydangchon.SOGIOTHUE = double.Parse(txtSoGioThue.Text);
                if (rdb100cc.Checked == true && rdbXeMay.Checked == true)
                {
                    xemaydangchon.LOAIXE = 0;
                    SoGioThue = cuahang.TinhTienChoThueXeMay(xemaydangchon.MASONGUOITHUE);
                }
                else if (rdb250cc.Checked == true && rdbXeMay.Checked == true)
                {
                    xemaydangchon.LOAIXE = 1;
                    SoGioThue = cuahang.TinhTienChoThueXeMay(xemaydangchon.MASONGUOITHUE);
                }
                for (int i = 0; i < cuahang.DSXEMAY.Count; i++)
                {
                    if (cuahang.DSXEMAY[i].MASONGUOITHUE == xemaydangchon.MASONGUOITHUE)
                    {
                        cuahang.DSXEMAY[i] = xemaydangchon;
                        break;
                    }
                }
                // thêm vào list view
                ListViewItem item = lsvXe.SelectedItems[0];
                item.SubItems[1].Text = xemaydangchon.HOTENNGUOITHUEXE;
                item.SubItems[2].Text = xemaydangchon.SOGIOTHUE.ToString();
                item.SubItems[4].Text = SoGioThue.ToString();
                item.SubItems[4].Text = SoGioThue.ToString();
                item.SubItems[4].Text = SoGioThue.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            gbXeThue.Visible = false;
            gbThongTin.Visible = false;
            lblTenTimKiem.Visible = true;
            txtTenTimKiem.Visible = true;
            if (lsvXe.Items.Count == 0)
            {
                MessageBox.Show("Dữ liệu trên list view không có nên không tìm kiếm được");
            }
        }
        string strTimKiem = null;
        private void txtTenTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            strTimKiem = txtTenTimKiem.Text;
            ResetListView();
        }
        void ResetListView()
        {
            lsvXe.Items.Clear();
            int SoLuong_XeMay = cuahang.DSXEMAY.Count;
            int SoLuong_XeDap = cuahang.DSXEDAP.Count;
            for (int i = 0; i < SoLuong_XeMay; i++)
            {
                string TenNguoiThue = cuahang.DSXEMAY[i].HOTENNGUOITHUEXE;
                string TenTimKiem = strTimKiem;

                // chuẩn hóa hai chuổi thành chuỗi thường
                TenNguoiThue = TenNguoiThue.ToLower();
                TenTimKiem = TenTimKiem.ToLower();
                if (TenNguoiThue.Contains(TenTimKiem) == true)
                {
                    string[] arr = new string[5];
                    arr[0] = cuahang.DSXEMAY[i].MASONGUOITHUE;
                    arr[1] = cuahang.DSXEMAY[i].HOTENNGUOITHUEXE;
                    arr[2] = cuahang.DSXEMAY[i].SOGIOTHUE.ToString();
                    if (cuahang.DSXEMAY[i].LOAIXE == 0)
                    {
                        arr[3] = "Xe Máy";
                        SoGioThue = cuahang.DSXEMAY[i].TinhTienThueXe();
                        arr[4] = SoGioThue.ToString();
                    }
                    else
                    {
                        arr[3] = "Xe Máy";
                        SoGioThue = cuahang.TinhTienChoThueXeMay(cuahang.DSXEMAY[i].MASONGUOITHUE);
                        arr[4] = SoGioThue.ToString();
                    }
                    ListViewItem item = new ListViewItem(arr);
                    lsvXe.Items.Add(item);
                }
            }
            for (int i = 0; i < SoLuong_XeDap; i++)
            {
                string TenNguoiThue = cuahang.DSXEDAP[i].HOTENNGUOITHUEXE;
                string TenTimKiem = strTimKiem;

                // chuẩn hóa hai chuổi thành chuỗi thường
                TenNguoiThue = TenNguoiThue.ToLower();
                TenTimKiem = TenTimKiem.ToLower();
                if (TenNguoiThue.Contains(TenTimKiem) == true)
                {
                    string[] arr = new string[5];
                    arr[0] = cuahang.DSXEDAP[i].MASONGUOITHUE;
                    arr[1] = cuahang.DSXEDAP[i].HOTENNGUOITHUEXE;
                    arr[2] = cuahang.DSXEDAP[i].SOGIOTHUE.ToString();
                    arr[3] = "Xe Đạp";
                    SoGioThue = cuahang.DSXEDAP[i].TinhTienThueXe();
                    arr[4] = SoGioThue.ToString();
                    ListViewItem item = new ListViewItem(arr);
                    lsvXe.Items.Add(item);
                }
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            FileInfo myfile = new FileInfo("DanhSachThueXe.txt");
            StreamWriter tex = myfile.AppendText(); // Thêm dữ liệu vào trong file
            int SoLuong = lsvXe.Items.Count;
            for (int i = 0; i < SoLuong; i++)
            {
                tex.WriteLine(lsvXe.Items[i].SubItems[0].Text);
                tex.WriteLine(lsvXe.Items[i].SubItems[1].Text);
                tex.WriteLine( lsvXe.Items[i].SubItems[2].Text);
                tex.WriteLine(lsvXe.Items[i].SubItems[3].Text);
                tex.WriteLine(lsvXe.Items[i].SubItems[4].Text);
            }
            MessageBox.Show("Ghi Thành Công");
            tex.Close();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Multiselect = true;
            opf.Title = "Chọn File";
            opf.Filter = "select file |*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                StreamReader Re = File.OpenText(opf.FileName);
                while (!Re.EndOfStream)
                {
                    string[] arr = new string[5];
                    arr[0] = Re.ReadLine();
                    arr[1] = Re.ReadLine();
                    arr[2] = Re.ReadLine();
                    arr[3] = Re.ReadLine();
                    arr[4] = Re.ReadLine();
                    ListViewItem item = new ListViewItem(arr);
                    lsvXe.Items.Add(item);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Tạo các cột trong list view
            lsvXe.Columns.Add("Mã Số", 80);
            lsvXe.Columns.Add("Họ Tên Người Thuê Xe", 220);
            lsvXe.Columns.Add("Số Giờ Thuê", 150);
            lsvXe.Columns.Add("Loại Xe", 150);
            lsvXe.Columns.Add("Số Tiền Thuê Xe", 150);
            lblTenTimKiem.Visible = false;
            txtTenTimKiem.Visible = false;
        }
    }
}

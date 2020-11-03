using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLVT_DATHANGD17
{
    public partial class DDHForm : DevExpress.XtraEditors.XtraForm
    {
        public int vitri1;
        public int vitri2;
        public string macn;
        public DDHForm()
        {
            InitializeComponent();
            vitri1 = 0;
            vitri2 = 0;
            macn = "";
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void DDHForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);

        }

        private void updateDHTableAdapter()
        {
            //
            datHangBDS.EndEdit();
            datHangBDS.ResetCurrentItem();
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Update(qLVT_DATHANGDataSet.DatHang);
            //
            ctddhBDS.EndEdit();
            ctddhBDS.ResetCurrentItem();
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Update(qLVT_DATHANGDataSet.CTDDH);
        }
        private void updateCTDDHTableAdapter()
        {
            ctddhBDS.EndEdit();
            ctddhBDS.ResetCurrentItem();
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Update(qLVT_DATHANGDataSet.CTDDH);
        }

        private void addVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri2 = ctddhBDS.Position;
           
            // Vô hiẹu hóa phần /Grid Control của đơn đặt hàng
            cTDDHDataGridView.Enabled = false;
            datHangDataGridView.Enabled = false;
            // Gọi tập lệnh của Binding Source;
            ctddhBDS.AddNew();
            saveVTBtn.Enabled = cancelVTBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = addVTBtn.Enabled = deleteVTBtn.Enabled = saveVTBtn.Enabled = undoBtn.Enabled = false;
            // Mở phần chỉnh sửa
            chiTietGroup.Enabled = true;
            thongTinGroup.Enabled = false;

            // Tự động điền các mã đơn đặt hàng hiện tại và mã vật tư
            masoDDHTE1.Text = masoDDHTE.Text;
         //   textEditMaVT.Text = comboBoxPackageName.SelectedValue.ToString().Trim(); dong nay xu ly sau
        }

        private void refreshTableAdapter()
        {
            // TODO: This line of code loads data into the 'DS.DATHANG' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
            // TODO: This line of code loads data into the 'DS.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            //// TODO: This line of code loads data into the 'DS.PHIEUNHAP' table. You can move, or remove it, as needed.
            //this.pHIEUNHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.pHIEUNHAPTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);
            //// TODO: This line of code loads data into the 'DS.VATTU' table. You can move, or remove it, as needed.
            //this.vATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.vATTUTableAdapter.Fill(this.qLVT_DATHANGDataSet.VATTU);
            //// TODO: This line of code loads data into the 'DS.KHO' table. You can move, or remove it, as needed.
            //this.kHOTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.kHOTableAdapter.Fill(this.qLVT_DATHANGDataSet.KHO);
            //// TODO: This line of code loads data into the 'DS.SP_InDanhSachNhanVien' table. You can move, or remove it, as needed.
            //this.sP_InDanhSachNhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sP_InDanhSachNhanVienTableAdapter.Fill(this.DS.SP_InDanhSachNhanVien);
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshBtn.PerformClick();
            try
            {
                if (comboBoxBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                    return;
                // Gán chi nhánh mới
                Program.servername = comboBoxBranch.SelectedValue.ToString();
                // Dùng SUPPORT_CONNECT để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên comboBoxBranch
                if (Program.mChinhanh != comboBoxBranch.SelectedIndex)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                // Dung tài khoản khi đăng nhập nếu như chọn lại chi nhánh chọn khi đăng nhập
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == false)
                    MessageBox.Show($"Không thể kết nối đến server {Program.servername}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    refreshTableAdapter();
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void deleteVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            string delCTDDH = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa đơn đặt hàng này ?? ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                try
                {
                    delCTDDH = ((DataRowView)datHangBDS[datHangBDS.Position])["MasoDDH"].ToString();
                    ctddhBDS.RemoveCurrent();
                    updateCTDDHTableAdapter();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Xóa chi tiết đơn hàng không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);
                    datHangBDS.Position = datHangBDS.Find("MasoDDH", delCTDDH);
                }

            if (ctddhBDS.Count == 0)
                deleteVTBtn.Enabled = false;
        }

        private void saveVTBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (masoDDHTE1.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                masoDDHTE1.Focus();
                return;
            }

            if (soLuongSE.Text.Trim() == "" || soLuongSE.Value < 0)
            {
                MessageBox.Show("Số lượng đặt không được để trống và phải có giá trị dương", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                soLuongSE.Focus();
                return;
            }
            if (donGiaSE.Text.Trim() == "" || donGiaSE.Value < 0)
            {
                MessageBox.Show("Đơn giá của vật tư không được để trống và phải có giá trị dương", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                donGiaSE.Focus();
                return;
            }
            try
            {

                int checkIndex = -1;
                for (int i = 0; i < ctddhBDS.Count; i++)
                {
                    if (vattuCB.Text.Trim() == ((DataRowView)ctddhBDS[i])["MAVT"].ToString())
                    {
                        checkIndex = i;
                        break;
                    }
                }
                MessageBox.Show($"{checkIndex}  {ctddhBDS.Count}");
                if (checkIndex >= 0 && checkIndex != ctddhBDS.Position)
                {
                    MessageBox.Show($"Chi tiết cho vật tư này đã được lập vui lòng chọn lại vât tư khác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                updateCTDDHTableAdapter();
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                datHangDataGridView.Enabled = true;
                cTDDHDataGridView.Enabled = true;

                addBtn.Enabled = updateBtn.Enabled = deleteBtn.Enabled = refreshBtn.Enabled = true;
                addVTBtn.Enabled = deleteVTBtn.Enabled = true;
                saveBtn.Enabled = cancelVTBtn.Enabled = false;
                saveVTBtn.Enabled = false;
                thongTinGroup.Enabled = false;
                chiTietGroup.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
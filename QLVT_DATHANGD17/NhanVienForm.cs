using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLVT_DATHANGD17
{
    public partial class NhanVienForm : DevExpress.XtraEditors.XtraForm
    {
        public int vitri;
        public string macn;
        private bool insertSession = false;
        private CommandManager cmdManager;
        public NhanVienForm()
        {
            InitializeComponent();
            vitri = 0;
            macn = "";
            cmdManager = new CommandManager();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBDS.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            qLVT_DATHANGDataSet.EnforceConstraints = false;
           
            this.chiNhanhTableAdapter.Fill(this.qLVT_DATHANGDataSet.ChiNhanh);
            refreshTable();
            detailGroup.Enabled = false;
            // khoi tao chinhanh combobox
            comboBoxBranch.DataSource = Program.bds_dspm;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mChinhanh;

            String chinhanh = Program.mChinhanh == 0 ? "Chi nhánh 2" : "Chi nhánh 1";
            chiNhanhChuyenCb.Items.Add(chinhanh);

            if (Program.userRole == "CongTy")
            {
                comboBoxBranch.Enabled = true;
                addBtn.Enabled = deleteBtn.Enabled = cancelBtn.Enabled = detailGroup.Enabled = false; updateBtn.Enabled = saveBtn.Enabled  = false;
            }
            else // Các phân quyền khác như CHINHANH, USER thì không thể lựa chọn chi nhánh khác
            {
                comboBoxBranch.Enabled = false;
                //groupBox1.Enabled = false;
                detailGroup.Enabled = false;
                exchangeGroup.Enabled = false;
                saveBtn.Enabled = false;
            }
            // khoi tao gia tri macn
            macn = ((DataRowView)chiNhanhBDS[0])["MACN"].ToString();


            luongSpin.Properties.MinValue = 4000000;
            luongSpin.Properties.MaxValue = 1000000000;
            hoTE.Properties.MaxLength = 40;
            tenTE.Properties.MaxLength = 10;
            diaChiTE.Properties.MaxLength = 100;

            
        }

        // fill lai data tu db
        private void refreshTable()
        {
            // cap nhat connection string + load lai cac bang
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuXuat);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVT_DATHANGDataSet.PhieuNhap);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVT_DATHANGDataSet.DatHang);

            this.sP_CHECKTRUNGNVTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.sP_CHECKTRUNGNVTableAdapter.Fill(this.qLVT_DATHANGDataSet.SP_CHECKTRUNGNV);
            // load danh sach phan manh
            //    this.v_DS_PHANMANHTableAdapter.Fill(this.qLVT_DATHANG_DSPM.V_DS_PHANMANH);

        }

        // update data xuong db
        private void updateTableAdapter()
        {
            nhanVienBDS.EndEdit();
            nhanVienBDS.ResetCurrentItem();
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
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
                // Dùng htkn để kết nối tới server mới thay cho login cũ nếu như thay đổi chi nhánh mới trên comboBoxBranch
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
                    refreshTable();
                    // Lấy mã chi nhánh hiện tại
                    //  macn = ((DataRowView)chiNhanhBDS[0])["MACN"].ToString(); // khong can do khong su dung macn khac ma dang nhap khi write data (constraint phan quyen)
                    //   MessageBox.Show(macn);
                }
            }
            catch (NullReferenceException nullRef)
            {
                return;
            }
        }

        private void addBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            // thuc thi insert  
            cmdManager.execute(new InsertAction(nhanVienBDS));
            modifyUIButtonState();
            // Cho phép nhập mới mã nhân viên và mà chi nhánh
            maNVSpin.Enabled = true;
            maCNTE.Text = macn;
            insertSession = true;
        }

        private void updateBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            // save lai trang thai de undo
            cmdManager.execute(new UpdateAction(nhanVienBDS));
            modifyUIButtonState();
            maNVSpin.Enabled = false; // update k dc doi ma nv
        }


        private void saveBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            detailGroup.Focus();
            if (maNVSpin.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maNVSpin.Focus();
                return;
            }

            if ((int)maNVSpin.Value < 0)
            {
                MessageBox.Show("Mã nhân viên âm chỉ đuọc phép sử dụng cho nhân viên đã chuyển chi nhánh, hãy chọn một mã khác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maNVSpin.Focus();
                return;
            }
            //-----------------------------------------------------------
            if (hoTE.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hoTE.Focus();
                return;
            }
            if (tenTE.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenTE.Focus();
                return;
            }
            if (diaChiTE.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                diaChiTE.Focus();
                return;
            }
            if (ngaySinhDE.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được để trống", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ngaySinhDE.Focus();
                return;
            }
            if (luongSpin.Text.Trim() == "" || luongSpin.Value < 4000000)
            {
                MessageBox.Show("Lương nhân viên không chính xác", "Sai thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                luongSpin.Focus();
                return;
            }

            // Goi sp tim ma nhan vien
            //MessageBox.Show(spinEditMaNV.Text.ToString().Trim('.'));
            try
            {
                // chay sp kiem tra ma nv da ton tai chua neu save insert moi, update thi khong can kiem tra
                if (insertSession)
                {
                    string command = "exec SP_TimNV " + maNVSpin.Text.ToString().Trim('.');
                    Program.myReader = Program.ExecSqlDataReader(command);
                    if (Program.myReader != null)
                    {
                        Program.myReader.Read();

                        MessageBox.Show($"Mã nhân viên đã tồn tại với thông tin: {Program.myReader.GetString(0)} {Program.myReader.GetString(1)} - {Program.myReader.GetString(2)}");
                        Program.myReader.Close();
                        return;
                    }
                    ((DataRowView)nhanVienBDS.Current)["MACN"] = macn; // set chi nhanh la chi nhanh server dang nhap
                    ((DataRowView)nhanVienBDS.Current)["TrangThaiXoa"] = 0; // set trang thai xoa cho record vua moi insert la 0
                    insertSession = false;
                    ((InsertAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                    updateTableAdapter();
                    
                }
                else {
                    ((UpdateAction)cmdManager.getLastUndoNode()).getData(); // lay data cho redo
                    updateTableAdapter();

                }
                // Cập nhật xuống database
                
                undoBtn.Enabled = true;
                // Tùy chỉnh lại trạng thái các button sau khi hoàn tất
                viewUIButtonState();
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cancelBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            // them moi thi cancel edit, update thi k can cancel
            if (insertSession)
            {
                nhanVienBDS.CancelEdit();
                insertSession = false;
            }
            // Bặt tắt các phần nhập dữ liệu tương ứng
            viewUIButtonState();
            refreshBtn.PerformClick();
            phieuNhapBDS.Position = vitri;
            // update trang thai stack 
            cmdManager.clearLastNode();
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }

        }


        private void refreshBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // Đưa BindingSource của nhân viên về mặc định
                  nhanVienBDS.RemoveFilter();
                //this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                refreshTable();
            }
            catch (Exception exception)
            {
                MessageBox.Show($" <3 {exception.Message}", "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Nếu nhân viên đã được tạo tài khoản đăng nhập hệ thống thì không được phép xóa
            // Chạy SP kiểm tra sự tồn tại tài khoản đăng nhập cho nhân viên hiện tại 
            // SP xac dinh username co tai khoan login
            string command = $"exec SP_TimLogin '{maNVSpin.Text}'";
            Program.myReader = Program.ExecSqlDataReader(command);
            if (Program.myReader != null)
            {
                if (Program.myReader.Read()) // Đã tồn tại
                {
                    MessageBox.Show($"Nhân viên này đã có tài khoản đăng nhập là {Program.myReader.GetString(0)} \nKhông được phép xóa thông tin nhân viên", "Xóa nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }

            //MessageBox.Show($"Số phiếu xuất: {BDSPhieuXuat.Count} \nSố phiếu nhập: {BDSPhieuNhap.Count} \nSố đơn đặt hàng: {BDSDatHang.Count}");
            // Nếu nhân viên đã lập bất kì một phiếu nào thì không đươc phép xóa
            if (datHangBDS.Count > 0 || phieuNhapBDS.Count > 0 || phieuXuatBDS.Count > 0)
                MessageBox.Show($"Nhân viên {hoTE.Text} {tenTE.Text} đã tạo phiếu nên không thể xóa :3", "Xóa nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int delMaNV = 0;
                if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    try
                    {
                        delMaNV = int.Parse(((DataRowView)nhanVienBDS[nhanVienBDS.Position])["MANV"].ToString());
                       
                        cmdManager.execute(new DeleteAction(nhanVienBDS));
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.nhanVienTableAdapter.Update(this.qLVT_DATHANGDataSet.NhanVien);
                        undoBtn.Enabled = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Xóa nhân viên không thành công :3", "Lỗi khi xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.nhanVienTableAdapter.Fill(this.qLVT_DATHANGDataSet.NhanVien);
                        nhanVienBDS.Position = nhanVienBDS.Find("MANV", delMaNV);
                    }
            }
            if (nhanVienBDS.Count == 0)
                deleteBtn.Enabled = false;
        }




        private void exchangeBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            // kiem tra nhan vien dc chon da la trang thai xoa chua
            if (((DataRowView)nhanVienBDS.Current)["TrangThaiXoa"].ToString() == "1")
            {
                //show message da dc xoa
                MessageBox.Show($"Nhân viên này đã được xóa", "Chuyển nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // kiem tra co lien ket tai khoan dang nhap khong
            string command = $"exec SP_TimLogin '{maNVSpin.Text}'";
            Program.myReader = Program.ExecSqlDataReader(command);
            if (Program.myReader != null)
            {
                if (Program.myReader.Read()) // Đã tồn tại
                {
                    MessageBox.Show($"Nhân viên này đã có tài khoản đăng nhập là {Program.myReader.GetString(0)} \nKhông được chuyển nhân viên", "Chuyển nhân viên thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }


            // mo mode chuyen chi nhanh cho user chon chi nhanh dich
            startChangingBranchModeUIButtonState();
            // load check trung table
            String ho = ((DataRowView)nhanVienBDS.Current)["HO"].ToString();
            String ten = ((DataRowView)nhanVienBDS.Current)["TEN"].ToString();
            
            String ngaysinhstr = ((DataRowView)nhanVienBDS.Current)["NGAYSINH"].ToString();
            DateTime ngaysinh = DateTime.Parse(ngaysinhstr);

            this.sP_CHECKTRUNGNVTableAdapter.Fill(this.qLVT_DATHANGDataSet.SP_CHECKTRUNGNV,ho, ten,ngaysinh);
            chiNhanhChuyenCb.SelectedIndex = 0;

            // disable btn chuyen trung neu khong co record trung

            if (checkTrungBDS.Count == 0)
            {
                replaceExBtn.Enabled = false;
            }
            else {
                replaceExBtn.Enabled = true;
            }
        }

        private void chuyenBtn_Click(object sender, EventArgs e)
        {
            // kiem tra co chon k
            if (sP_CHECKTRUNGNVDataGridView.SelectedCells.Count == 0) {
                MessageBox.Show($"Chuyển nhân viên thành công", $"Chưa chọn nhân viên đè lên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //
            String manvdes = ((DataRowView)checkTrungBDS.Current)["MANV"].ToString();
            String manvsrc = ((DataRowView)nhanVienBDS.Current)["MANV"].ToString();
            String macn = Program.mChinhanh == 0 ? "CN2" : "CN1";
            // goi sp chuyen chi nhanh
            string command = $"exec CHUYENCN 1, {manvsrc}, {manvdes}, '{macn}'";
            Program.myReader = Program.ExecSqlDataReader(command);
            if (Program.myReader != null)
            {
                MessageBox.Show($"Chuyển nhân viên thành công", $"Chuyển nhân viên thành công sang {macn}", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program.myReader.Close();

                // thuc thi don dep giao dien
                viewUIButtonState();


            }
            refreshBtn.PerformClick();
        }

        private void newExBtn_Click(object sender, EventArgs e)
        {
            String manvsrc = ((DataRowView)nhanVienBDS.Current)["MANV"].ToString();
            String macn = Program.mChinhanh == 0 ? "CN2" : "CN1";
            // goi sp chuyen chi nhanh
            string command = $"exec CHUYENCN 2, {manvsrc}, 0, '{macn}'";
            Program.myReader = Program.ExecSqlDataReader(command);
            if (Program.myReader != null)
            {
                MessageBox.Show($"Chuyển nhân viên thành công", $"Chuyển nhân viên thành công sang {macn}", MessageBoxButtons.OK, MessageBoxIcon.None);
                Program.myReader.Close();

                // thuc thi don dep giao dien
                viewUIButtonState();

            }
            refreshBtn.PerformClick();
        }

        private void huyChuyenBtn_Click(object sender, EventArgs e)
        {
            viewUIButtonState();
           
        }

        private void modifyUIButtonState()
        {
            vitri = nhanVienBDS.Position; // luu vi tri truoc khi update/ins
            exchangeGroup.Enabled = false;
            detailGroup.Enabled = true;
            nhanVienGridControl.Enabled = false;
            saveBtn.Enabled = true;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = exchangeBtn.Enabled = false;
        }

        private void viewUIButtonState()
        {
            exchangeGroup.Enabled = false;
            detailGroup.Enabled = false;
            nhanVienGridControl.Enabled = true;
            saveBtn.Enabled = false;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = exchangeBtn.Enabled = true;
        }

        private void startChangingBranchModeUIButtonState()
        {
            saveBtn.Enabled = exchangeBtn.Enabled = false;
            addBtn.Enabled = deleteBtn.Enabled = updateBtn.Enabled = refreshBtn.Enabled = false;
            exchangeGroup.Enabled = true;
            detailGroup.Enabled = false;
            nhanVienGridControl.Enabled = false;
        }



        private void undoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.undo();
            updateTableAdapter();
            if (cmdManager.undoStackSize() == 0)
            {
                undoBtn.Enabled = false;
            }
            redoBtn.Enabled = true;
        }

        private void redoBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            cmdManager.redo();
            updateTableAdapter();
            if (cmdManager.redoStackSize() == 0)
            {
                redoBtn.Enabled = false;
            }
            undoBtn.Enabled = true;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.sP_CHECKTRUNGNVTableAdapter.Fill(this.qLVT_DATHANGDataSet.SP_CHECKTRUNGNV,"", "", new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType("", typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       
    }
}

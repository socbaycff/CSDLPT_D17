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
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            showLoginForm();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form childForm in this.MdiChildren)
                if (childForm.GetType() == ftype)
                    return childForm;
            return null;
        }

        public void showLoginForm()
        {
            Form form = this.CheckExists(typeof(LoginForm));
            if (form != null) form.Show();
            else
            {
                LoginForm newForm = new LoginForm();
                newForm.MdiParent = this;
                newForm.Show();
            }
        }

        private void loginBtn_ItemClick(object sender, ItemClickEventArgs e)
        {
            showLoginForm();
        }
    }
}
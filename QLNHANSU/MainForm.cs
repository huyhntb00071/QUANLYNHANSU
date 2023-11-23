using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNHANSU
{
    public partial class MainForm
        : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                frm.Activate();
                return;
            }
            Form f = (Form) Activator.CreateInstance(typeForm);
            f.Show();
        }
        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnUngLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTrinhDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDanToc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanToc frm= new frmDanToc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTonGiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTonGiao frm= new frmTonGiao();   
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

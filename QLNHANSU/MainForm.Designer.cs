namespace QLNHANSU
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhongBan = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnHopDong = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bthDieuChuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoiViec = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhuCap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTangCa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUngLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangCong = new DevExpress.XtraBars.BarButtonItem();
            this.btnBangLuong = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnTrinhDo,
            this.btnNhanVien,
            this.btnPhongBan,
            this.btnHopDong,
            this.barButtonItem1,
            this.bthDieuChuyen,
            this.btnThoiViec,
            this.btnLoaiCa,
            this.btnLoaiCong,
            this.btnPhuCap,
            this.btnTangCa,
            this.btnUngLuong,
            this.btnBangCong,
            this.btnBangLuong});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1325, 158);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ  thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Nhân sự";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanToc);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTrinhDo, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPhongBan, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhanVien, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục dùng chung";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnHopDong);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.bthDieuChuyen, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnThoiViec, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Nghiệp vụ";
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân Tộc";
            this.btnDanToc.Id = 1;
            this.btnDanToc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanToc.ImageOptions.SvgImage")));
            this.btnDanToc.Name = "btnDanToc";
            this.btnDanToc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn Giáo";
            this.btnTonGiao.Id = 2;
            this.btnTonGiao.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTonGiao.ImageOptions.SvgImage")));
            this.btnTonGiao.Name = "btnTonGiao";
            this.btnTonGiao.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình Độ";
            this.btnTrinhDo.Id = 3;
            this.btnTrinhDo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrinhDo.ImageOptions.Image")));
            this.btnTrinhDo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrinhDo.ImageOptions.LargeImage")));
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Nhân viên";
            this.btnNhanVien.Id = 4;
            this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.Caption = "Phòng ban";
            this.btnPhongBan.Id = 5;
            this.btnPhongBan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhongBan.ImageOptions.SvgImage")));
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhongBan_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Chấm công";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaiCa);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLoaiCong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnPhuCap, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTangCa, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUngLuong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangCong, true);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBangLuong, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý chấm công";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Báo biểu";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // btnHopDong
            // 
            this.btnHopDong.Caption = "Hợp đồng";
            this.btnHopDong.Id = 6;
            this.btnHopDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHopDong.ImageOptions.SvgImage")));
            this.btnHopDong.Name = "btnHopDong";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Khen thưởng - Kỷ luật";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bthDieuChuyen
            // 
            this.bthDieuChuyen.Caption = "Điều chuyển";
            this.bthDieuChuyen.Id = 8;
            this.bthDieuChuyen.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bthDieuChuyen.ImageOptions.SvgImage")));
            this.bthDieuChuyen.Name = "bthDieuChuyen";
            this.bthDieuChuyen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnThoiViec
            // 
            this.btnThoiViec.Caption = "Thôi Việc";
            this.btnThoiViec.Id = 9;
            this.btnThoiViec.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoiViec.ImageOptions.SvgImage")));
            this.btnThoiViec.Name = "btnThoiViec";
            // 
            // btnLoaiCa
            // 
            this.btnLoaiCa.Caption = "Loại Ca";
            this.btnLoaiCa.Id = 10;
            this.btnLoaiCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCa.ImageOptions.SvgImage")));
            this.btnLoaiCa.Name = "btnLoaiCa";
            // 
            // btnLoaiCong
            // 
            this.btnLoaiCong.Caption = "Loại công";
            this.btnLoaiCong.Id = 11;
            this.btnLoaiCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoaiCong.ImageOptions.SvgImage")));
            this.btnLoaiCong.Name = "btnLoaiCong";
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Caption = "Phụ cấp";
            this.btnPhuCap.Id = 12;
            this.btnPhuCap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhuCap.ImageOptions.SvgImage")));
            this.btnPhuCap.Name = "btnPhuCap";
            // 
            // btnTangCa
            // 
            this.btnTangCa.Caption = "Tăng ca";
            this.btnTangCa.Id = 13;
            this.btnTangCa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTangCa.ImageOptions.SvgImage")));
            this.btnTangCa.Name = "btnTangCa";
            // 
            // btnUngLuong
            // 
            this.btnUngLuong.Caption = "Ứng lương";
            this.btnUngLuong.Id = 14;
            this.btnUngLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUngLuong.ImageOptions.SvgImage")));
            this.btnUngLuong.Name = "btnUngLuong";
            this.btnUngLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUngLuong_ItemClick);
            // 
            // btnBangCong
            // 
            this.btnBangCong.Caption = "Bảng công";
            this.btnBangCong.Id = 15;
            this.btnBangCong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangCong.ImageOptions.SvgImage")));
            this.btnBangCong.Name = "btnBangCong";
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Caption = "Bảng lương";
            this.btnBangLuong.Id = 16;
            this.btnBangLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBangLuong.ImageOptions.SvgImage")));
            this.btnBangLuong.Name = "btnBangLuong";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1325, 703);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Phần mềm quản lý nhân sự";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnPhongBan;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnHopDong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem bthDieuChuyen;
        private DevExpress.XtraBars.BarButtonItem btnThoiViec;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCa;
        private DevExpress.XtraBars.BarButtonItem btnLoaiCong;
        private DevExpress.XtraBars.BarButtonItem btnPhuCap;
        private DevExpress.XtraBars.BarButtonItem btnTangCa;
        private DevExpress.XtraBars.BarButtonItem btnUngLuong;
        private DevExpress.XtraBars.BarButtonItem btnBangCong;
        private DevExpress.XtraBars.BarButtonItem btnBangLuong;
    }
}


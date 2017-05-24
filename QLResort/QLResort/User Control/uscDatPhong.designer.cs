namespace QLResort.User_Control
{
    partial class uscDatPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscDatPhong));
            this.pnlDisplay = new DevExpress.XtraEditors.PanelControl();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radDaDat = new System.Windows.Forms.RadioButton();
            this.radTrong = new System.Windows.Forms.RadioButton();
            this.radgrpChoose = new DevExpress.XtraEditors.RadioGroup();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtChoose = new DevExpress.XtraEditors.TextEdit();
            this.lblChoose = new DevExpress.XtraEditors.LabelControl();
            this.picDisplay = new DevExpress.XtraEditors.PictureEdit();
            this.lblDaDat = new DevExpress.XtraEditors.LabelControl();
            this.lblTrong = new DevExpress.XtraEditors.LabelControl();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblPlaced = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.dateNgayNhan = new DevExpress.XtraEditors.DateEdit();
            this.lblNgayTra = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayNhan = new DevExpress.XtraEditors.LabelControl();
            this.lblLoaiPhong = new DevExpress.XtraEditors.LabelControl();
            this.lblTittle = new System.Windows.Forms.Label();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.DP_mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHinhAnh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChiTietDatPhong = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDisplay)).BeginInit();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpChoose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties)).BeginInit();
            this.mnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplay.Controls.Add(this.radTatCa);
            this.pnlDisplay.Controls.Add(this.radDaDat);
            this.pnlDisplay.Controls.Add(this.radTrong);
            this.pnlDisplay.Controls.Add(this.radgrpChoose);
            this.pnlDisplay.Controls.Add(this.btnDatPhong);
            this.pnlDisplay.Controls.Add(this.btnClear);
            this.pnlDisplay.Controls.Add(this.txtChoose);
            this.pnlDisplay.Controls.Add(this.lblChoose);
            this.pnlDisplay.Controls.Add(this.picDisplay);
            this.pnlDisplay.Location = new System.Drawing.Point(3, 203);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1250, 421);
            this.pnlDisplay.TabIndex = 138;
            // 
            // radTatCa
            // 
            this.radTatCa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.radTatCa.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(213, 5);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(96, 36);
            this.radTatCa.TabIndex = 2;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất cả";
            this.radTatCa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTatCa.UseVisualStyleBackColor = false;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.radChoose_CheckedChanged);
            // 
            // radDaDat
            // 
            this.radDaDat.BackColor = System.Drawing.Color.MediumAquamarine;
            this.radDaDat.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDaDat.Location = new System.Drawing.Point(109, 5);
            this.radDaDat.Name = "radDaDat";
            this.radDaDat.Size = new System.Drawing.Size(96, 36);
            this.radDaDat.TabIndex = 1;
            this.radDaDat.TabStop = true;
            this.radDaDat.Text = "Đã đặt";
            this.radDaDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radDaDat.UseVisualStyleBackColor = false;
            this.radDaDat.CheckedChanged += new System.EventHandler(this.radChoose_CheckedChanged);
            // 
            // radTrong
            // 
            this.radTrong.BackColor = System.Drawing.Color.MediumAquamarine;
            this.radTrong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTrong.Location = new System.Drawing.Point(5, 5);
            this.radTrong.Name = "radTrong";
            this.radTrong.Size = new System.Drawing.Size(96, 36);
            this.radTrong.TabIndex = 0;
            this.radTrong.TabStop = true;
            this.radTrong.Text = "Trống";
            this.radTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTrong.UseVisualStyleBackColor = false;
            this.radTrong.CheckedChanged += new System.EventHandler(this.radChoose_CheckedChanged);
            // 
            // radgrpChoose
            // 
            this.radgrpChoose.Location = new System.Drawing.Point(2, 2);
            this.radgrpChoose.Name = "radgrpChoose";
            this.radgrpChoose.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgrpChoose.Properties.Appearance.Options.UseFont = true;
            this.radgrpChoose.Size = new System.Drawing.Size(310, 42);
            this.radgrpChoose.TabIndex = 104;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatPhong.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDatPhong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.Location = new System.Drawing.Point(1134, 2);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(114, 42);
            this.btnDatPhong.TabIndex = 103;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(673, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 26);
            this.btnClear.TabIndex = 102;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtChoose
            // 
            this.txtChoose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChoose.Enabled = false;
            this.txtChoose.Location = new System.Drawing.Point(588, 11);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChoose.Properties.Appearance.Options.UseFont = true;
            this.txtChoose.Size = new System.Drawing.Size(79, 26);
            this.txtChoose.TabIndex = 101;
            // 
            // lblChoose
            // 
            this.lblChoose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblChoose.Appearance.BackColor = System.Drawing.Color.LimeGreen;
            this.lblChoose.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(511, 13);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(71, 22);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "Đã chọn:";
            // 
            // picDisplay
            // 
            this.picDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDisplay.Location = new System.Drawing.Point(2, 2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picDisplay.Properties.Appearance.Options.UseFont = true;
            this.picDisplay.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picDisplay.Size = new System.Drawing.Size(1246, 417);
            this.picDisplay.TabIndex = 0;
            // 
            // lblDaDat
            // 
            this.lblDaDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDaDat.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaDat.Location = new System.Drawing.Point(1201, 134);
            this.lblDaDat.Name = "lblDaDat";
            this.lblDaDat.Size = new System.Drawing.Size(52, 22);
            this.lblDaDat.TabIndex = 133;
            this.lblDaDat.Text = "Đã đặt";
            // 
            // lblTrong
            // 
            this.lblTrong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrong.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrong.Location = new System.Drawing.Point(1131, 134);
            this.lblTrong.Name = "lblTrong";
            this.lblTrong.Size = new System.Drawing.Size(46, 22);
            this.lblTrong.TabIndex = 134;
            this.lblTrong.Text = "Trống";
            // 
            // lblEmpty
            // 
            this.lblEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmpty.BackColor = System.Drawing.Color.Lime;
            this.lblEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmpty.Location = new System.Drawing.Point(1134, 164);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(40, 26);
            this.lblEmpty.TabIndex = 136;
            // 
            // lblPlaced
            // 
            this.lblPlaced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlaced.BackColor = System.Drawing.Color.DarkOrange;
            this.lblPlaced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlaced.Location = new System.Drawing.Point(1207, 164);
            this.lblPlaced.Name = "lblPlaced";
            this.lblPlaced.Size = new System.Drawing.Size(40, 26);
            this.lblPlaced.TabIndex = 135;
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.Location = new System.Drawing.Point(17, 164);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiPhong.Properties.Appearance.Options.UseFont = true;
            this.cboLoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLoaiPhong.Size = new System.Drawing.Size(184, 26);
            this.cboLoaiPhong.TabIndex = 126;
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.EditValue = null;
            this.dateNgayTra.Location = new System.Drawing.Point(593, 164);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTra.Properties.Appearance.Options.UseFont = true;
            this.dateNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTra.Size = new System.Drawing.Size(184, 26);
            this.dateNgayTra.TabIndex = 131;
            // 
            // dateNgayNhan
            // 
            this.dateNgayNhan.EditValue = null;
            this.dateNgayNhan.Location = new System.Drawing.Point(305, 164);
            this.dateNgayNhan.Name = "dateNgayNhan";
            this.dateNgayNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayNhan.Properties.Appearance.Options.UseFont = true;
            this.dateNgayNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhan.Size = new System.Drawing.Size(184, 26);
            this.dateNgayNhan.TabIndex = 130;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(593, 134);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(125, 22);
            this.lblNgayTra.TabIndex = 127;
            this.lblNgayTra.Text = "Ngày trả phòng:";
            // 
            // lblNgayNhan
            // 
            this.lblNgayNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhan.Location = new System.Drawing.Point(305, 134);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(140, 22);
            this.lblNgayNhan.TabIndex = 128;
            this.lblNgayNhan.Text = "Ngày nhận phòng:";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Location = new System.Drawing.Point(17, 134);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(94, 22);
            this.lblLoaiPhong.TabIndex = 129;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(1256, 118);
            this.lblTittle.TabIndex = 139;
            this.lblTittle.Text = "Quản lý Đặt Phòng";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnuStrip
            // 
            this.mnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DP_mnuDanhMuc});
            this.mnuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuStrip.Size = new System.Drawing.Size(90, 27);
            this.mnuStrip.TabIndex = 140;
            // 
            // DP_mnuDanhMuc
            // 
            this.DP_mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPhong,
            this.mnuLoaiPhong,
            this.mnuChiTietDatPhong});
            this.DP_mnuDanhMuc.Name = "DP_mnuDanhMuc";
            this.DP_mnuDanhMuc.Size = new System.Drawing.Size(82, 23);
            this.DP_mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuPhong
            // 
            this.mnuPhong.Name = "mnuPhong";
            this.mnuPhong.Size = new System.Drawing.Size(185, 24);
            this.mnuPhong.Text = "Phòng";
            this.mnuPhong.Click += new System.EventHandler(this.mnuPhong_Click);
            // 
            // mnuLoaiPhong
            // 
            this.mnuLoaiPhong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHinhAnh});
            this.mnuLoaiPhong.Name = "mnuLoaiPhong";
            this.mnuLoaiPhong.Size = new System.Drawing.Size(185, 24);
            this.mnuLoaiPhong.Text = "Loại phòng";
            this.mnuLoaiPhong.Click += new System.EventHandler(this.mnuLoaiPhong_Click);
            // 
            // mnuHinhAnh
            // 
            this.mnuHinhAnh.Name = "mnuHinhAnh";
            this.mnuHinhAnh.Size = new System.Drawing.Size(131, 24);
            this.mnuHinhAnh.Text = "Hình ảnh";
            this.mnuHinhAnh.Click += new System.EventHandler(this.mnuHinhAnh_Click);
            // 
            // mnuChiTietDatPhong
            // 
            this.mnuChiTietDatPhong.Name = "mnuChiTietDatPhong";
            this.mnuChiTietDatPhong.Size = new System.Drawing.Size(185, 24);
            this.mnuChiTietDatPhong.Text = "Chi tiết đặt phòng";
            this.mnuChiTietDatPhong.Click += new System.EventHandler(this.mnuChiTietDatPhong_Click);
            // 
            // uscDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.lblDaDat);
            this.Controls.Add(this.lblTrong);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.lblPlaced);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.dateNgayTra);
            this.Controls.Add(this.dateNgayNhan);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblNgayNhan);
            this.Controls.Add(this.lblLoaiPhong);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uscDatPhong";
            this.Size = new System.Drawing.Size(1256, 649);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDisplay)).EndInit();
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radgrpChoose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChoose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLoaiPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlDisplay;
        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radDaDat;
        private System.Windows.Forms.RadioButton radTrong;
        private DevExpress.XtraEditors.RadioGroup radgrpChoose;
        private System.Windows.Forms.Button btnDatPhong;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.TextEdit txtChoose;
        private DevExpress.XtraEditors.LabelControl lblChoose;
        private DevExpress.XtraEditors.PictureEdit picDisplay;
        private DevExpress.XtraEditors.LabelControl lblDaDat;
        private DevExpress.XtraEditors.LabelControl lblTrong;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblPlaced;
        private DevExpress.XtraEditors.ComboBoxEdit cboLoaiPhong;
        private DevExpress.XtraEditors.DateEdit dateNgayTra;
        private DevExpress.XtraEditors.DateEdit dateNgayNhan;
        private DevExpress.XtraEditors.LabelControl lblNgayTra;
        private DevExpress.XtraEditors.LabelControl lblNgayNhan;
        private DevExpress.XtraEditors.LabelControl lblLoaiPhong;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem DP_mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuHinhAnh;
        private System.Windows.Forms.ToolStripMenuItem mnuChiTietDatPhong;
    }
}

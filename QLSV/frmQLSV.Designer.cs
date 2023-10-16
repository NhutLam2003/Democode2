
namespace QLSV
{
    partial class frmQLSV
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
            this.components = new System.ComponentModel.Container();
            this.radTatCa = new System.Windows.Forms.RadioButton();
            this.radMSSV = new System.Windows.Forms.RadioButton();
            this.grpBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.radLop = new System.Windows.Forms.RadioButton();
            this.btnTKHT = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.radHoTen = new System.Windows.Forms.RadioButton();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qLSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDataSet = new QLSV.QLSVDataSet();
            this.btnLuu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTKMS = new System.Windows.Forms.Button();
            this.grpBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radTatCa
            // 
            this.radTatCa.AutoSize = true;
            this.radTatCa.Checked = true;
            this.radTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTatCa.Location = new System.Drawing.Point(10, 31);
            this.radTatCa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radTatCa.Name = "radTatCa";
            this.radTatCa.Size = new System.Drawing.Size(90, 24);
            this.radTatCa.TabIndex = 0;
            this.radTatCa.TabStop = true;
            this.radTatCa.Text = "Tất Cả";
            this.radTatCa.UseVisualStyleBackColor = true;
            this.radTatCa.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // radMSSV
            // 
            this.radMSSV.AutoSize = true;
            this.radMSSV.Location = new System.Drawing.Point(10, 88);
            this.radMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMSSV.Name = "radMSSV";
            this.radMSSV.Size = new System.Drawing.Size(95, 26);
            this.radMSSV.TabIndex = 1;
            this.radMSSV.Text = "MSSV:";
            this.radMSSV.UseVisualStyleBackColor = true;
            this.radMSSV.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // grpBoxTimKiem
            // 
            this.grpBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxTimKiem.Controls.Add(this.cbbLop);
            this.grpBoxTimKiem.Controls.Add(this.radLop);
            this.grpBoxTimKiem.Controls.Add(this.btnTKHT);
            this.grpBoxTimKiem.Controls.Add(this.txtHoTen);
            this.grpBoxTimKiem.Controls.Add(this.radHoTen);
            this.grpBoxTimKiem.Controls.Add(this.btnTKMS);
            this.grpBoxTimKiem.Controls.Add(this.txtMSSV);
            this.grpBoxTimKiem.Controls.Add(this.radMSSV);
            this.grpBoxTimKiem.Controls.Add(this.radTatCa);
            this.grpBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxTimKiem.Location = new System.Drawing.Point(284, 77);
            this.grpBoxTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxTimKiem.Name = "grpBoxTimKiem";
            this.grpBoxTimKiem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBoxTimKiem.Size = new System.Drawing.Size(868, 154);
            this.grpBoxTimKiem.TabIndex = 0;
            this.grpBoxTimKiem.TabStop = false;
            this.grpBoxTimKiem.Text = "Tìm Kiếm";
            // 
            // cbbLop
            // 
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Location = new System.Drawing.Point(546, 86);
            this.cbbLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(210, 30);
            this.cbbLop.TabIndex = 8;
            this.cbbLop.SelectedValueChanged += new System.EventHandler(this.cbbLop_SelectedValueChanged);
            // 
            // radLop
            // 
            this.radLop.AutoSize = true;
            this.radLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLop.Location = new System.Drawing.Point(441, 91);
            this.radLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radLop.Name = "radLop";
            this.radLop.Size = new System.Drawing.Size(65, 24);
            this.radLop.TabIndex = 7;
            this.radLop.Text = "Lớp";
            this.radLop.UseVisualStyleBackColor = true;
            this.radLop.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // btnTKHT
            // 
            this.btnTKHT.BackgroundImage = global::QLSV.Properties.Resources.timkiem;
            this.btnTKHT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTKHT.Location = new System.Drawing.Point(766, 25);
            this.btnTKHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTKHT.Name = "btnTKHT";
            this.btnTKHT.Size = new System.Drawing.Size(34, 35);
            this.btnTKHT.TabIndex = 6;
            this.btnTKHT.UseVisualStyleBackColor = true;
            this.btnTKHT.Click += new System.EventHandler(this.btnTKHT_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(546, 26);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(210, 28);
            this.txtHoTen.TabIndex = 5;
            // 
            // radHoTen
            // 
            this.radHoTen.AutoSize = true;
            this.radHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHoTen.Location = new System.Drawing.Point(441, 31);
            this.radHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radHoTen.Name = "radHoTen";
            this.radHoTen.Size = new System.Drawing.Size(101, 24);
            this.radHoTen.TabIndex = 4;
            this.radHoTen.Text = "Họ Tên:";
            this.radHoTen.UseVisualStyleBackColor = true;
            this.radHoTen.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(120, 86);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(210, 28);
            this.txtMSSV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(396, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSV.AutoGenerateColumns = false;
            this.dgvDSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMSSV,
            this.colHo,
            this.colTen,
            this.colLopHoc,
            this.colNgaySinh,
            this.colDiaChi,
            this.colTrangThai,
            this.colID});
            this.dgvDSSV.DataSource = this.qLSVDataSetBindingSource;
            this.dgvDSSV.Location = new System.Drawing.Point(18, 240);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 62;
            this.dgvDSSV.Size = new System.Drawing.Size(1134, 398);
            this.dgvDSSV.TabIndex = 2;
            // 
            // colMSSV
            // 
            this.colMSSV.DataPropertyName = "MSSV";
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.MinimumWidth = 8;
            this.colMSSV.Name = "colMSSV";
            // 
            // colHo
            // 
            this.colHo.DataPropertyName = "Ho";
            this.colHo.HeaderText = "Họ";
            this.colHo.MinimumWidth = 8;
            this.colHo.Name = "colHo";
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "Ten";
            this.colTen.HeaderText = "Tên";
            this.colTen.MinimumWidth = 8;
            this.colTen.Name = "colTen";
            // 
            // colLopHoc
            // 
            this.colLopHoc.DataPropertyName = "MaLop";
            this.colLopHoc.HeaderText = "Lớp học";
            this.colLopHoc.MinimumWidth = 8;
            this.colLopHoc.Name = "colLopHoc";
            this.colLopHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLopHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 8;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 8;
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // qLSVDataSetBindingSource
            // 
            this.qLSVDataSetBindingSource.DataSource = this.qLSVDataSet;
            this.qLSVDataSetBindingSource.Position = 0;
            // 
            // qLSVDataSet
            // 
            this.qLSVDataSet.DataSetName = "QLSVDataSet";
            this.qLSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Image = global::QLSV.Properties.Resources.save;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1076, 648);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 35);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLSV.Properties.Resources.sv;
            this.pictureBox1.Location = new System.Drawing.Point(62, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnTKMS
            // 
            this.btnTKMS.BackgroundImage = global::QLSV.Properties.Resources.timkiem;
            this.btnTKMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTKMS.Location = new System.Drawing.Point(340, 85);
            this.btnTKMS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTKMS.Name = "btnTKMS";
            this.btnTKMS.Size = new System.Drawing.Size(34, 35);
            this.btnTKMS.TabIndex = 3;
            this.btnTKMS.UseVisualStyleBackColor = true;
            this.btnTKMS.Click += new System.EventHandler(this.btnTKMS_Click);
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvDSSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxTimKiem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.grpBoxTimKiem.ResumeLayout(false);
            this.grpBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTatCa;
        private System.Windows.Forms.RadioButton radMSSV;
        private System.Windows.Forms.GroupBox grpBoxTimKiem;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.RadioButton radLop;
        private System.Windows.Forms.Button btnTKHT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.RadioButton radHoTen;
        private System.Windows.Forms.Button btnTKMS;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.BindingSource qLSVDataSetBindingSource;
        private QLSVDataSet qLSVDataSet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLopHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.Button btnLuu;
    }
}


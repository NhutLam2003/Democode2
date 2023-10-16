using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSV
{
    public partial class frmQLSV : Form
    {
        //static string strKetNoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\QLSV\DB\qlsv.mdf;Integrated Security=True;Connect Timeout=30";
        static string strKetNoi = @"Data Source=.\sqlexpress;Initial Catalog=QLSV;Integrated Security=True";
        // 
        SqlDataAdapter daLop;
        SqlDataAdapter daSinhVien;
        DataSet dsQLSV = new DataSet();
        DataView dvSinhVien;
        public frmQLSV()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            daLop = new SqlDataAdapter("SELECT * FROM Lop", strKetNoi);
            daLop.Fill(dsQLSV, "tblLop");

            cbbLop.DataSource = dsQLSV.Tables["tblLop"].Copy();
            cbbLop.DisplayMember = "TenLop";
            cbbLop.ValueMember = "MaLop";

            colLopHoc.DataSource = dsQLSV.Tables["tblLop"].Copy();
            colLopHoc.DisplayMember = "TenLop";
            colLopHoc.ValueMember = "MaLop";

            //daSinhVien = new SqlDataAdapter("SELECT * FROM SinhVien", strKetNoi);
            //daSinhVien.Fill(dsQLSV, "tblSinhVien");
            //dgvDSSV.DataSource = dsQLSV.Tables["tblSinhVien"].Copy();

            daSinhVien = new SqlDataAdapter("SELECT * From SinhVien where TrangThai=1", strKetNoi);
            SqlCommand insCom = new SqlCommand("INSERT INTO SinhVien (MSSV,Ho,Ten,Malop,DiaChi,TrangThai,NgaySinh) values(@MSSV,@Ho,@Ten,@Lop,@DiaChi,1,@NgaySinh)");
            insCom.Parameters.Add("@MSSV", SqlDbType.NVarChar, 10, "MSSV");
            insCom.Parameters.Add("@Ho", SqlDbType.NVarChar, 50, "Ho");
            insCom.Parameters.Add("@Ten", SqlDbType.NVarChar, 50, "Ten");
            insCom.Parameters.Add("@Lop", SqlDbType.Int, 10, "MaLop");
            insCom.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 1000, "DiaChi");
            insCom.Parameters.Add("@NgaySinh", SqlDbType.Date, 20, "NgaySinh");

            daSinhVien.InsertCommand = insCom;

            SqlCommand delCom = new SqlCommand("UPDATE SinhVien SET TrangThai=0 WHERE ID=@ID");
            delCom.Parameters.Add("@ID", SqlDbType.Int, 100, "ID");

            daSinhVien.DeleteCommand = delCom;

            SqlCommandBuilder scb = new SqlCommandBuilder(daSinhVien);

            daSinhVien.Fill(dsQLSV, "tblSinhVien");
            dvSinhVien = dsQLSV.Tables["tblSinhVien"].DefaultView;
            dgvDSSV.DataSource = dvSinhVien;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            daSinhVien.Update(dsQLSV, "tblSinhVien");
            dsQLSV.Tables["tblSinhVien"].Rows.Clear();

            daSinhVien.Fill(dsQLSV, "tblSinhVien");
            dvSinhVien = dsQLSV.Tables["tblSinhVien"].DefaultView;
            dgvDSSV.DataSource = dvSinhVien;
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            if (radMSSV.Checked) dvSinhVien.RowFilter = "MSSV='" + txtMSSV.Text + "'";
            if (radLop.Checked) dvSinhVien.RowFilter = "MaLop='" + cbbLop.SelectedValue +"'";
            if (radHoTen.Checked) dvSinhVien.RowFilter = "Ho+''+Ten like'%" + txtHoTen + "'";
            if (radTatCa.Checked) dvSinhVien.RowFilter = "";
        }

        private void btnTKMS_Click(object sender, EventArgs e)
        {
            if (radMSSV.Checked) dvSinhVien.RowFilter = "MSSV='" + txtMSSV.Text + "'";
            txtMSSV.Text = string.Empty;
        }

        private void btnTKHT_Click(object sender, EventArgs e)
        {
            if (radHoTen.Checked) dvSinhVien.RowFilter = "Ho+''+Ten like '%" + txtHoTen.Text + "%'";
            txtHoTen.Text = string.Empty;
        }

        private void cbbLop_SelectedValueChanged(object sender, EventArgs e)
        {
            if (radLop.Checked) dvSinhVien.RowFilter = "MaLop='" + cbbLop.SelectedValue + "'";
        }
    }
}

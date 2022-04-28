using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyCamDo.Design
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public static string quyen;
        //public static string IDNV;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            CSDL.Connect();
            if (txtTaiKhoan.Text != string.Empty && txtMatKhau.Text != string.Empty)
            {
                CSDL.ketnoi.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string ktra = "select * from TaiKhoan where Usersname='" + tk + "'and Password='" + mk + "'";
                SqlCommand cmd = new SqlCommand(ktra, CSDL.ketnoi);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    CSDL.ketnoi.Close();
                    CSDL.ketnoi.Open();
                    string quyentk = "select * from TaiKhoan where Usersname='" + txtTaiKhoan.Text.ToString() + "'";
                    SqlCommand cm = new SqlCommand(quyentk, CSDL.ketnoi);
                    SqlDataReader kq = cm.ExecuteReader();
                    if (kq.HasRows)
                    {
                        kq.Read();
                        quyen = kq.GetString(2).ToString();
                        //idnv = kq.GetString(2).toString();
                    }
                    TrangChu mainform = new TrangChu();
                    mainform.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                }
            }
        }

      
    }
}

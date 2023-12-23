using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7
{
    public partial class TimKiemSP : System.Web.UI.Page
    {
        public static string chuoiKN = "Data Source=LAPTOP-7DS1CFED\\SQLEXPRESS;Initial Catalog=QL_SANPHAM;Integrated Security=True";
        public static SqlConnection cn = new SqlConnection(chuoiKN);

        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        void HienThi()
        {
            try
            {
                string chuoiSQL = "SELECT * FROM tbl_SanPham";
                SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception)
            {
                Label1.Text = "Lỗi kết nối!";
            }
        }

        protected void btnTimTheoMa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSP.Text == "")
                {
                    HienThi();
                }
                else
                {
                    string chuoiSQL = "SELECT * FROM tbl_SanPham where MaSP = N'" + txtMaSP.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    txtMaSP.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }

        protected void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSP.Text == "")
                {
                    HienThi();
                }
                else
                {
                    string chuoiSQL = "SELECT * FROM tbl_SanPham where TenSP = N'" + txtTenSP.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    txtTenSP.Text = "";
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7
{
    public partial class CapNhatSP : System.Web.UI.Page
    {
        public static string chuoiKN = "Data Source=LAPTOP-7DS1CFED\\SQLEXPRESS;Initial Catalog=QL_SANPHAM;Integrated Security=True";
        public static SqlConnection cn = new SqlConnection(chuoiKN);
        protected void Page_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        void ThucThi(string caulenh)
        {
            SqlCommand cm = new SqlCommand(caulenh, cn);
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
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

        protected void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            string chuoiSQL = "INSERT INTO tbl_SanPham values ('" + txtMaSP.Text + "',N'" + txtTenSP.Text + "')";
            ThucThi(chuoiSQL);
            HienThi();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuoiSQL = "SELECT * FROM tbl_SanPham";
            SqlDataAdapter da = new SqlDataAdapter(chuoiSQL, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int dong = GridView1.SelectedIndex;
            int trang = GridView1.PageIndex;
            txtMaSP.Text = dt.Rows[trang * 3 + dong][0].ToString();
            txtTenSP.Text = dt.Rows[trang * 3 + dong][1].ToString();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            string chuoiSQL = "UPDATE tbl_SanPham SET TenSP=N'" + txtTenSP.Text + "'where MaSP = '" + txtMaSP.Text + "'";
            ThucThi(chuoiSQL);
            HienThi();
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            string chuoiSQL = "DELETE tbl_SanPham where MaSP='" + txtMaSP.Text + "'";
            ThucThi(chuoiSQL);
            HienThi();
            txtMaSP.Text = "";
            txtTenSP.Text = "";
        }
    }
}
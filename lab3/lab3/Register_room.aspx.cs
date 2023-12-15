using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab3
{
    public partial class Register_room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDangKy_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblThongBao.Text = string.Format($"Chúc mừng  {txtHoTen.Text} đăng ký thành công! <br/> Cơ quan: {txtCoQuan.Text} <br/> Email: {txtEmail.Text} <br/> ngày checkin: {txtCheckin.Text} <br/> Số ngày ở: {txtSoNgay.Text} <br/> Loại phòng: {cbxLoaiPhong.SelectedItem.Text}");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab7
{
    public partial class TinhToan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTong_Click(object sender, EventArgs e)
        {
            int n, sum;
            n = int.Parse(txtN.Text);

            sum = (n * (n + 1)) / 2;
            
            lblResult.Text = $"Tổng từ 1 đến {n} là: {sum}";
        }
    }
}
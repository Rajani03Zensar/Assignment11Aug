using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebControlAssign
{
    public partial class PlayerDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }
    }
}
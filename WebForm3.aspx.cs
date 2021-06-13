using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace holidayRedesign
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedItem.Text == "United Kingdom")
                Server.Transfer("WebForm2.aspx");
            if (DropDownList1.SelectedItem.Text == "Ireland")
                Server.Transfer("WebForm1.aspx");
        }
    }
}
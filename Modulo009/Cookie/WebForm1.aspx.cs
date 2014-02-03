using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["NOME"] != null)
            {
                labelNome.Text = Request.Cookies["NOME"].Value;

                MV.ActiveViewIndex = 1;
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var c = new HttpCookie("NOME", Nome.Text); //HttpCookie c = new HttpCookie("NOME", Nome.Text);
            
            c.Expires = DateTime.Now.AddDays(7);
            
            Response.Cookies.Add(c);

            Response.Redirect(Request.ServerVariables["URL"]);
        }
    }
}
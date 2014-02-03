using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerSentEvents
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();

            Response.ContentType = "text/event-stream";
            Response.Expires = -1;

            Response.Write(String.Format("data: {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.fff")));

            Response.Flush();
        }
    }
}
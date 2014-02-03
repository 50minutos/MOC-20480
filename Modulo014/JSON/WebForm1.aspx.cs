using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JSON
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Clear();

            Response.ContentType = "application/json";

            Response.Write(@"{
    ""Codigo"": ""1"", 
    ""Nome"": ""ADAO"" 
}");
            //ou
            //Response.Write("{\n\t\"Codigo\": \"1\",\n\t\"Nome\": \"ADAO\"\n}");
            
            Response.Flush();

            Response.End();
        }
    }
}
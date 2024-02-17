using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GistXclient
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GistXServices.ServiceClient sc = new GistXServices.ServiceClient();
                string username = Request.Form["username"];
                string password = Request.Form["password"];

                GistXServices.ResponseContract rc = sc.Login(username,password);
                Session["LoggedIn"] = true;
                Session["UserId"] = rc.id;
                if (rc.status == 1)
                {
                    Response.Write(rc.message);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Write(rc.message);
                }

            }
        }
    }
}
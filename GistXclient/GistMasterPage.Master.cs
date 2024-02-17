using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GistXclient
{
    public partial class GistMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                bool isLoggedIn = Session["LoggedIn"] as bool? ?? false;

                if (isLoggedIn)
                {

                    signInItem.Visible = false;
                    signUpItem.Visible = false;
                    logoutItem.Visible = true;
                }
                else
                {
                    signInItem.Visible = true;
                    signUpItem.Visible = true;
                    logoutItem.Visible = false;
                }

            }
        }
        
        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("SignIn.aspx");
        }
        
    }
}
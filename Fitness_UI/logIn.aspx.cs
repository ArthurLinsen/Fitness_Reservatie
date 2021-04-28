using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fitness_Domain.Business;

namespace Fitness_UI
{
    public partial class logIn : System.Web.UI.Page
    {
        private Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                _controller = (Controller)HttpContext.Current.Session["_controller"];
            }
            else
            {
                if (HttpContext.Current.Session["_controller"] == null)
                {
                    _controller = new Controller();
                    HttpContext.Current.Session["_controller"] = _controller;
                }
                else
                {
                    _controller = (Controller)HttpContext.Current.Session["_controller"];
                }
            }
        }
        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtEmailadres.Text == "moderator@mod.com")
            {
                Response.Redirect("ModeratorMain.aspx");
            }
            else 
            {
                if (_controller.LoginUser(txtEmailadres.Text))
                {
                    Response.Redirect("ReservatieAanbod.aspx");
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "s", "window.alert('Het emailadres en/of het wachtwoord komt niet overeen');", true);
                }
            }
        }
    }
}
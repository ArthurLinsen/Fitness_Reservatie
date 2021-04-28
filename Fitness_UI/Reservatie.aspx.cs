using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fitness_Domain.Business;

namespace Fitness_UI
{
    public partial class Reservatie : System.Web.UI.Page
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
        protected void btnSingIn_Click(object sender, EventArgs e)
        {
            //SignIn btn
            Response.Redirect("logIn.aspx");
        }
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            //SignUp btn
            Response.Redirect("Aanmeld.aspx");
        }
    }
}
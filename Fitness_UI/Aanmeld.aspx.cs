using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fitness_Domain.Business;

namespace Fitness_UI
{
    public partial class Aanmeld : System.Web.UI.Page
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

        protected void btnMeldAan_Click(object sender, EventArgs e)
        {
            _controller.setLid(txtfamilienaam.Text, txtVoornaam.Text, Convert.ToDateTime(txtGeboortedatum.Text), txtAdres.Text, Convert.ToInt32(txtPostcode.Text), txtGemeente.Text, txtTelefoonnummer.Text, txtEmailadres.Text, txtRijksregisternummer.Text);
            Response.Redirect("logIn.aspx");
        }
    }
}
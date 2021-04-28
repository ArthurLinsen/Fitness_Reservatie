using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fitness_Domain.Business;

namespace Fitness_UI
{
    public partial class ReservatieAanbod : System.Web.UI.Page
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
                fillrbtnSoortLes();     
            }
        }
        private void fillrbtnSoortLes()
        {
            List<Les> alleLessen = _controller.getLessen();
            rbtnSoortLes.DataSource = alleLessen;
            rbtnSoortLes.DataBind();
        }
        private void fillrbtnDatumEnTijd()
        {
            List<VrijeReservatie> alleDataEnTijd = _controller.getVrijeReservaties();
            rbtnDatumEnTijd.DataSource = alleDataEnTijd;
            rbtnDatumEnTijd.DataBind();
        }
        protected void btnKiesLes_Click(object sender, EventArgs e)
        {

            fillrbtnDatumEnTijd();
        }
        protected void btnReserveer_Click(object sender, EventArgs e)
        {
            
        } 
    }
}
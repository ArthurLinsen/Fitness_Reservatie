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
            List<Fitness_Domain.Business.Les> SoortLes = _controller.getLessen();
            List<string> SoortLesStrings = new List<string>();
            foreach (Fitness_Domain.Business.Les item in SoortLes)
            {
                SoortLesStrings.Add(item.Naam.ToString());
            }
            rbtnSoortLes.DataSource = SoortLesStrings;
            rbtnSoortLes.DataBind();
        }
        private void fillrbtnDatum()
        {
            List<Fitness_Domain.Business.Reservatie> DataGekozenLes = _controller.getVrijeReservatieFromGekozenLes();
            HashSet<string> DataGekozenLesStrings = new HashSet<string>();
            foreach (Fitness_Domain.Business.Reservatie item in DataGekozenLes)
            {
                DataGekozenLesStrings.Add(item.Datum.ToShortDateString());
            }
            rbtnDatum.DataSource = DataGekozenLesStrings;
            rbtnDatum.DataBind();
        }
        private void fillrbtnTijd()
        {
            List<Fitness_Domain.Business.Reservatie> TijdGekozenLes = _controller.getVrijeReservatieFromGekozenLes();
            HashSet<string> TijdGekozenLesStrings = new HashSet<string>();
            foreach (Fitness_Domain.Business.Reservatie item in TijdGekozenLes)
            {
                TijdGekozenLesStrings.Add(item.Tijdstip.ToString());
            }
            rbtnTijd.DataSource = TijdGekozenLesStrings;
            rbtnTijd.DataBind();

        }
        protected void btnGekozenLes_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                index = rbtnSoortLes.SelectedIndex;
            }
            catch
            {
                //foutmelding eventueel
                return;
            }
            _controller.KiesLes(index);
            fillrbtnDatum();
        }
        protected void btnGekozenDatum_Click(object sender, EventArgs e)
        {
            fillrbtnTijd();
        }
        protected void btnReserveer_Click(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                index = rbtnSoortLes.SelectedIndex;
            }
            catch
            {
                _controller.reserveerBeschikbareReservatie(index);
                ClientScript.RegisterClientScriptBlock(this.GetType(), "s", "window.alert('De reservatie is gelukt, u ontvangt één dag van tevoren een herinneringsemail');", true);
                return;
            }
            Response.Redirect("Home.aspx");
        }
    }
}
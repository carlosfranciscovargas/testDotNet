using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace administraClima.clima
{
    public partial class verclimaactual : System.Web.UI.Page
    {
        SRClima.ClimaServiceClient cli = new SRClima.ClimaServiceClient();
        int idezona;
        DateTime thisDay = DateTime.Now;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
            {
                drlizona.DataSource = cli.listarZonas();
                drlizona.DataValueField = "idezona";
                drlizona.DataTextField = "zona";
                drlizona.DataBind();
            }
            lblfechahora.Text = thisDay.ToString();
        }

        protected void drlizona_SelectedIndexChanged(object sender, EventArgs e)
        {
            idezona = Int16.Parse(drlizona.SelectedValue);
            llenargrid();
        }
        public void llenargrid()
        {
            idezona = Int16.Parse(drlizona.SelectedValue);



            try
            {
                GridView1.DataSource = cli.verClima(idezona, thisDay);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
            }
           
            
        }
    }
}
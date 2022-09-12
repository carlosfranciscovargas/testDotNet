using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace administraClima.clima
{
    public partial class clima : System.Web.UI.Page
    {
        SRClima.ClimaServiceClient cli = new SRClima.ClimaServiceClient();
        int idezona;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true) { 
                drlizona.DataSource = cli.listarZonas();
                drlizona.DataValueField = "idezona";
                drlizona.DataTextField = "zona";
                drlizona.DataBind();
            }
           
                
        }

        

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            llenargrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            int ideclima = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            int idezona = Int16.Parse(((TextBox)row.Cells[3].Controls[0]).Text);
            DateTime fechayhora = DateTime.Parse(((TextBox)row.Cells[4].Controls[0]).Text);
            string  temperatura= ((TextBox)row.Cells[5].Controls[0]).Text;
            string presipitacion = ((TextBox)row.Cells[6].Controls[0]).Text;
            string viento = ((TextBox)row.Cells[7].Controls[0]).Text;
            GridView1.EditIndex = -1;
            cli.actualizarClima(ideclima, idezona, fechayhora, temperatura, presipitacion, viento);
            llenargrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        public void llenargrid()
        {
            idezona = Int16.Parse(drlizona.SelectedValue);
        GridView1.DataSource = cli.listarClimasPorZona(idezona);
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            llenargrid();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;  
        }

        protected void btnagregar_Click(object sender, EventArgs e)
        {

            idezona = Int16.Parse(drlizona.SelectedValue);
            string presipitacio = txtpresipitacion.Text;
            string viento = txtviento.Text;
            string temperatura = txtemperatura.Text;
            DateTime fechahora = DateTime.Parse(txtfecha.Text);
         //   SRClima.ClimaServiceClient clima = new SRClima.ClimaServiceClient();
            cli.agregarClima(idezona, fechahora, txtemperatura.Text, txtpresipitacion.Text, txtviento.Text);
            llenargrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ideclima = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            
            GridView1.EditIndex = -1;
            cli.eliminarClima(ideclima);
            llenargrid();
        }

        protected void drlizona_SelectedIndexChanged(object sender, EventArgs e)
        {
            idezona = Int16.Parse(drlizona.SelectedValue);
            llenargrid();
        }

        
        
    }
}
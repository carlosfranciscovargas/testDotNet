using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace administraClima.zona
{
    public partial class adminzona: System.Web.UI.Page
    {
        SRClima.ClimaServiceClient cli = new SRClima.ClimaServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != true)
                llenargrid();
        }

        

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            llenargrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idezona = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            string zona = ((TextBox)row.Cells[3].Controls[0]).Text;
                  GridView1.EditIndex = -1;
            cli.actualizarZona(idezona, zona);
            llenargrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        public void llenargrid()
        {
        GridView1.DataSource = cli.listarZonas();
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
            string zon = txtzonao.Text;
            
            SRClima.ClimaServiceClient clima = new SRClima.ClimaServiceClient();
            clima.agregarZona(zon);
            llenargrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int idezon = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            
            GridView1.EditIndex = -1;
            cli.eliminarZona(idezon);
            llenargrid();
        }
        
    }
}
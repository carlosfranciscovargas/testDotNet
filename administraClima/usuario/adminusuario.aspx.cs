using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace administraClima.zona
{
    public partial class adminusuario : System.Web.UI.Page
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
            int ideusuario = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            string usuario = ((TextBox)row.Cells[3].Controls[0]).Text;
            string contraseña = ((TextBox)row.Cells[4].Controls[0]).Text;
            GridView1.EditIndex = -1;
            cli.actualizarUsuario(ideusuario, usuario, contraseña);
            llenargrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        public void llenargrid()
        {
        GridView1.DataSource = cli.listarUsuario();
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
            string usuario = txtusuario.Text;
            string password = txtpassword.Text;
            SRClima.ClimaServiceClient clima = new SRClima.ClimaServiceClient();
            clima.agregarUsuario(usuario, password);
            llenargrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ideusuario = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            
            GridView1.EditIndex = -1;
            cli.eliminarUsuario(ideusuario);
            llenargrid();
        }
        
    }
}
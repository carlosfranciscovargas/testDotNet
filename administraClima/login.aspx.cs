using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace administraClima
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
          
          
           if (Page.IsValid)
           {
               this.Session["usuario"] = "true";
               Response.Redirect("principal.aspx");
           }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            SRClima.ClimaServiceClient user = new SRClima.ClimaServiceClient();
            bool result =  user.login(txtusurio.Text.Trim(), txtpassword.Text.Trim());
            if (result)
            {
                args.IsValid = true;
               
                

            }
            else{
                args.IsValid = false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_controlClima.modelo;

namespace WS_controlClima
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClimaService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClimaService.svc o ClimaService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClimaService : IClimaService
    {
#region "usuario"
        public bool login(string usuario, string pass)
        {
           bool resultado = modelo.UsuarioDAL.loginUser(usuario, pass);
            
            return resultado;
        }
        public string agregarUsuario(string usuario, string password)
        {
            string respuesta = "";
            tlbusuario user = new tlbusuario();
            user.contraseña = password;
            user.usuario = usuario;
            respuesta=modelo.UsuarioDAL.AddUser(user);
            return respuesta;
            
        }
        public string actualizarUsuario(int ideusuario, string usuario, string password)
        {
            string respuesta = "";
            tlbusuario user = new tlbusuario();
            user.ideusuario = ideusuario;
            user.contraseña = password;
            user.usuario = usuario;
            respuesta = modelo.UsuarioDAL.UpdateUser(user);
            return respuesta;
        
        }
        public string eliminarUsuario(int ideusuario)
        {
            string respuesta = "";
            respuesta = modelo.UsuarioDAL.DeleteUser(ideusuario);
            return respuesta;
        }
        public List<tlbusuario> listarUsuario()
        {
            return modelo.UsuarioDAL.getUsers();
        }
#endregion
 #region "zona"
        public string agregarZona(string zona)
        {
            string respuesta = "";
            tblzona zn = new tblzona();
            zn.zona = zona;
        
            respuesta = modelo.ZonaDAL.Addzona(zn);
            return respuesta;

        }
        public string actualizarZona(int idezona, string zona)
        {
            string respuesta = "";
            tblzona zn = new tblzona();
            zn.zona = zona;
            respuesta = modelo.ZonaDAL.Addzona(zn);
            return respuesta;

        }
        public string eliminarZona(int idezon)
        {
            string respuesta = "";
            respuesta = modelo.ZonaDAL.Deletezona(idezon);
            return respuesta;
        }
        public List<tblzona> listarZonas()
        {
            return modelo.ZonaDAL.getZonas();
        }
 #endregion
 #region "clima"
        public string agregarClima(int idezona,DateTime fechahora,string temperatura,string presipitacion,string viento)
        {
            string respuesta = "";
            tblclima cli = new tblclima();
            cli.idezona = idezona;
            cli.fechayhora = fechahora;
            cli.temperatura=temperatura;
              cli.presipitacion = presipitacion;
              cli.viento = viento;
            respuesta = modelo.ClimaDAL.addClima(cli);
            return respuesta;

        }
        public string actualizarClima(int ideclima,int idezona, DateTime fechahora,string temperatura, string presipitacion, string viento)
        {
            string respuesta = "";
            tblclima cli = new tblclima();
            cli.ideclima = ideclima;
            cli.idezona = idezona;
            cli.fechayhora = fechahora;
            cli.temperatura = temperatura;
            cli.presipitacion = presipitacion;
            cli.viento = viento;
            respuesta = modelo.ClimaDAL.updateClima(cli);
            return respuesta;
         }
        public string eliminarClima(int ideclima)
        {
            string respuesta = "";
            respuesta = modelo.ClimaDAL.deleteClima(ideclima);
            return respuesta;
        }
        public List<tblclima> listarClimas()
        {
            return modelo.ClimaDAL.getClimas();
        }
        public List<tblclima> listarClimasPorZona(int idezona)
        {
            return modelo.ClimaDAL.getClimabyzon(idezona);
        }
        public List<tblclima> verClima(int idezona, DateTime fechahora)
        {
            return modelo.ClimaDAL.watchClima(idezona,fechahora);
        }
   #endregion
    }
 
  
}

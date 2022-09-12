using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WS_controlClima.modelo;

namespace WS_controlClima
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClimaService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClimaService
    {
        [OperationContract]
        string agregarUsuario(string usuario, string password);
        [OperationContract]
        bool login(string user, string pass);
        [OperationContract]
         string actualizarUsuario(int ideusuario, string usuario, string password);
        [OperationContract]
        string eliminarUsuario(int ideusuario);
        [OperationContract]
         List<tlbusuario> listarUsuario();
        [OperationContract]
        string agregarZona(string zona);
        [OperationContract]
        string actualizarZona(int idezona, string zona);
        [OperationContract]
        string eliminarZona(int idezon);
        [OperationContract]
        List<tblzona> listarZonas();
        [OperationContract]
        string agregarClima(int idezona,DateTime fechahora, string temperatura, string presipitacion, string viento);
        [OperationContract]
        string actualizarClima(int ideclima, int idezona, DateTime fechahora, string temperatura, string presipitacion, string viento);
         [OperationContract]
        string eliminarClima(int ideclima);
         [OperationContract]
         List<tblclima> listarClimas();
         [OperationContract]
         List<tblclima> listarClimasPorZona(int idezona);
        [OperationContract]
         List<tblclima> verClima(int idezona, DateTime fechahora);
    }
}

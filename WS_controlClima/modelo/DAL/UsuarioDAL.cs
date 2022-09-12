using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_controlClima.modelo
{
    public class UsuarioDAL 
    {
        public  static string AddUser(tlbusuario model)
        {
            string resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                db.AddTotlbusuarios(model);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    resultado = ex.Message;
                }
                return resultado;
            }
        }

        public static string UpdateUser(tlbusuario model)
        {
            string resultado;
            resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                var qry = from b in db.tlbusuarios
                          where b.ideusuario == model.ideusuario
                          select b;
                foreach (tlbusuario b in qry)
                {
                    b.usuario = model.usuario;
                    b.contraseña = model.contraseña;
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    resultado = e.Message;
                }
            }

            return resultado;
        }
        public static string DeleteUser(int ideusuario)
        {
            string resultado;
            resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                tlbusuario user = new tlbusuario();
                user = db.tlbusuarios.FirstOrDefault(b => b.ideusuario == ideusuario);
                try
                {
                    if (user != null)
                    {
                        db.DeleteObject(user);
                        db.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    resultado = e.Message;
                }
            }

            return resultado;
        }

        public static List<tlbusuario> getUsers()
        {
            List<tlbusuario> userList = new List<tlbusuario>();
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                var qry = from b in db.tlbusuarios
                          select b;
                foreach (tlbusuario b in qry)
                {
                    tlbusuario us = new tlbusuario();
                    us = b;
                    userList.Add(us);
                }
            }

            return userList;
        }
        public static bool loginUser(string usuario,string password)
        {
            bool respuesta = true;
            tlbusuario user = new tlbusuario();
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                user = db.tlbusuarios.FirstOrDefault(b => b.usuario == usuario && b.contraseña == password);
            }
            if (user == null)
            {
                respuesta = false;
            }
            return respuesta;
        }
    }
}
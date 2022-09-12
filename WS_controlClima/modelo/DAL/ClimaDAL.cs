using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_controlClima.modelo
{
    public class ClimaDAL
    {
        public static string addClima(tblclima model)
        {
            string resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
               
           
;                db.AddTotblclimas(model);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    resultado = ex.Message;
                }
                }
                return resultado;
            
        }

        public static string updateClima(tblclima model)
        {
            string resultado;
            resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                var qry = from b in db.tblclimas
                          where b.ideclima == model.ideclima
                          select b;
                foreach (tblclima b in qry)
                {
                    b.idezona = model.idezona;
                    b.fechayhora = model.fechayhora;
                    b.temperatura = model.temperatura;
                    b.presipitacion = model.presipitacion;
                    b.viento = model.viento;
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
        public static string deleteClima(int ideclima)
        {
            string resultado;
            resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                tblclima clima = new tblclima();
                clima = db.tblclimas.FirstOrDefault(b => b.ideclima == ideclima);
                try
                {
                    if (clima != null)
                    {
                        db.DeleteObject(clima);
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

        public static List<tblclima> getClimas()
        {
            List<tblclima> climaList = new List<tblclima>();
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                var qry = from b in db.tblclimas
                          select b;
                foreach (tblclima b in qry)
                {
                    tblclima clma = new tblclima();
                    clma = b;
                    climaList.Add(clma);
                }
            }

            return climaList;
        }
        public static List<tblclima> getClimabyzon(int idezona)
        {
            List<tblclima> climaList = new List<tblclima>();
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                var qry = from b in db.tblclimas
                          where b.idezona == idezona
                          select b;
                foreach (tblclima b in qry)
                {
                    tblclima clma = new tblclima();
                    clma = b;
                    climaList.Add(clma);
                }
            }

            return climaList;    
        }
        public static List<tblclima> watchClima(int idezona, DateTime fechayhora)
        {
            List<tblclima> climaList = new List<tblclima>();
            tblclima clima = new tblclima();
        using(DBClimaEntities1 db = new DBClimaEntities1())
        {
          var qry = from b in db.tblclimas
                    where b.idezona==idezona && b.fechayhora <=fechayhora
                    orderby b.fechayhora descending
                    select b;
                    clima = qry.FirstOrDefault();
            
                    climaList.Add(clima);
        }
        return climaList;
        }
    }
}
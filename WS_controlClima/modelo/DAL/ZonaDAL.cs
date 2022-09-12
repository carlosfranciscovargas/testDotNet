using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WS_controlClima.modelo
{
    public class ZonaDAL
    {
        
       
        public static string Addzona(tblzona model)
        {
            string resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                db.AddTotblzonas(model);
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

        public static string Updatezona(tblzona model)
        {
            string resultado;
            resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                var qry = from b in db.tblzonas
                          where b.idezona == model.idezona
                          select b;
                foreach (tblzona b in qry)
                {
                    b.zona = model.zona;
                  
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
        public static string Deletezona(int idezona)
        {
            string resultado;
            resultado = "";
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
               
               
               

                tblzona zona = new tblzona();
                zona = db.tblzonas.FirstOrDefault(b => b.idezona == idezona);
                try
                {
                    if (zona != null)
                    {
                        var qry = from b in db.tblclimas
                                  where b.idezona == idezona
                                  select b;
                        foreach (tblclima b in qry)
                        {
                            tblclima clima = new tblclima(); ;
                            clima = b;
                            db.DeleteObject(clima);
                         //   db.SaveChanges();
                        }
                        db.DeleteObject(zona);
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

        public static List<tblzona> getZonas()
        {
            List<tblzona> zonaList = new List<tblzona>();
            using (DBClimaEntities1 db = new DBClimaEntities1())
            {
                var qry = from b in db.tblzonas
                          select b;
                foreach (tblzona b in qry)
                {
                    tblzona us = new tblzona();
                    us = b;
                    zonaList.Add(us);
                }
            }

            return zonaList;
        }
    }
}
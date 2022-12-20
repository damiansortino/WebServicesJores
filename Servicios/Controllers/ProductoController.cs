using Servicios.Clases;
using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servicios.Controllers
{
    public class ProductoController : ApiController
    {
        public List<prod> Get()
        {
            List<prod> listado = new List<prod>();
            using (baselaymarEntities db = new baselaymarEntities())
            {
                foreach (var item in db.producto)
                {
                    if (item.fechaBaja == null)
                    {
                        prod nuevoprod = new prod(item);
                        listado.Add(nuevoprod);
                    }
                }
            }
            return listado;
        }

        // GET: api/producto/5
        public prod Get(int id)
        {
            prod devolver = new prod();
                      
            using (baselaymarEntities db = new baselaymarEntities())
            {
                
                foreach (var item in db.producto)
                {
                    if ((item.fechaBaja == null) && (item.codigo.Contains(id.ToString().Trim())))
                    {
                        prod nuevo = new prod(item);
                        devolver = nuevo;
                    }
                }
            }
            return devolver;
        }
    }
}
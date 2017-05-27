using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//agregar referecnia a entidades y repositorio
using Dominio.Entidades;
using Dominio.Repositorio;

namespace Practicar_Examen_02.Controllers
{
    public class NegociosController : Controller
    {
        //instanciar la clase del repositorio
        cliente_BL cliente = new cliente_BL();

        /**LISTADO****************/
        // GET: Negocios
        public ActionResult Index()
        {
            //enviar listado de clientes
            return View(cliente.listado());
        }

        /**AGREGAR *****************************/
        
        //defino al accion y envio el registro de clientes
        public ActionResult Create() {
            return View(new tb_Clientes());
        }
        
        //recibo los datos y procesar
        [HttpPost]
        public ActionResult Create(tb_Clientes reg) {
            return RedirectToAction("Index");
        }
           




    }
}
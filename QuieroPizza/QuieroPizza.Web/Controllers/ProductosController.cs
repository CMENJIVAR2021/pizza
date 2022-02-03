using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel ();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza de 6 Quesos";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza de 4 Estaciones";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza de Hawayana";

            var producto4 = new ProductoModel();
            producto4.Id = 4;
            producto4.Descripcion = "Pizza de Jamon";

            var listaProductos = new List<ProductoModel>();
            listaProductos.Add(producto1);
            listaProductos.Add(producto2);
            listaProductos.Add(producto3);
            listaProductos.Add(producto4);

            return View(listaProductos);
        }
    }
}
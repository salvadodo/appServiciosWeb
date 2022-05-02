using Newtonsoft.Json;
using serviciosWebDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace consumirWebService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //servicioAsmx.servicioAsmxDueñosSoapClient cliente=new servicioAsmx.servicioAsmxDueñosSoapClient();
            servicioCasasAsmx.servicioAsmxCasasSoapClient cliente=new servicioCasasAsmx.servicioAsmxCasasSoapClient();
            List<Casas> listaCasas = new List<Casas>();
            foreach(var casa in cliente.registrosCasas())
            {
                listaCasas.Add(new Casas()
                {
                    idCasa = casa.idCasa,
                    tipodeCasa = casa.tipodeCasa,
                    Ubicacion = casa.Ubicacion,
                    Descripcion = casa.Descripcion,
                    Dueño = casa.Dueño
                });
            }
            //var listaCasas1 = JsonConvert.DeserializeObject<List<Casas>>();

            return View(listaCasas);
        }

        public ActionResult About()
        {
            HttpClient Cliente = new HttpClient();
            Cliente.BaseAddress = new Uri("https://localhost:44371/");
            var request = Cliente.GetAsync("api/Casas").Result;
            if (request.IsSuccessStatusCode)
            {
                var respuesta = request.Content.ReadAsStringAsync().Result;
                var listaCasas = JsonConvert.DeserializeObject<List<Casas>>(respuesta);
                return View(listaCasas);
            }
            return View(new List<Casas>());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            servicioCasasWcf.IservicioWcfCasasClient clientWcf = new servicioCasasWcf.IservicioWcfCasasClient();
            List<Casas> listaCasasWcf = new List<Casas>();
            foreach(var casa in clientWcf.registrosCasas())
            {
                listaCasasWcf.Add(new Casas()
                {
                    idCasa = casa.idCasa,
                    tipodeCasa = casa.tipodeCasa,
                    Ubicacion = casa.Ubicacion,
                    Descripcion = casa.Descripcion,
                    Dueño = casa.Dueño
                });
            }
            return View(listaCasasWcf);
        }
    }
}
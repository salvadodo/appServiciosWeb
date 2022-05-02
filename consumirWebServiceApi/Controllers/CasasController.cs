using Newtonsoft.Json;
using servicioWebNegocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Web;
using System.Web.Mvc;

namespace consumirWebServiceApi.Controllers
{
    public class CasasController : Controller
    {
        // GET: Casas
        [HttpGet]
        public ActionResult Index()
        {
            using(HttpClient Cliente = new HttpClient())
            {
                Cliente.BaseAddress = new Uri("https://localhost:44371/");
                var request = Cliente.GetAsync("api/Casas").Result;
                if (request.IsSuccessStatusCode)
                {
                    var respuesta = request.Content.ReadAsStringAsync().Result;
                    var listadoCasas = JsonConvert.DeserializeObject<List<Casas>>(respuesta);
                    return View(listadoCasas);
                }
                //Si la petición es incorrecta regresa la vista con una lista de casas vacía
                return View(new List<Casas>());
            }
        }
        [HttpGet]
        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(Casas insertarCasa)
        {
            using(HttpClient Cliente=new HttpClient())
            {
                Cliente.BaseAddress = new Uri("https://localhost:44371/");
                var casaSerializada = System.Text.Json.JsonSerializer.Serialize<Casas>(insertarCasa);
                //var casaSerializada = JsonConvert.SerializeObject(insertarCasa);
                //HttpContent es una clase abstracta que no se puede instanciar y se le asigna valor a traves de una clase no abstracta que hereda de HttpContent
                HttpContent content = new StringContent(casaSerializada, Encoding.UTF8, "application/json");
                var request = Cliente.PostAsync("api/Casas", content).Result;
                //PostAsJsonAsync se encuentra en el espacio de nombre System.Net.Http.Json y envia el uri y el objeto en formato json
                //var request = Client.PostAsJsonAsync("https://localhost:44371/", insertarCasa);
                if (request.IsSuccessStatusCode)
                {
                    var respuesta = request.Content.ReadAsStringAsync().Result;
                    var resBool = JsonConvert.DeserializeObject<bool>(respuesta);
                    if (resBool)
                    {
                        return RedirectToAction("Index");
                    }
                    return View(insertarCasa);
                }
                //Si la petición es incorrecta regresa la vista con los datos de la casa para corregirlos
                return View(insertarCasa);
            }
        } 
        [HttpGet]
        public ActionResult Actualizar(int id)
        {
            using(HttpClient Cliente=new HttpClient())
            {
                Cliente.BaseAddress = new Uri("https://localhost:44371/");
                //var request = Cliente.GetAsync("api/Casas/{id}").Result;
                var request = Cliente.GetAsync("api/Casas/" + id).Result;
                //var request = Cliente.GetAsync("api/Casas?id="+id+"&nombre="+nombre).Result;
                if (request.IsSuccessStatusCode)
                {
                    var respuesta = request.Content.ReadAsStringAsync().Result;
                    var casaSeleccionada= JsonConvert.DeserializeObject<Casas>(respuesta);
                    return View(casaSeleccionada);
                }
            }
            return View();
        }
        [HttpPut]
        public ActionResult Actualizar(Casas actualizarCasa)
        {
            using(HttpClient Cliente = new HttpClient())
            {
                Cliente.BaseAddress = new Uri("https://localhost:44371/");
                var casaSerializada=System.Text.Json.JsonSerializer.Serialize<Casas>(actualizarCasa);
                //var casaSerializada = JsonConvert.SerializeObject(insertarCasa);
                HttpContent content = new StringContent(casaSerializada, Encoding.UTF8, "application/json");
                var request = Cliente.PutAsync("api/Casas/{modCasa}", content).Result;
                if (request.IsSuccessStatusCode)
                {
                    var respuesta = request.Content.ReadAsStringAsync().Result;
                    var resBool = JsonConvert.DeserializeObject<bool>(respuesta);
                    if (resBool)
                    {
                        return RedirectToAction("Index");
                    }
                    return View(actualizarCasa);
                }
                return View(actualizarCasa);
            }
        }
        [HttpGet]
        public ActionResult Eliminar(int id)
        {
            using(HttpClient Cliente = new HttpClient())
            {
                Cliente.BaseAddress = new Uri("https://localhost:44371/");
                var request = Cliente.DeleteAsync("api/Casas?eliCasa="+id).Result;
                if (request.IsSuccessStatusCode)
                {
                    var respuesta = request.Content.ReadAsStringAsync().Result;
                    var resBool = JsonConvert.DeserializeObject<bool>(respuesta);
                    if (resBool)
                    {
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
        }
        [HttpGet]
        public ActionResult Detalle(int id)
        {
            using (HttpClient Cliente = new HttpClient())
            {
                Cliente.BaseAddress = new Uri("https://localhost:44371/");
                //var request = Cliente.GetAsync("api/Casas/{id}").Result;
                var request = Cliente.GetAsync("api/Casas/" + id).Result;
                //var request = Cliente.GetAsync("api/Casas?id="+id+"&nombre="+nombre).Result;
                if (request.IsSuccessStatusCode)
                {
                    var respuesta = request.Content.ReadAsStringAsync().Result;
                    var casaSeleccionada = JsonConvert.DeserializeObject<Casas>(respuesta);
                    return View(casaSeleccionada);
                }
            }
            return View();
        }
    }
}
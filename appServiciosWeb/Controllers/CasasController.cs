using serviciosWebDatos.Data;
using serviciosWebDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace appServiciosWeb.Controllers
{
    public class CasasController : ApiController
    {
        // GET: api/Casas
        [HttpGet]
        [Route ("api/Casas")]
        public List<Casas> Get()
        {
            return miCasaData.registrosCasas();
        }

        // GET: api/Casas/5
        [HttpGet]
        [Route ("api/Casas/{id}")]
        public Casas Get(int id)
        {
            return miCasaData.selectCasa(id);
        }

        // POST: api/Casas
        [HttpPost]
        [Route ("api/Casas")]
        public bool Post([FromBody] Casas insCasa)
        {
            return miCasaData.insertarCasa(insCasa);
        }

        // PUT: api/Casas/5
        [HttpPut]
        [Route ("api/Casas/{modCasa}")]
        public bool Put([FromBody] Casas modCasas)
        {
            return miCasaData.modificarCasas(modCasas);
        }

        // DELETE: api/Casas/5
        [HttpDelete]
        [Route ("api/Casas/{eliCasa}")]
        public bool Delete(int eliCasa)
        {
            return miCasaData.eliminarCasa(eliCasa);
        }
    }
}

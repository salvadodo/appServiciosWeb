using serviciosWebDatos.Data;
using serviciosWebDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace appServicioWebAsmx
{
    /// <summary>
    /// Descripción breve de servicioAsmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class servicioAsmx : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Casas> registrosCasas()
        {
            return miCasaData.registrosCasas();
        }
        [WebMethod]
        public Casas seleccionarCasa(int id)
        {
            return miCasaData.selectCasa(id);
        }

        [WebMethod]
        public bool insertarCasa(Casas insCasa)
        {
            return miCasaData.insertarCasa(insCasa);
        }

        [WebMethod]
        public bool ModificarCasa(Casas modCasas)
        {
            return miCasaData.modificarCasas(modCasas);
        }

        [WebMethod]
        public bool eliminarCasa(int eliCasa)
        {
            return miCasaData.eliminarCasa(eliCasa);
        }
    }
}

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
    /// Descripción breve de servicioAsmxDueños
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class servicioAsmxDueños : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Dueños> registrosDueños()
        {
            return miDueñosData.registrosDueños();
        }
        [WebMethod]
        public Dueños seleccionarDueño(int id)
        {
            return miDueñosData.selectDueño(id);
        }

        [WebMethod]
        public bool insertarDueño(Dueños insDueño)
        {
            return miDueñosData.insertarDueño(insDueño);
        }

        [WebMethod]
        public bool ModificarDueño(Dueños modDueño)
        {
            return miDueñosData.modificarDueño(modDueño);
        }

        [WebMethod]
        public bool eliminarDueño(int eliDueño)
        {
            return miDueñosData.eliminarDueño(eliDueño);
        }
    }
}

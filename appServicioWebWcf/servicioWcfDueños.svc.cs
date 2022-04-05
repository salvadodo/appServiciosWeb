using serviciosWebDatos.Data;
using serviciosWebDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace appServicioWebWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "servicioWcfDueños" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione servicioWcfDueños.svc o servicioWcfDueños.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class servicioWcfDueños : IservicioWcfDueños
    {
        public List<Dueños> registrosDueños()
        {
            return miDueñosData.registrosDueños();
        }
        public Dueños seleccionarDueño(int id)
        {
            return miDueñosData.selectDueño(id);
        }
        public bool insertarDueño(Dueños insDueño)
        {
            return miDueñosData.insertarDueño(insDueño);
        }
        public bool modificarDueño(Dueños modDueño)
        {
            return miDueñosData.modificarDueño(modDueño);
        }
        public bool eliminarDueño(int eliDueño)
        {
            return miDueñosData.eliminarDueño(eliDueño);
        }
    }
}

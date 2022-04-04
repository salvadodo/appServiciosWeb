using serviciosWebDatos.Data;
using serviciosWebDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace appServicioWebWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class servicioWcf : IservicioWcf
    {
        public List<Casas> registrosCasas()
        {
            return miCasaData.registrosCasas();
        }
        public Casas seleccionarCasa(int id)
        {
            return miCasaData.selectCasa(id);
        }
        public bool insertarCasa(Casas insCasa)
        {
            return miCasaData.insertarCasa(insCasa);
        }
        public bool modificarCasa(Casas modCasas)
        {
            return miCasaData.modificarCasas(modCasas);
        }
        public bool eliminarCasa(int eliCasa)
        {
            return miCasaData.eliminarCasa(eliCasa);
        }
    }
}

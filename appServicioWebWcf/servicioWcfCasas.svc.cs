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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "servicioWcfCasas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione servicioWcfCasas.svc o servicioWcfCasas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class servicioWcfCasas : IservicioWcfCasas
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

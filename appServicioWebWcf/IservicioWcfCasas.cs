using serviciosWebDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace appServicioWebWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IservicioWcfCasas" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IservicioWcfCasas
    {
        [OperationContract]
        List<Casas> registrosCasas();
        [OperationContract]
        Casas seleccionarCasa(int id);
        [OperationContract]
        bool insertarCasa(Casas insCasa);
        [OperationContract]
        bool modificarCasa(Casas modCasas);
        [OperationContract]
        bool eliminarCasa(int eliCasa);
    }
}

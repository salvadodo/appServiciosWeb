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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IservicioWcf
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

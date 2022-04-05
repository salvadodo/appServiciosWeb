using serviciosWebDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace appServicioWebWcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IservicioWcfDueños" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IservicioWcfDueños
    {
        [OperationContract]
        List<Dueños> registrosDueños();
        [OperationContract]
        Dueños seleccionarDueño(int id);
        [OperationContract]
        bool insertarDueño(Dueños insDueño);
        [OperationContract]
        bool modificarDueño(Dueños modDueño);
        [OperationContract]
        bool eliminarDueño(int eliDueño);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HuecasAppAdmin.Conexiones;
using HuecasAppAdmin.Modelo;
using Firebase.Database.Query;
namespace HuecasAppAdmin.Datos
{
    public class RecolectoresD
    {
        public async Task<bool> InsertarRecolectores(RecolectoresM parametros)
        {
            await Constantes.firebase.Child("Recolectores").PostAsync(new RecolectoresM()
            {
                Correo=parametros.Correo,
                Estado= parametros.Estado,
                Identificacion= parametros.Identificacion,
                Nombre= parametros.Nombre
            });
            return true;
        }
    }
}

using HuecasAppAdmin.Datos;
using HuecasAppAdmin.Modelo;
using HuecasAppAdmin.Vistas.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using HuecasAppAdmin.Conexiones;
using Firebase.Auth;
using Firebase.Auth.Providers;

namespace HuecasAppAdmin.VistasModelo
{
    public class RecolectoresConfigVM : BaseVM
    {
        #region Constructor
        public RecolectoresConfigVM(INavigation navegacion)
        {
            Navigation = navegacion;
            //NavMenuConfigComand = new Command(async () => await NavMenuConfigProces());

        }
        #endregion
        #region Variables
        //las variables las vamos a omenzar con un guion bajo por nomenclaura _
        public string _txtNombre;
        public string _txtCorreo;
        public string _txtIdentificacion;



        //todo lo q creemos va a tener q ser atravez de varables y luego de objetos
        #endregion
        #region Objetos

        public string TxtNombre { get { return _txtNombre; } set { SetValue(ref _txtNombre, value); } }
        public string TxtCorreo { get { return _txtCorreo; } set { SetValue(ref _txtCorreo, value); } }
        public string TxtIdentificacion{ get { return _txtIdentificacion; } set { SetValue(ref _txtIdentificacion, value); } }
        

        #endregion
        #region Procesos
        //pueden ser sincronos y no asincronos
        public async Task InsertarRecolecoresProces()
        {
            var funcion = new RecolectoresD();
            var parametros = new RecolectoresM();
            parametros.Nombre = TxtNombre;
            parametros.Identificacion = TxtIdentificacion;
            parametros.Correo = TxtCorreo;
            parametros.Estado = "Activo";
            var estadoFuncion =await funcion.InsertarRecolectores(parametros);
            if (estadoFuncion==true)
            {
                await DisplayAlert("Estado", "Registro realizado", "ok");
            } 
        }
        /*public async Task CrearCorreo(string correo, string contraseña)
        {
            
                var authProvider = new FirebaseAuthProvider();//new FirebaseConfig(Constantes.WebApyFirebase))
        }*/

      

        public async Task VolverProces()
        {
            await Navigation.PopAsync();
        }

        #endregion
        #region Comandos

        //Trabajaremos con codigo a traves de codigo y luego lo enlazamos con el binding al MainPage
        //los procesos landa => se refiere a que hay q otrogarle una determinada funcion
        public ICommand InsertarRecolecoresComand => new Command(async () => await InsertarRecolecoresProces());
        //public ICommand ProcesoSimpleComand => new Command(ProcesoSimple);
        public ICommand VolverAsyncComand => new Command(async () => await VolverProces());

        
        #endregion
    }
}

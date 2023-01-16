using HuecasAppAdmin.Vistas;
using HuecasAppAdmin.Vistas.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HuecasAppAdmin.VistasModelo
{
    internal class MenuConfigVM : BaseVM
    {
        #region Constructor
        public MenuConfigVM(INavigation navegacion)
        {
            Navigation = navegacion;
            //NavMenuConfigComand = new Command(async () => await NavMenuConfigProces());

        }
        #endregion
        #region Variables
        //las variables las vamos a omenzar con un guion bajo por nomenclaura _
        //public string _Nombre;



        //todo lo q creemos va a tener q ser atravez de varables y luego de objetos
        #endregion
        #region Objetos

        /*public string Nombre { get { return _Nombre; } set { SetValue(ref _Nombre, value); } }
        public string Apellido { get { return _Apellido; } set { SetValue(ref _Apellido, value); } }
        public string Edad { get { return _Edad; } set { SetValue(ref _Edad, value); } }
        public string Email { get { return _Email; } set { SetValue(ref _Email, value); } }
        public string listaUser { get { return _listaUser; } set { SetValue(ref _listaUser, value); } }*/

        #endregion
        #region Procesos
        //pueden ser sincronos y no asincronos
        public async Task VolverProces()
        {
            await Navigation.PopAsync();
        }
        public async Task NavRecolecProces()
        {
            await Navigation.PushAsync(new RecolectoresConfig());
        }


        #endregion
        #region Comandos

        //Trabajaremos con codigo a traves de codigo y luego lo enlazamos con el binding al MainPage
        //los procesos landa => se refiere a que hay q otrogarle una determinada funcion
        public ICommand VolverAsyncComand => new Command(async () => await VolverProces());
        public ICommand PagRecoleComand => new Command(async () => await NavRecolecProces());
        //public ICommand ProcesoSimpleComand => new Command(ProcesoSimple);
        #endregion
    }
}

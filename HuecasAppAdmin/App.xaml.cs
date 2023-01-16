using HuecasAppAdmin.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HuecasAppAdmin
{
    using HuecasAppAdmin.VistasModelo;
    using Vistas;
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new MenPrincipalV());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

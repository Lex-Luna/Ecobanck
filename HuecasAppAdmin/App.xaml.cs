using HuecasAppAdmin.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HuecasAppAdmin
{
    using Vistas.Config;
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new MenuConfig();
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

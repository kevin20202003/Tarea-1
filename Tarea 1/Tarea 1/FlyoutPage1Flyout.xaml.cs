using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyoutPage1Flyout : ContentPage
    {
        public ListView ListView;

        public FlyoutPage1Flyout()
        {
            InitializeComponent();
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var parent = (FlyoutPage1)Parent;
            parent.Detail = new NavigationPage(new Vistas.Inicio());
            parent.IsPresented = false;
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            var parent = (FlyoutPage1)Parent;
            parent.Detail = new NavigationPage(new Vistas.Vermas());
            parent.IsPresented = false;
        }


    }
}
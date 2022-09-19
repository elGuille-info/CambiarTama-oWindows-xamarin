using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace CambiarTamañoWindows.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Instanciamos la clase para que pueda asignar los valores.
            var laApp = new CambiarTamañoWindows.App();
            LoadApplication(laApp);

            // Asignar manualmente el tamaño según esté definido en la App del proyecto con la funcionalidad.
            double winWidth = laApp.WindowsWidth;
            double winHeight = laApp.WindowsHeight;

            ApplicationView.PreferredLaunchViewSize = new Size(winWidth, winHeight);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

        }
    }
}

/*
            LoadApplication(new CambiarTamañoWindows.App());

            // Asignar manualmente el tamaño según esté definido en la App del proyecto con la funcionalidad.
            double winWidth = CambiarTamañoWindows.App.WindowsWidth;
            double winHeight = CambiarTamañoWindows.App.WindowsHeight;

            ApplicationView.PreferredLaunchViewSize = new Size(winWidth, winHeight);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

*/

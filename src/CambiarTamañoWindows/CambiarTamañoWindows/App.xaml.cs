using System;
using CambiarTamañoWindows.Services;
using CambiarTamañoWindows.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CambiarTamañoWindows;

public partial class App : Application
{

    public App()
    {
        InitializeComponent();

        DependencyService.Register<MockDataStore>();
        MainPage = new AppShell();
    }

    public double WindowsWidth { get; } = 650;
    public double WindowsHeight { get; } = 700;

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

/*
    public static double WindowsWidth { get; } = 1200;
    public static double WindowsHeight { get; } = 900;

*/
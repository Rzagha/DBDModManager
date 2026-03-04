using System.Configuration;
using System.Data;
using System.Windows;
using System;

namespace DbdModManager;

public partial class App : System.Windows.Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
    }

    private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
        System.Windows.MessageBox.Show($"UI Error: {e.Exception.Message}\n\n{e.Exception.StackTrace}", "V9 Fatal Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
        e.Handled = true;
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e) => System.Windows.Application.Current.Shutdown();

    private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        Exception ex = (Exception)e.ExceptionObject;
        System.Windows.MessageBox.Show($"Core Error: {ex.Message}\n\n{ex.StackTrace}", "V9 System Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
    }
}

using System.Configuration;
using System.Data;
using System.Windows;

namespace PortoApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
}

private void KlickRäkna (object sender, RoutedEventArgs e)
{
    if (vikt <= 50)
    {
        return $"Brev som väger {vikt} g kostar 22 kr (1 frimärke)";
    }
}
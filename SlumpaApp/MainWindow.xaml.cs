using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

   if (!int.TryParse(txbMax.Text, out int Max))
   {
        txbMax.Text = "Fel på inmatning, ange ett tal";

        Max = 100;
   }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {
        // Läsa av maxvärde
        //int Max = int.Parse(txbMax.Text) + 1;

        // Läsa av utan risk för krasch!


        // Slumpa ett tal 1-100
        int slumptal = Random.Shared.Next(1, Max + 1);

        // Skriv ut slumptalet i textboxen
        txbResultat.Text = $"{slumptal}";
    }

}
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

namespace GissaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    // Slumpa fram ett tal 1-1000
    int slumptal = Random.Shared.Next(1,1000);
    List<int> listaGissningar = [];

private void KlickGissa(object sender, RoutedEventArgs e)
{
    // Läs av ruta gissning
    string input = txbGissning.Text;

    // Konvertera till ett heltal
   bool lyckades = int.TryParse(input, out int gissning);

   // Lyckades konverteringen?
   if (lyckades)
   {
    // Lagra i listan
    listaGissningar.Add(gissning);

    // Jämföra gissning med slumptal
    if (gissning == slumptal)
    {
        txbResultat.Text = $"Du gissade rätt!";
    }
    else if(gissning > slumptal)
    {
        txbResultat.Text = $"{gissning} är för högt";
    }
    else if(gissning < slumptal)
    {
        txbResultat.Text = $"{gissning} är för lågt";
    }
   }
   else
   {
       txbResultat.Text = $"Ogiltig inmatning. Var god försök igen";
   }
}

private void KlickVisaFacit(object sender, RoutedEventArgs e)
{
    txbResultat.Text = $"Rätt svar är {slumptal}";
}

private void KlickVisaGissningar(object sender, RoutedEventArgs e)
{
    // Skriv ut alla gissningar som finns i listan
    // I gissningar txbGissningar
    foreach (var tal in listaGissningar)
    {

    txbGissning.Text += $"{tal}\n";
     
    }
}

private KlickaSpelaIgen (object sender, RoutedEventArgs e)
{
    txbGissning.Text = "";
    txbResultat.Text = "";
    txbGissningar.Text = "";
}
}
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

namespace AritmetikRäknare;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
}

private void KlickBeräkna(object sender, RoutedEventArgs e)
{
    
// Läs in tal 1 och 2 från text
    string tal1Text = tbxTal1.Text.Trim();
    string tal2Text = tbxTal2.Text.Trim();

// Läs in operatorn
    string OP = OPtbx.Text.Trim();

    if (double.TryParse(tal1Text, out double tal1) && double.TryParse(tal2Text, out double tal2))
    {
    double resultat; 
    }

    if (OP == "+")
    {
        resultat = tal1 + tal2
        lblResultat.Content = $"{tal1} + {tal2} = {resultat}";
    }
    else if (OP == "-")
    {
        resultat = tal1 - tal2
        lblResultat.Content = $"{tal1} - {tal2} = {resultat}";
    }
    else if (OP == "*")
    {
        resultat = tal1 * tal2
        lblResultat.Content = $"{tal1} * {tal2} = {resultat}";
    }
    else if (OP == "/")
    {
        if (tal2 != 0)
        {
        resultat = tal1 / tal2
        lblResultat.Content = $"{tal1} / {tal2} = {resultat}";
        }
        else
        {
        lblResultat.Content = "Fel: kan ej dividera med 0"
        }
        else
        {
        lblResultat.Content = "Fel: ogiltig operator."
        }
        else
        {
            lblResultat.Content = "Fel: ogiltigt tal."
        }
    }
}
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

namespace IndexApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        //Läs av texten
        string text = tbxText.Text;
        string IDX = tbxIndex.Text;

        // Omvandla index till heltal
        int.TryParse(IDX, out int index);

        // Plocka fram initialen
        char initial = text[index];

        // Skriv ut initialen(x)
        tbxResultat.Text = $"Bokstaven är {initial}.";
    }
}
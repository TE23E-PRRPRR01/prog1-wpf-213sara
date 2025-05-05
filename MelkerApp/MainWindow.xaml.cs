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

namespace MelkerApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickJämför(object sender, RoutedEventArgs e)
    {
        // Läs av rutorna
        string tal01 = tbxTal2.Text;
        string tal02 = tbxTal2.Text;

        // Omvandla till heltal
        int.TryParse(tal1, out int tal01);
        int.TryParse(tal2, out int tal02);

        if (tal01 > tal02)
        {
            tbxResultat.Text = $"Tal 1({tal01}) är större än Tal 2({tal02}).";
        }
        else if (tal02 > tal01)
        {
            tbxResultat.Text = $"Tal 2({tal02}) är större än Tal 1({tal01}).";
        }
        else (tal01 == tal02)
        {
            tbxResultat.Text = $"Tal 1({tal01}) och Tal 2({tal02}) är lika stora.";
        }
    
    }
}
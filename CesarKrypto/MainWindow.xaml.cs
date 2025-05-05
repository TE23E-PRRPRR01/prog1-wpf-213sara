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

namespace CesarKrypto;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickKryptera(object sender, RoutedEventArgs e)
    {
        // Läs av textrutorna txbInput & txbKey
        string inputText = txbInput.Text;
        string keyText = txbKey.Text;

        // Konvertera keyText till key(int)
        int.TryParse(keyText, out int key);

        // Gå igenom inputText bokstav-för-boxstav
        // Loopa bokstav-för-bokstav
        foreach (var bokstav in inputText)
        {
            // Hitta ASCII-värde
            int ascii = (int)bokstav;

            // Kryptera, dvs skifta framåt
            int asciiKrypterad = ascii + key;
            char bokstavKrypterad = (char)asciiKrypterad;


            // Skriv ut resultat
            // tbxOutput.Text = $"Du skrev: {inputText}";
            txbOutput.Text += $"{bokstavKrypterad}";
        }

        private void KlickRensa(object sender, RoutedEventArgs e)
        {
            txbInput.Text = "";
            txbKey.Text = "";
            tbxOutput.Text = ""; 
        }
    }
}
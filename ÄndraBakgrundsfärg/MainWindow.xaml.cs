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

namespace ÄndraBakgrundsfärg;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ClickCyan(object sender, RoutedEventArgs e)
    {
        // Ändra färg till cyan
        this.Background = Brushes.Cyan;
    }

     private void ClickLavender(object sender, RoutedEventArgs e)
    {
        // Ändra färg till Lavender
        this.Background = Brushes.Lavender;
    }
}
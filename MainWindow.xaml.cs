using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Zmiany> zmiany = new List<Zmiany>();
            zmiany.Add(new Zmiany() { imie = "Janusz", nazwisko = "Kowal", aktywny = false });
            zmiany.Add(new Zmiany() { imie = "Marian", aktywny = true });
            zmiany.Add(new Zmiany() { imie = "Agata", nazwisko = "Bigos", aktywny = false });
            excel.ItemsSource = zmiany;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OknoStartowe oknienko = new OknoStartowe();
            oknienko.Show();
            this.WindowState = WindowState.Minimized;
        }
    }

    public class Zmiany
    {
        public string imie { get; set; }

        public string nazwisko { get; set; }

        public bool aktywny { get; set; }
    }
}

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
using System.Windows.Shapes;

namespace wprowadzenie1
{
    /// <summary>
    /// Logika interakcji dla klasy ObliczeniaWindow.xaml
    /// </summary>
    public partial class ObliczeniaWindow : Window
    {
        public ObliczeniaWindow()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(liczba1.Text, out int a))
            {
                if(int.TryParse(liczba2.Text, out int b))
                {
                    int suma a + b;
                    MessageBox.Show(suma.ToString(), "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                //okno modalne ktore blokuje program do momentu klikniecia
                MessageBox.Show("Musi być wypełniony formularz","Uwaga",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
    }
}

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
    /// Logika interakcji dla klasy KwadratWindows.xaml
    /// </summary>
    public partial class KwadratWindows : Window
    {
        public KwadratWindows()
        {
            InitializeComponent();
        }

        private void Oblicz_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(liczba1.Text, out double a))
            {
                double pole = a * a;
                double obwod = 4 * a;
                komunikattextblock.Text = String.Empty;
                liczba2.Text = obwod.ToString();
                liczba3.Text = pole.ToString();
            }
            else
            {
                komunikattextblock.Text = "Wpisz dodatnią liczbę";
            }
        }
    }
}

using System;
using System.Collections.Generic;
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

namespace Excel_goes_Access
{
    /// <summary>
    /// Interaktionslogik für Datensatz_hinzufügen.xaml
    /// </summary>
    public partial class Datensatz_hinzufügen : Page
    {
        string schlagwort;
        string name;
        string vorname;
        string kurzwahl;
        string telefonnummer;
        string email;
        string sonstiges;
        string mobilnummern;

        public Datensatz_hinzufügen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            schlagwort = tb1.Text;
            name = tb2.Text;
            vorname = tb3.Text;
            kurzwahl = tb4.Text;
            telefonnummer = tb5.Text;
            email = tb6.Text;
            sonstiges = tb7.Text;
            mobilnummern = tb8.Text;

        }
    }
}

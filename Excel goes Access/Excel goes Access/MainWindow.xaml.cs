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
using System.Data;
using System.Data.OleDb;


namespace Excel_goes_Access
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OleDbConnection con;
        OleDbCommand cmd;

        public MainWindow()
        {
            InitializeComponent();
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:/Dokumente/HomeO/Excel_goes_Access/Excel_goes_Access.mdb";

            // Datenbankverbindung wird hergestellt
            con = new OleDbConnection(constr);
            con.Open();
            refreshDB();
        }

        public void refreshDB()
        {
            //Kommando wird angewendet
            string sql = "SELECT * FROM Artikel";
            cmd = new OleDbCommand(sql, con);
            cmd.ExecuteNonQuery();
            OleDbDataAdapter DA = new OleDbDataAdapter(cmd);

            //DataTable und damit die ListView wird mit Daten befüllt
            DataTable dt = new DataTable();
            DA.Fill(dt);

        }

         
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.RemoveBackEntry();
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            frame.Content = new Datensatz_suchen();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.RemoveBackEntry();
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            frame.Content = new Datensatz_ändern();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.RemoveBackEntry();
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            frame.Content = new Datensatz_hinzufügen();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            frame.NavigationService.RemoveBackEntry();
            frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            frame.Content = new Datensatz_löschen();
        }
    }
}

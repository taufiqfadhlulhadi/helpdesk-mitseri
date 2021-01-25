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
using System.Runtime.InteropServices;
//using MySql.Data.MySqlClient;

namespace Helpdesk_mitseri
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        connection_class conn = new connection_class();

        public MainWindow()
        {
            InitializeComponent();

            //MessageBox.Show("" + Helpdesk_mitseri.Properties.Settings.Default.ID.ToString("D40"));
        }

        ////connection fuction
        //private void connectDB()
        //{
        //    connection_string = "SERVER=103.247.9.148;PORT=3306;DATABASE=miti7412_testdatabase;UID=miti7412_tesuser;PWD=MxLS~639pgzu";
        //    try
        //    {
        //        connection = new MySqlConnection();
        //        connection.ConnectionString = connection_string;
        //        connection.Open();
        //        MessageBox.Show("Connection Open");
        //    }
        //    catch (MySql.Data.MySqlClient.MySqlException ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        private void LVmouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility when mouse hover

            if(Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_input.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_input.Visibility = Visibility.Visible;
            }
        }

        private void Tg_Btn_Unchecked(object sender, RoutedEventArgs e)
        {
            
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            input_form Input_Form = new input_form();
            Input_Form.ShowDialog();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void View_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            view_input viewInput = new view_input();
            viewInput.ShowDialog();
        }

        //private static void ExportQuery(string databaseLocation, string queryNameToExport, string locationToExportTo)
        //{
        //    var application = new Application();
        //    application.OpenCurrentDatabase(databaseLocation);
        //    application.DoCmd.TransferSpreadsheet(AcDataTransferType.acExport, AcSpreadSheetType.acSpreadsheetTypeExcel12, queryNameToExport, locationToExportTo, true);
        //    application.CloseCurrentDatabase();
        //    application.Quit();
        //    Marshal.ReleaseComObject(application);
        //}
    }
}

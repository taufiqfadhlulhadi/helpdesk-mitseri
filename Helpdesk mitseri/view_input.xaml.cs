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

namespace Helpdesk_mitseri
{
    /// <summary>
    /// Interaction logic for view_input.xaml
    /// </summary>
    public partial class view_input : Window
    {
        connection_class conn = new connection_class();
        variable_class variable = new variable_class();
        public view_input()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            string query = "SELECT * FROM [data]";
            try
            {
                conn.connect(System.AppDomain.CurrentDomain.BaseDirectory);
                conn.sql_reader(query);
                while (conn.read.Read())
                {
                    this.LView.Items.Add(new myitem { Tanggal_input = conn.read["tanggal"].ToString(), Time_create = conn.read["time create"].ToString(), CaseID = conn.read["caseID"].ToString(), Kategori_project = conn.read["category project"].ToString(), Perusahaan = conn.read["perusahaan"].ToString(), Project_name = conn.read["project name"].ToString(), Nama_user = conn.read["nama user"].ToString(), NoHP = conn.read["noHP/telp"].ToString(), Branch = conn.read["branch"].ToString(), Alamat = conn.read["alamat"].ToString(), Tipe = conn.read["type"].ToString(), SN_unit = conn.read["sn unit"].ToString(), Problem = conn.read["problem"].ToString(), Category_request = conn.read["category request"].ToString(), Case_closed = conn.read["tanggal case closed"].ToString(), Solusi = conn.read["solusi"].ToString(), Status_case = conn.read["status case"].ToString(), Keterangan = conn.read["keterangan"].ToString(), Vendor_number = conn.read["invoice vendor number"].ToString(), Engineer = conn.read["nama engineer"].ToString(), BAP = conn.read["bap"].ToString(), Biaya_jasa = conn.read["biaya jasa"].ToString(), Biaya_transportasi = conn.read["biaya transportasi"].ToString(), Biaya_ongkir = conn.read["biaya ongkir dokumen"].ToString(), Keterangan2 = conn.read["keterangan2"].ToString(), Rekening = conn.read["no rekening"].ToString(), Bank = conn.read["nama bank"].ToString(), Tanggal_request = conn.read["tanggal request"].ToString(), Transfer = conn.read["transfer"].ToString(), Status_transfer = conn.read["status transfer"].ToString(), Tanggal_transfer = conn.read["tanggal transfer"].ToString()});
                    //LV1 = LView.Items.Add(conn.read["id_pegawai"].ToString());
                    //LV1.SubItems.Add(db.db_read["nama"].ToString());
                    //LV1.SubItems.Add(db.db_read["jam_absen"].ToString());
                    //LV1.SubItems.Add(db.db_read["keterangan"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void LView_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //MessageBox.Show(LView.SelectedItem.ToString());


            var selectedObject = LView.SelectedItems[0] as myitem;

            if (selectedObject == null)
            {
                return;
            }
            //MessageBox.Show(selectedObject.Tanggal_input.ToString());
            variable.Tanggal_input = selectedObject.Tanggal_input.ToString();
            variable.Time_create = selectedObject.Time_create.ToString();
            variable.CaseID = selectedObject.CaseID.ToString();
            variable.Kategori_project = selectedObject.Kategori_project.ToString();
            variable.Perusahaan = selectedObject.Perusahaan.ToString();
            variable.Project_name = selectedObject.Project_name.ToString();
            variable.Nama_user = selectedObject.Nama_user.ToString();
            variable.NoHP = selectedObject.NoHP.ToString();
            variable.Branch = selectedObject.Branch.ToString();
            variable.Alamat = selectedObject.Alamat.ToString();
            variable.Type = selectedObject.Tipe.ToString();
            variable.SN_unit = selectedObject.SN_unit.ToString();
            variable.Problem = selectedObject.Problem.ToString();
            variable.Category_request = selectedObject.Category_request.ToString();
            variable.Case_closed = selectedObject.Case_closed.ToString();
            variable.Solusi = selectedObject.Solusi.ToString();
            variable.Status_case = selectedObject.Status_case.ToString();
            variable.Keterangan = selectedObject.Keterangan.ToString();
            variable.Vendor_number = selectedObject.Vendor_number.ToString();
            variable.Engineer = selectedObject.Engineer.ToString();
            variable.BAP = selectedObject.BAP.ToString();
            variable.Biaya_jasa = selectedObject.Biaya_jasa.ToString();
            variable.Biaya_transportasi = selectedObject.Biaya_transportasi.ToString();
            variable.Biaya_ongkir = selectedObject.Biaya_ongkir.ToString();
            variable.Keterangan2 = selectedObject.Keterangan2.ToString();
            variable.Rekening = selectedObject.Rekening.ToString();
            variable.Bank = selectedObject.Bank.ToString();
            variable.Tanggal_request = selectedObject.Tanggal_request.ToString();
            variable.Transfer = selectedObject.Transfer.ToString();
            variable.Status_transfer = selectedObject.Status_transfer.ToString();
            variable.Tanggal_transfer = selectedObject.Tanggal_transfer.ToString();

            edit_input edit = new edit_input();
            edit.ShowDialog();

            LView.Items.Clear();
            load_data();
        }

        //private void LView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    //var item = sender as ListViewItem;
        //    //if (item != null && item.IsSelected)
        //    //{
        //    //    MessageBox.Show(item.IsSelected.ToString());
        //    //}
        //}

        public class myitem
        {
            public string Tanggal_input { get; set; }

            public string Time_create { get; set; }

            public string CaseID { get; set; }

            public string Kategori_project { get; set; }

            public string Perusahaan { get; set; }

            public string Project_name { get; set; }

            public string Nama_user { get; set; }

            public string NoHP { get; set; }

            public string Branch { get; set; }

            public string Alamat { get; set; }
            
            public string Tipe { get; set; }

            public string SN_unit { get; set; }

            public string Problem { get; set; }            

            public string Category_request { get; set; }
            
            public string Case_closed { get; set; }

            public string Solusi { get; set; }

            public string Status_case { get; set; }

            public string Keterangan { get; set; }

            public string Vendor_number { get; set; }

            public string Engineer { get; set; }

            public string BAP { get; set; }

            public string Biaya_jasa { get; set; }

            public string Biaya_transportasi { get; set; }

            public string Biaya_ongkir { get; set; }

            public string Keterangan2 { get; set; }

            public string Rekening { get; set; }

            public string Bank { get; set; }

            public string Tanggal_request { get; set; }

            public string Transfer { get; set; }

            public string Status_transfer { get; set; }

            public string Tanggal_transfer { get; set; }
        }

        private void finish_click(object sender, RoutedEventArgs e)
        {

        }
    }
}

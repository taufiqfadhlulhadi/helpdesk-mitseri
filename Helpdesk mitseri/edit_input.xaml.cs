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
    /// Interaction logic for edit_input.xaml
    /// </summary>
    public partial class edit_input : Window
    {
        variable_class variable = new variable_class();
        connection_class conn = new connection_class();
        view_input.myitem myitem = new view_input.myitem();
        public edit_input()
        {
            InitializeComponent();
            load_data();
        }

        public void load_data()
        {
            tanggal_box.Text = variable.Tanggal_input.ToString();
            caseID_box.Text = variable.CaseID.ToString();
            categoryproject_box.Text = variable.Kategori_project.ToString();
            perusahaan_cbox.Text = variable.Perusahaan.ToString();
            project_box.Text = variable.Project_name.ToString();
            namauser_box.Text = variable.Nama_user.ToString();
            nohp_box.Text = variable.NoHP.ToString();
            branch_box.Text = variable.Branch.ToString();
            alamat_box.Text = variable.Alamat.ToString();
            type_cbox.Text = variable.Type.ToString();
            sn_box.Text = variable.SN_unit.ToString();
            problem_box.Text = variable.Problem.ToString();
            problemrequest_cbox.Text = variable.Category_request.ToString();
            caseclosed_dpicker.Text = variable.Case_closed.ToString();
            solusi_box.Text = variable.Solusi.ToString();
            statuscase_box.Text = variable.Status_case.ToString();
            ket_box.Text = variable.Keterangan.ToString();
            vendor_number.Text = variable.Vendor_number.ToString();
            engineer_box.Text = variable.Engineer.ToString();
            bap_cbox.Text = variable.BAP.ToString();
            biayajasa_box.Text = variable.Biaya_jasa.ToString();
            biayatransportasi_box.Text = variable.Biaya_transportasi.ToString();
            biayaongkir_box.Text = variable.Biaya_ongkir.ToString();
            keterangan2_box.Text = variable.Keterangan2.ToString();
            rekening_box.Text = variable.Rekening.ToString();
            bank_box.Text = variable.Bank.ToString();
            request_dpick.Text = variable.Tanggal_request.ToString();
            transfer_box.Text = variable.Transfer.ToString();
            statustransfer_box.Text = variable.Status_transfer.ToString();
            tanggaltransfer_dpick.Text = variable.Tanggal_transfer.ToString();
        }

        private void finish_click(object sender, RoutedEventArgs e)
        {
            string query = "";
            if (categoryproject_box.Text != "" &&
                perusahaan_cbox.Text != "" &&
                project_box.Text != "" &&
                namauser_box.Text != "" &&
                nohp_box.Text != "" &&
                branch_box.Text != "" &&
                alamat_box.Text != "" &&
                type_cbox.Text != "" &&
                sn_box.Text != "" &&
                problem_box.Text != "" &&
                problemrequest_cbox.Text != "" &&
                //caseclosed_dpicker.Text != "" &&
                solusi_box.Text != "" &&
                statuscase_box.Text != "" &&
                ket_box.Text != "" &&
                vendor_number.Text != "" &&
                engineer_box.Text != "" &&
                bap_cbox.Text != "" &&
                biayajasa_box.Text != "" &&
                biayatransportasi_box.Text != "" &&
                biayaongkir_box.Text != "" &&
                keterangan2_box.Text != "" &&
                rekening_box.Text != "" &&
                bank_box.Text != "" &&
                //request_dpick.Text != "" &&
                transfer_box.Text != "" &&
                statustransfer_box.Text != "")
            {
                //query = "UPDATE [data] SET ('tanggal = " + tanggal_box.Text + "', 'caseID = " + caseID_box.Text + "', 'category project = " + categoryproject_box.Text + "', 'perusahaan = " +
                //                                        perusahaan_cbox.Text + "', 'project name = " + project_box.Text + "', 'nama user = " + namauser_box.Text + "', 'noHP/telp = " + nohp_box.Text + "', 'branch = " + branch_box.Text + "', 'alamat = " + alamat_box.Text + "', 'type = " + type_cbox.Text + "', 'sn unit = " + sn_box.Text + "', 'problem = " + problem_box.Text + "', 'category request = " + problemrequest_cbox.Text + "', 'tanggal case closed = " + caseclosed_dpicker.Text + "', 'solusi = " + solusi_box.Text + "', 'status case = " + statuscase_box.Text + "', 'keterangan = " + ket_box.Text + "', 'invoice vendor number = " + vendor_number.Text + "', 'nama engineer = " + engineer_box.Text + "', 'bap = " + bap_cbox.Text + "', 'biaya jasa = " + biayajasa_box.Text + "', 'biaya transportasi = " +
                //                                        biayatransportasi_box.Text + "', 'biaya ongkir dokumen = " + biayaongkir_box.Text + "', 'keterangan2 = " + keterangan2_box.Text + "', 'no rekening = " + rekening_box.Text + "', 'nama bank = " +
                //                                        bank_box.Text + "', 'tanggal request = " + request_dpick.Text + "', 'transfer = " + transfer_box.Text + "', 'status transfer = " + statustransfer_box.Text + "', 'tanggal transfer = " +
                //                                        tanggaltransfer_dpick.Text + "') WHERE 'caseID = " + caseID_box.Text + "' ";

                query = "UPDATE [data] SET [category project] = '" + categoryproject_box.Text + "', [perusahaan] = '" + perusahaan_cbox.Text + "', [project name] = '" + project_box.Text + "', [nama user] = '" + namauser_box.Text + "', [noHP/telp] = '" + nohp_box.Text + "', [branch] = '" + branch_box.Text + "', [alamat] = '" + alamat_box.Text + "', [type] = '" + type_cbox.Text + "', [sn unit] = '" + sn_box.Text + "', [problem] = '" + problem_box.Text + "', [category request] = '" + problemrequest_cbox.Text + "', [tanggal case closed] = '" + caseclosed_dpicker.Text + "', [solusi] = '" + solusi_box.Text + "', [status case] = '" + statuscase_box.Text + "', [keterangan] = '" + ket_box.Text + "', [invoice vendor number] = '" + vendor_number.Text + "', [nama engineer] = '" + engineer_box.Text + "', [bap] = '" + bap_cbox.Text + "', [biaya jasa] = '" + biayajasa_box.Text + "', [biaya transportasi] = '" + biayatransportasi_box.Text + "', [biaya ongkir dokumen] = '" + biayaongkir_box.Text + "', [keterangan2] = '" + keterangan2_box.Text + "', [no rekening] = '" + rekening_box.Text + "', [nama bank] = '" + bank_box.Text + "', [tanggal request] = '" + request_dpick.Text + "', [transfer] = '" + transfer_box.Text + "', [status transfer] = '" + statustransfer_box.Text + "', [tanggal transfer] = '" + tanggaltransfer_dpick.Text + "' WHERE caseID = '" + caseID_box.Text + "' ";
               // MessageBox.Show(query);
                try
                {
                    conn.connect(System.AppDomain.CurrentDomain.BaseDirectory);
                    conn.sql_execution(query);
                    conn.con.Close();
                    MessageBox.Show("Data selesai diedit");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Semua form harus diisi! (jika kosong isi dengan '-')");
            }
        }
    }
}

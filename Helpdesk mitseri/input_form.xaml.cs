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
    /// Interaction logic for input_form.xaml
    /// </summary>
    public partial class input_form : Window
    {
        connection_class conn = new connection_class();

        public input_form()
        {
            InitializeComponent();
            var date = DateTime.Now;
            tanggal_box.Text = date.ToString();
            if (Helpdesk_mitseri.Properties.Settings.Default.waktu.ToString() == DateTime.Now.ToString("MM/yyyy"))
            {
                Helpdesk_mitseri.Properties.Settings.Default.ID = Helpdesk_mitseri.Properties.Settings.Default.ID + 1;
                string s = DateTime.Now.ToString("MMyy") + Helpdesk_mitseri.Properties.Settings.Default.ID.ToString("D2");
                //MessageBox.Show(s);
                caseID_box.Text = s;
            }
            else
            {
                Helpdesk_mitseri.Properties.Settings.Default.waktu = DateTime.Now.ToString("MM/yyyy");
                Helpdesk_mitseri.Properties.Settings.Default.ID = 0;
                Helpdesk_mitseri.Properties.Settings.Default.ID = Helpdesk_mitseri.Properties.Settings.Default.ID + 1;
                string s = DateTime.Now.ToString("MMyy") + Helpdesk_mitseri.Properties.Settings.Default.ID.ToString("D2");
                //MessageBox.Show(s);
                caseID_box.Text = s;
            }
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
                transfer_box.Text != "" &&
                statustransfer_box.Text != "" &&
                caseclosed_dpicker.Text != "" &&
                request_dpick.Text != "" &&
                tanggaltransfer_dpick.Text != "")
            {
                //string tanggaltransfer, caseclosed, request = "";
                //if (tanggaltransfer_dpick.Text == "" && request_dpick.Text == "" && caseclosed_dpicker.Text == "")
                //{
                //    tanggaltransfer = "-";
                //    caseclosed = "-";
                //    request = "-";
                //}
                    query = "INSERT INTO [data] VALUES ('" + tanggal_box.Text + "', '" + DateTime.Now.ToString("HH:mm") + "', '" + caseID_box.Text + "', '" + categoryproject_box.Text + "', '" + perusahaan_cbox.Text + "', '" + project_box.Text + "', '" + namauser_box.Text + "', '" + nohp_box.Text + "', '" + branch_box.Text + "', '" + alamat_box.Text + "', '" + type_cbox.Text + "', '" + sn_box.Text + "', '" + problem_box.Text + "', '" + problemrequest_cbox.Text + "', '" + 
                                                        caseclosed_dpicker.Text + "', '" + solusi_box.Text + "', '" + statuscase_box.Text + "', '" + ket_box.Text + "', '" + 
                                                        vendor_number.Text + "', '" + engineer_box.Text + "', '" + bap_cbox.Text + "', '" + biayajasa_box.Text + "', '" + 
                                                        biayatransportasi_box.Text + "', '" + biayaongkir_box.Text + "', '" + keterangan2_box.Text + "', '" + rekening_box.Text + "', '" + 
                                                        bank_box.Text + "', '" + request_dpick.Text + "', '" + transfer_box.Text + "', '" + statustransfer_box.Text + "', '" + 
                                                        tanggaltransfer_dpick.Text + "') ";
                //MessageBox.Show(query);
                //query = "INSERT INTO [data('tanggal', 'time_created', 'caseID', 'category_project', 'perusahaan', 'project_name', 'nama_user', 'noHP/telp', 'branch', 'alamat', 'type', 'sn_unit', 'problem', 'category_request', 'tanggal_case_closed', 'solusi', 'status_case', 'keterangan', 'invoice_vendor_number', 'nama_engineer', 'bap', 'biaya_jasa', 'biaya_transportasi', 'biaya_ongkir_dokumen', 'keterangan2', 'no_rekening', 'nama_bank', 'tanggal_request', 'transfer', 'status_transfer', 'tanggal_transfer'] VALUES ('" + tanggal_box.Text + "', '" + DateTime.Now.ToString() + "', '" + caseID_box.Text + "', '" + categoryproject_box.Text + "', '" +
                //                        perusahaan_cbox.Text + "', '" + project_box.Text + "', '" + namauser_box.Text + "', '" + nohp_box.Text + "', '" + branch_box.Text + "', '" +
                //                        alamat_box.Text + "', '" + type_cbox.Text + "', '" + sn_box.Text + "', '" + problem_box.Text + "', '" + problemrequest_cbox.Text + "', '" +
                //                        caseclosed_dpicker.Text + "', '" + solusi_box.Text + "', '" + statuscase_box.Text + "', '" + ket_box.Text + "', '" +
                //                        vendor_number.Text + "', '" + engineer_box.Text + "', '" + bap_cbox.Text + "', '" + biayajasa_box.Text + "', '" +
                //                        biayatransportasi_box.Text + "', '" + biayaongkir_box.Text + "', '" + keterangan2_box.Text + "', '" + rekening_box.Text + "', '" +
                //                        bank_box.Text + "', '" + request_dpick.Text + "', '" + transfer_box.Text + "', '" + statustransfer_box.Text + "', '" +
                //                        tanggaltransfer_dpick.Text + "') ";
                try
                {
                    conn.connect(System.AppDomain.CurrentDomain.BaseDirectory);
                    conn.sql_execution(query);
                    conn.con.Close();
                    MessageBox.Show("Data selesai dimasukkan");
                    Helpdesk_mitseri.Properties.Settings.Default.Save();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //string query = "INSERT INTO [pelaporan] VALUES ('" + time + "', '" + variable.Nama + "', '" + variable.Jumlah + "', '0', '" + variable.History + "'); ";
            }
            else
            {
                MessageBox.Show("Semua form harus diisi! (jika kosong isi dengan '-')");
            }
        }
    }
}

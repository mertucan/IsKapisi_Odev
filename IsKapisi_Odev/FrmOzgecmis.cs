using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsKapisi_Odev
{
    public partial class FrmOzgecmis : Form
    {
        public FrmOzgecmis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ozgecmis_yazisi = "Ad: " + txtAd.Text + "\nSoyad: " + txtSoyad.Text + "\nE Posta: " + txtPosta.Text + "\nYaş: " + txtYas.Text + "\nTelefon: " + txtTelefon.Text + "\nÜlke: " + txtUlke.Text + "\nİl/İlçe: " + txtIlIlce.Text + "\nUyruk: " + txtUyruk.Text + "\nCinsiyet: " + cmbCinsiyet.SelectedItem.ToString() + "\nYetenekler: " + txtYetenekler.Text + "\nYabancı Dil: " + txtDil.Text + "\nLise Adı: " + txtLiseAdi.Text + "\nLise Bölümü: " + txtLiseBolumu.Text + "\nÜniversite Adı: " + txtUniversiteAdi.Text + "\nÜniversite Bölümü: " + txtUniversiteBolumu.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "INSERT INTO Ozgecmis(AdayID, Ozgecmis) values (@AdayID, @Ozgecmis)";
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@AdayID", FrmGiris.id.ToString());
                    komut.Parameters.AddWithValue("@Ozgecmis", ozgecmis_yazisi);
                    komut.ExecuteNonQuery();
                    con.Close();

                    DialogResult result = MessageBox.Show("Özgeçmiş eklendi.", "Kayıt Başarılı!", MessageBoxButtons.OK);
                }

            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }

        }

        private void FrmOzgecmis_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string sorgu1 = "SELECT * FROM Aday WHERE AdayID = '" + FrmGiris.id.ToString() + "'";
            con1.Open();

            SqlCommand cmd1 = new SqlCommand(sorgu1, con1);
            SqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                txtAd.Text = read1["Isim"].ToString();
                txtSoyad.Text = read1["Soyad"].ToString();
                txtPosta.Text = read1["Email"].ToString();
                txtTelefon.Text = read1["Telefon"].ToString();
                txtYas.Text = read1["Yas"].ToString();
            }
        }
    }
}

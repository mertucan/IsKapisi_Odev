using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsKapisi_Odev
{
    public partial class FrmAdayAyarlar : Form
    {
        public FrmAdayAyarlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string sorgu = "UPDATE Aday SET Isim=@Ad, Soyad=@Soyad, Email=@Email, Telefon=@Telefon, Yas=@Yas  WHERE AdayID=@AdayID";

            con1.Open();

            SqlCommand command = new SqlCommand(sorgu, con1);

            command.Parameters.AddWithValue("@Ad", txtAd.Text);
            command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@Email", txtPosta.Text);
            command.Parameters.AddWithValue("@Telefon", txtTelefon.Text);
            command.Parameters.AddWithValue("@Yas", int.Parse(txtYas.Text));
            command.Parameters.AddWithValue("@AdayID", FrmGiris.id);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                DialogResult result = MessageBox.Show("Başarıyla bilgileriniz güncellendi.", "Güncelleme Başarılı!", MessageBoxButtons.OK);
            }

            else
            {
                DialogResult result = MessageBox.Show("Bir şeyler ters gitti...", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        void sifreGetir()
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string sorgu1 = "SELECT * FROM Aday WHERE AdayID = '" + FrmGiris.id.ToString() + "'";

            con1.Open();
            
            SqlCommand cmd1 = new SqlCommand(sorgu1, con1);

            SqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                sifre = read1["Sifre"].ToString();
            }
        }

        string sifre = "";

        private void button2_Click(object sender, EventArgs e)
        {
            sifreGetir();
            
            if (txtYeniSifre.Text == txtTekrar.Text && sifre == txtEskiSifre.Text)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

                con1.Open();

                string sorgu = "UPDATE Aday SET Sifre=@Sifre WHERE AdayID=@AdayID";

                SqlCommand command = new SqlCommand(sorgu, con1);

                command.Parameters.AddWithValue("@Sifre", txtYeniSifre.Text);
                command.Parameters.AddWithValue("@AdayID", FrmGiris.id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    DialogResult result = MessageBox.Show("Başarıyla bilgileriniz güncellendi.", "Güncelleme Başarılı!", MessageBoxButtons.OK);
                }

                else
                {
                    DialogResult result = MessageBox.Show("Bir şeyler ters gitti...", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                DialogResult result = MessageBox.Show("Yeni şifre veya tekrarlanan şifre yanlış", "Hatalı Giriş!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}

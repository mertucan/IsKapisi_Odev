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
    public partial class FrmIlan : Form
    {
        public FrmIlan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string is_tanimi = " Çalışma Şekli: " + cmbCalismaSekli.SelectedItem.ToString() + "\n Seviye: " + cmbSeviye.SelectedItem.ToString() + "\n Departman: " + txtDepartman.Text + "\n Eğitim Seviyesi:" + txtEgitimSeviyesi.Text + "\n Tecrübe: " + cmbTecrube.Text + "\n İş Tanımı: " + txtTanim.Text;

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "INSERT INTO Ilan(IsverenID, Gereksinimler) values (@IsverenID, @Gereksinimler)";
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@IsverenID", FrmGiris.isveren.ToString());
                    komut.Parameters.AddWithValue("@Gereksinimler", is_tanimi);
                    komut.ExecuteNonQuery();
                    con.Close();

                    DialogResult result = MessageBox.Show("İlan eklendi.", "Kayıt Başarılı!", MessageBoxButtons.OK);
                }

            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }

            cmbCalismaSekli.SelectedItem = null;
            cmbSeviye.SelectedItem = null;
            cmbTecrube.SelectedItem = null;
            txtDepartman.Clear();
            txtEgitimSeviyesi.Clear();
            txtTanim.Clear();
        }


    }
}

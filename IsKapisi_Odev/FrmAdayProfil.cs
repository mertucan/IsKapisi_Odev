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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IsKapisi_Odev
{
    public partial class FrmAdayProfil : Form
    {
        public FrmAdayProfil()
        {
            InitializeComponent();
        }

        string metin;

        private void FrmAdayProfil_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string sorgu1 = "SELECT *,Ozgecmis.Ozgecmis FROM Aday INNER JOIN Ozgecmis ON Ozgecmis.AdayID = Aday.AdayID WHERE Aday.AdayID =" + FrmGiris.id.ToString();

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
                metin = read1["Ozgecmis"].ToString();
            }

            if (metin != null)
            {
                var kelimeler = metin.Split('\n');

                foreach (var kelime in kelimeler)
                {
                    listBox1.Items.Add(kelime);
                }
            }


        }
    }
}

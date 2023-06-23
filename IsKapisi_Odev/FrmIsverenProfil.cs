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
    public partial class FrmIsverenProfil : Form
    {
        public FrmIsverenProfil()
        {
            InitializeComponent();
        }

        private void FrmIsverenProfil_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string sorgu1 = "SELECT * FROM Isveren WHERE IsverenID=" + FrmGiris.isveren.ToString();

            con1.Open();

            SqlCommand cmd1 = new SqlCommand(sorgu1, con1);

            SqlDataReader read1 = cmd1.ExecuteReader();

            while (read1.Read())
            {
                txtAd.Text = read1["Ad"].ToString();
                txtSoyad.Text = read1["Soyad"].ToString();
                txtPosta.Text = read1["Email"].ToString();
                txtTelefon.Text = read1["Telefon"].ToString();
                txtYas.Text = read1["Yas"].ToString();
            }
        }
    }
}

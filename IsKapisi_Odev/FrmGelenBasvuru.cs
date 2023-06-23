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
    public partial class FrmGelenBasvuru : Form
    {
        public FrmGelenBasvuru()
        {
            InitializeComponent();
        }

        void dgv_getir()
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string query = "SELECT Basvuru.BasvuruID, CONCAT(Aday.Isim, ' ', Aday.Soyad) AS Aday, CONCAT(Isveren.Ad, ' ', Isveren.Soyad) AS Isveren, Ilan.Gereksinimler, Ozgecmis.Ozgecmis, Basvuru.Durum FROM Basvuru\r\nINNER JOIN Aday ON Aday.AdayID = Basvuru.AdayID\r\nINNER JOIN Ilan ON Ilan.IlanID = Basvuru.IlanID\r\nINNER JOIN Ozgecmis ON Ozgecmis.AdayID = Aday.AdayID\r\nINNER JOIN Isveren ON Ilan.IsverenID = Isveren.IsverenID WHERE Isveren.IsverenID =" + FrmGiris.isveren;

            SqlDataAdapter da = new SqlDataAdapter(query, con1);

            DataSet ds = new DataSet();

            con1.Open();

            da.Fill(ds, "Basvuru");

            dataGridView1.DataSource = ds.Tables[0];

            con1.Close();
        }

        private void FrmGelenBasvuru_Load(object sender, EventArgs e)
        {
            dgv_getir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string column1Value = row.Cells["Aday"].Value.ToString();
                string column2Value = row.Cells["Isveren"].Value.ToString();
                string column3Value = row.Cells["Gereksinimler"].Value.ToString();
                string column4Value = row.Cells["Ozgecmis"].Value.ToString();
                string column5Value = row.Cells["Durum"].Value.ToString();

                basvuru_id = row.Cells["BasvuruID"].Value.ToString();

                MessageBox.Show("Aday: " + column1Value + "\nIsveren: " + column2Value + "\nGereksinimler: " + column3Value + "\nOzgecmis: " + column4Value + "\nDurum: " + column5Value);
            }
        }

        string basvuru_id;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "UPDATE Basvuru SET Durum = 'Kabul Edildi' WHERE BasvuruID =" + basvuru_id;
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.ExecuteNonQuery();
                    con.Close();

                    DialogResult result = MessageBox.Show("Başvuru kabul edildi.", "Başarılı!", MessageBoxButtons.OK);

                    dgv_getir();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "UPDATE Basvuru SET Durum = 'Reddedildi' WHERE BasvuruID =" + basvuru_id;
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.ExecuteNonQuery();
                    con.Close();

                    DialogResult result = MessageBox.Show("Başvuru reddedildi.", "Başarılı!", MessageBoxButtons.OK);

                    dgv_getir();
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }
        }
    }
}

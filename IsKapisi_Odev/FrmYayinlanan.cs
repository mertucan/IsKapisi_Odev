using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IsKapisi_Odev
{
    public partial class FrmYayinlanan : Form
    {
        public FrmYayinlanan()
        {
            InitializeComponent();
        }

        private void FrmYayinlanan_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string query = "SELECT Ilan.IlanID ,CONCAT(Isveren.Ad, ' ', Isveren.Soyad) AS Isveren, Ilan.Gereksinimler FROM Ilan INNER JOIN Isveren ON Isveren.IsverenID = Ilan.IsverenID";

            SqlDataAdapter da = new SqlDataAdapter(query, con1);

            DataSet ds = new DataSet();

            con1.Open();

            da.Fill(ds, "Isveren");

            dataGridView1.DataSource = ds.Tables[0];

            con1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "INSERT INTO Basvuru(AdayID, IlanID) VALUES (@AdayID, @IlanID)";
                    SqlCommand komut = new SqlCommand(kayit, con);

                    komut.Parameters.AddWithValue("@AdayID", FrmGiris.id.ToString());
                    komut.Parameters.AddWithValue("@IlanID", ilan_id);

                    komut.ExecuteNonQuery();
                    con.Close();

                    DialogResult result = MessageBox.Show("Başvurunuz işlenmiştir.", "Başvuru Başarılı!", MessageBoxButtons.OK);
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
            }
        }

        string ilan_id;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                ilan_id = row.Cells["IlanID"].Value.ToString();

                string column1Value = row.Cells["Isveren"].Value.ToString();
                string column3Value = row.Cells["Gereksinimler"].Value.ToString();

                MessageBox.Show("İşveren: " + column1Value + "\nGereksinimler:" + column3Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            con.Open();

            if (checkBox1.Checked == true)
            {
                string aranan = txtAra.Text;

                string sorgu = "SELECT Ilan.IlanID ,CONCAT(Isveren.Ad, ' ', Isveren.Soyad) AS Isveren, Ilan.Gereksinimler FROM Ilan INNER JOIN Isveren ON Isveren.IsverenID = Ilan.IsverenID WHERE CONCAT(Isveren.Ad, ' ', Isveren.Soyad) LIKE'%" + aranan + "%'";

                SqlDataAdapter adap = new SqlDataAdapter(sorgu, con);

                DataSet ds = new DataSet();

                adap.Fill(ds, "Basvuru");

                this.dataGridView1.DataSource = ds.Tables[0];

                con.Close();
            }

            if (checkBox2.Checked == true)
            {
                string aranan = txtAra.Text;

                string sorgu = "SELECT Ilan.IlanID ,CONCAT(Isveren.Ad, ' ', Isveren.Soyad) AS Isveren, Ilan.Gereksinimler FROM Ilan INNER JOIN Isveren ON Isveren.IsverenID = Ilan.IsverenID WHERE Ilan.Gereksinimler LIKE'%" + aranan + "%'";

                SqlDataAdapter adap = new SqlDataAdapter(sorgu, con);

                DataSet ds = new DataSet();

                adap.Fill(ds, "Basvuru");

                this.dataGridView1.DataSource = ds.Tables[0];

                con.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }

        }
    }
}

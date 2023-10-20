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
    public partial class FrmBasvurularim : Form
    {
        public FrmBasvurularim()
        {
            InitializeComponent();
        }

        private void FrmBasvurularim_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string query = "SELECT Basvuru.IlanID, Ilan.Gereksinimler, Isveren.Ad, Isveren.Soyad, Basvuru.Durum FROM Basvuru INNER JOIN Ilan ON Ilan.IlanID = Basvuru.IlanID INNER JOIN Isveren ON Isveren.IsverenID = Ilan.IsverenID WHERE Basvuru.AdayID =" + FrmGiris.id;

            SqlDataAdapter da = new SqlDataAdapter(query, con1);

            DataSet ds = new DataSet();

            con1.Open();

            da.Fill(ds, "Basvuru");

            dataGridView1.DataSource = ds.Tables[0];

            con1.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string column1Value = row.Cells["Ad"].Value.ToString();
                string column2Value = row.Cells["Soyad"].Value.ToString();
                string column3Value = row.Cells["Gereksinimler"].Value.ToString();
                string column4Value = row.Cells["Durum"].Value.ToString();

                MessageBox.Show("Ad: " + column1Value + "\nSoyad: " + column2Value + "\nGereksinimler:" + column3Value + "\nBaşvuru Durumu:" + column4Value);
            }
        }
    }
}

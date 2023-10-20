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
    public partial class FrmIlanlarim : Form
    {
        public FrmIlanlarim()
        {
            InitializeComponent();
        }

        private void FrmIlanlarim_Load(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            string query = "SELECT Ilan.IlanID ,CONCAT(Isveren.Ad, ' ', Isveren.Soyad) AS Isveren, Ilan.Gereksinimler FROM Ilan INNER JOIN Isveren ON Isveren.IsverenID = Ilan.IsverenID WHERE Isveren.IsverenID =" + FrmGiris.isveren;

            SqlDataAdapter da = new SqlDataAdapter(query, con1);

            DataSet ds = new DataSet();

            con1.Open();

            da.Fill(ds, "Ilan");

            dataGridView1.DataSource = ds.Tables[0];

            con1.Close();
        }
    }
}

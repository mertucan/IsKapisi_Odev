using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IsKapisi_Odev
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }



        private void textBox4_Click(object sender, EventArgs e)
        {
            label2.Text = "Soyad";
            textBox4.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            label4.Text = "Ad";
            textBox3.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label3.Text = "E-Posta";
            textBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            pictureBox6.Visible = false;


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;
            pictureBox7.Visible = true;
            textBox2.PasswordChar = '•';
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label5.Text = "Şifre";
            textBox2.Text = "";
        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox6.Visible = true;
            textBox2.PasswordChar = '\0';
        }

        int yas = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");

            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        string kayit = "insert into aday(Isim, Soyad, Email, Sifre, Yas, Telefon) values (@Isim, @Soyad, @Email, @Sifre, @Yas, @Telefon)";
                        SqlCommand komut = new SqlCommand(kayit, con);
                        komut.Parameters.AddWithValue("@Isim", textBox3.Text);
                        komut.Parameters.AddWithValue("@Soyad", textBox4.Text);
                        komut.Parameters.AddWithValue("@Email", textBox1.Text);
                        komut.Parameters.AddWithValue("@Sifre", textBox2.Text);
                        komut.Parameters.AddWithValue("@Yas", yas);
                        komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
                        komut.ExecuteNonQuery();
                        con.Close();

                        DialogResult result = MessageBox.Show("Başarıyla kayıt oldunuz.", "Kayıt Başarılı!", MessageBoxButtons.OK);

                        comboBox1.Text = "Kullanıcı Tipi";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox2.Text = "";
                        textBox1.Text = "";
                        textBox5.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                        string kayit = "insert into Isveren(Ad, Soyad, Email, Sifre, Yas, Telefon) values (@Ad, @Soyad, @Email, @Sifre, @Yas, @Telefon)";
                        SqlCommand komut = new SqlCommand(kayit, con);
                        komut.Parameters.AddWithValue("@Ad", textBox3.Text);
                        komut.Parameters.AddWithValue("@Soyad", textBox4.Text);
                        komut.Parameters.AddWithValue("@Email", textBox1.Text);
                        komut.Parameters.AddWithValue("@Sifre", textBox2.Text);
                        komut.Parameters.AddWithValue("@Yas", yas);
                        komut.Parameters.AddWithValue("@Telefon", textBox5.Text);
                        komut.ExecuteNonQuery();
                        con.Close();

                        DialogResult result = MessageBox.Show("Başarıyla kayıt oldunuz.", "Kayıt Başarılı!", MessageBoxButtons.OK);

                        comboBox1.Text = "Kullanıcı Tipi";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox2.Text = "";
                        textBox1.Text = "";
                        textBox5.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                    }

                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu. " + hata.Message);
                }
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            label7.Text = "Telefon Numarası";
            textBox5.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan fark;
            DateTime dogumtarihi;
            dogumtarihi = Convert.ToDateTime(dateTimePicker1.Text);
            fark = DateTime.Now.Date.Subtract(dogumtarihi);
            yas = Convert.ToInt32(fark.TotalDays);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FrmGiris frm1 = new FrmGiris();
            frm1.TopMost = true;
            frm1.Show();
        }
    }
}

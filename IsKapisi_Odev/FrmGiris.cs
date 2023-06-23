using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IsKapisi_Odev
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }


        FrmKayit frm2 = new FrmKayit();

        public static int id;

        public static int isveren;

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseHover_1(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Purple;
            label3.Font = new Font(label3.Font, label3.Font.Style | FontStyle.Underline);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(55, 71, 120);
            label3.Font = new Font(label3.Font, label3.Font.Style & ~FontStyle.Underline);
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {           
            textBox1.Clear();
            label4.Text = "E-Posta";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
            label5.Text = "Þifre";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=IsKapisi;Integrated Security=True");
            string sorgu1 = "SELECT * FROM Aday WHERE Email='" + textBox1.Text.Trim() + "' AND Sifre='" + textBox2.Text.Trim() + "'";
            string sorgu2 = "SELECT * FROM Isveren WHERE Email='" + textBox1.Text.Trim() + "' AND Sifre='" + textBox2.Text.Trim() + "'";

            string sorgu3 = "SELECT AdayID FROM Aday WHERE Email='" + textBox1.Text.Trim() + "'";
            string sorgu4 = "SELECT IsverenID FROM Isveren WHERE Email='" + textBox1.Text.Trim() + "'";

            DataTable table = new DataTable();

            if (comboBox1.SelectedIndex == 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter(sorgu1, con);
                sda.Fill(table);

                if (table.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sorgu3, con);
                    SqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        id = Convert.ToInt32(read["AdayID"]);
                    }

                    FrmAday frm3 = new FrmAday();
                    frm3.Show();
                    this.Hide();
                    frm2.Hide();
                }

                else
                {
                    DialogResult result = MessageBox.Show("Yanlýþ þifre veya kullanýcý adý girdiniz.", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                SqlDataAdapter sda = new SqlDataAdapter(sorgu2, con);
                sda.Fill(table);

                if (table.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sorgu4, con);
                    SqlDataReader read = cmd.ExecuteReader();

                    while (read.Read())
                    {
                        isveren = Convert.ToInt32(read["IsverenID"]);
                    }

                    FrmIsveren frm3 = new FrmIsveren();
                    frm3.Show();
                    this.Hide();
                    frm2.Hide();
                }

                else
                {
                    DialogResult result = MessageBox.Show("Yanlýþ þifre veya kullanýcý adý girdiniz.", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            pictureBox6.Visible = true;

            textBox2.PasswordChar = '\0';
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox6.Visible = false;

            frm2.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox6.Visible = false;

            textBox2.PasswordChar = '•';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            frm2.Left += 10;
            if (frm2.Left >= 1760)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            frm2.Left -= 10;
            if (frm2.Left <= 1100)
            {
                timer2.Stop();

            }
        }
    }
}
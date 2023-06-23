using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsKapisi_Odev
{
    public partial class FrmAday : Form
    {
        public FrmAday()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            label3.Text = button1.Text.ToString();
            pictureBox8.Visible = false;

            panel3.BackColor = Color.FromArgb(140, 101, 211);

            FrmAdayProfil frm = new FrmAdayProfil();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = button2.Text.ToString();
            pictureBox8.Visible = false;

            panel3.BackColor = Color.FromArgb(65, 179, 247);

            FrmOzgecmis frm = new FrmOzgecmis();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = button3.Text.ToString();
            pictureBox8.Visible = false;

            panel3.BackColor = Color.FromArgb(0, 197, 144);

            FrmYayinlanan frm = new FrmYayinlanan();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = button4.Text.ToString();
            pictureBox8.Visible = false;

            panel3.BackColor = Color.FromArgb(255, 141, 56);

            FrmBasvurularim frm = new FrmBasvurularim();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = button6.Text.ToString();
            pictureBox8.Visible = false;

            panel3.BackColor = Color.FromArgb(237, 0, 39);

            FrmAdayAyarlar frm = new FrmAdayAyarlar();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGiris frm1 = new FrmGiris();

            this.Close();
            frm1.Show();
        }
    }
}

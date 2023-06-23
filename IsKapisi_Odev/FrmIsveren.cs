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
    public partial class FrmIsveren : Form
    {
        public FrmIsveren()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = button1.Text.ToString();
            pictureBox8.Visible = false;

            panel3.BackColor = Color.FromArgb(140, 101, 211);

            FrmIsverenProfil frm = new FrmIsverenProfil();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = button3.Text.ToString();
            pictureBox8.Visible = false;

            panel3.BackColor = Color.FromArgb(0, 197, 144);

            FrmIlan frm = new FrmIlan();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = button4.Text.ToString();
            pictureBox8.Visible = false;

            FrmGelenBasvuru frm = new FrmGelenBasvuru();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            panel3.BackColor = Color.FromArgb(255, 141, 56);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label4.Text = button6.Text.ToString();
            pictureBox8.Visible = false;

            FrmIsverenAyarlar frm = new FrmIsverenAyarlar();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            panel3.BackColor = Color.FromArgb(237, 0, 39);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = button2.Text.ToString();
            pictureBox8.Visible = false;

            FrmIlanlarim frm = new FrmIlanlarim();
            frm.TopLevel = false;
            panel4.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            panel3.BackColor = Color.FromArgb(65, 179, 247);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmGiris frm1 = new FrmGiris();

            this.Close();
            frm1.Show();
        }
    }
}

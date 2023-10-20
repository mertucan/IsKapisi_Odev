namespace IsKapisi_Odev
{
    partial class FrmIlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtEgitimSeviyesi = new TextBox();
            txtDepartman = new TextBox();
            button1 = new Button();
            panel7 = new Panel();
            txtTanim = new TextBox();
            label7 = new Label();
            cmbTecrube = new ComboBox();
            panel6 = new Panel();
            label6 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            cmbSeviye = new ComboBox();
            panel3 = new Panel();
            label2 = new Label();
            cmbCalismaSekli = new ComboBox();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEgitimSeviyesi);
            groupBox1.Controls.Add(txtDepartman);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel7);
            groupBox1.Controls.Add(txtTanim);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbTecrube);
            groupBox1.Controls.Add(panel6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(panel5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmbSeviye);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbCalismaSekli);
            groupBox1.Controls.Add(panel2);
            groupBox1.Location = new Point(165, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1037, 518);
            groupBox1.TabIndex = 85;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlan Bilgileri";
            // 
            // txtEgitimSeviyesi
            // 
            txtEgitimSeviyesi.BorderStyle = BorderStyle.None;
            txtEgitimSeviyesi.Location = new Point(212, 306);
            txtEgitimSeviyesi.Name = "txtEgitimSeviyesi";
            txtEgitimSeviyesi.Size = new Size(220, 28);
            txtEgitimSeviyesi.TabIndex = 86;
            // 
            // txtDepartman
            // 
            txtDepartman.BorderStyle = BorderStyle.None;
            txtDepartman.Location = new Point(208, 235);
            txtDepartman.Name = "txtDepartman";
            txtDepartman.Size = new Size(224, 28);
            txtDepartman.TabIndex = 85;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(56, 71, 120);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(574, 435);
            button1.Name = "button1";
            button1.Size = new Size(420, 63);
            button1.TabIndex = 84;
            button1.Text = "İlanı Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(574, 420);
            panel7.Name = "panel7";
            panel7.Size = new Size(420, 1);
            panel7.TabIndex = 83;
            // 
            // txtTanim
            // 
            txtTanim.BorderStyle = BorderStyle.None;
            txtTanim.Location = new Point(563, 61);
            txtTanim.Multiline = true;
            txtTanim.Name = "txtTanim";
            txtTanim.Size = new Size(431, 353);
            txtTanim.TabIndex = 82;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(563, 31);
            label7.Name = "label7";
            label7.Size = new Size(107, 27);
            label7.TabIndex = 81;
            label7.Text = "İş Tanımı";
            // 
            // cmbTecrube
            // 
            cmbTecrube.FormattingEnabled = true;
            cmbTecrube.Items.AddRange(new object[] { "Tecrübeli", "Tecrübesiz" });
            cmbTecrube.Location = new Point(210, 372);
            cmbTecrube.Name = "cmbTecrube";
            cmbTecrube.Size = new Size(222, 35);
            cmbTecrube.TabIndex = 80;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(208, 409);
            panel6.Name = "panel6";
            panel6.Size = new Size(222, 1);
            panel6.TabIndex = 79;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(33, 376);
            label6.Name = "label6";
            label6.Size = new Size(97, 27);
            label6.TabIndex = 78;
            label6.Text = "Tecrübe";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(208, 340);
            panel5.Name = "panel5";
            panel5.Size = new Size(222, 1);
            panel5.TabIndex = 76;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(33, 307);
            label5.Name = "label5";
            label5.Size = new Size(173, 27);
            label5.TabIndex = 75;
            label5.Text = "Eğitim Seviyesi";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(208, 269);
            panel4.Name = "panel4";
            panel4.Size = new Size(222, 1);
            panel4.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(33, 236);
            label4.Name = "label4";
            label4.Size = new Size(131, 27);
            label4.TabIndex = 72;
            label4.Text = "Departman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(33, 167);
            label3.Name = "label3";
            label3.Size = new Size(82, 27);
            label3.TabIndex = 71;
            label3.Text = "Seviye";
            // 
            // cmbSeviye
            // 
            cmbSeviye.FormattingEnabled = true;
            cmbSeviye.Items.AddRange(new object[] { "Uzman", "Yeni Başlayan", "İşçi", "Stajyer", "Eleman" });
            cmbSeviye.Location = new Point(210, 164);
            cmbSeviye.Name = "cmbSeviye";
            cmbSeviye.Size = new Size(222, 35);
            cmbSeviye.TabIndex = 70;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(208, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 1);
            panel3.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(33, 96);
            label2.Name = "label2";
            label2.Size = new Size(158, 27);
            label2.TabIndex = 68;
            label2.Text = "Çalışma Şekli";
            // 
            // cmbCalismaSekli
            // 
            cmbCalismaSekli.FormattingEnabled = true;
            cmbCalismaSekli.Items.AddRange(new object[] { "Tam Zamanlı (Full-Time)", "Yarı Zamanlı (Part-Time)", "Serbest (Freelance)", "Evden Çalışma (Home-Office)" });
            cmbCalismaSekli.Location = new Point(210, 93);
            cmbCalismaSekli.Name = "cmbCalismaSekli";
            cmbCalismaSekli.Size = new Size(222, 35);
            cmbCalismaSekli.TabIndex = 67;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(208, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 1);
            panel2.TabIndex = 66;
            // 
            // FrmIlan
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1356, 542);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmIlan";
            Text = "FrmIlan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Panel panel7;
        private TextBox txtTanim;
        private Label label7;
        private ComboBox cmbTecrube;
        private Panel panel6;
        private Label label6;
        private Panel panel5;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private ComboBox cmbSeviye;
        private Panel panel3;
        private Label label2;
        private ComboBox cmbCalismaSekli;
        private Panel panel2;
        private TextBox txtEgitimSeviyesi;
        private TextBox txtDepartman;
    }
}
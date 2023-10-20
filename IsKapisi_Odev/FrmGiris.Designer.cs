namespace IsKapisi_Odev
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            label1 = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.DarkRed;
            label1.Font = new Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(655, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 32);
            label1.TabIndex = 29;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(145, 588);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 1);
            panel3.TabIndex = 20;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aday Girişi", "İşveren Girişi" });
            comboBox1.Location = new Point(145, 542);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 44);
            comboBox1.TabIndex = 28;
            comboBox1.Text = "Kullanıcı Tipi";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(70, 532);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 27;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(254, 942);
            label3.Name = "label3";
            label3.Size = new Size(178, 27);
            label3.TabIndex = 26;
            label3.Text = "Hemen Üye Ol!";
            label3.Click += label3_Click_1;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseHover += label3_MouseHover_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(164, 906);
            label2.Name = "label2";
            label2.Size = new Size(393, 27);
            label2.TabIndex = 25;
            label2.Text = "İş Kapısı'nda bir hesabınız yok mu?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(56, 71, 120);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(70, 824);
            button1.Name = "button1";
            button1.Size = new Size(545, 63);
            button1.TabIndex = 24;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(145, 772);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 1);
            panel2.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(145, 731);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(470, 37);
            textBox2.TabIndex = 22;
            textBox2.Text = "Şifre";
            textBox2.MouseClick += textBox2_MouseClick;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(70, 721);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(145, 672);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 1);
            panel1.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(145, 631);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 37);
            textBox1.TabIndex = 18;
            textBox1.Text = "E-Posta";
            textBox1.MouseClick += textBox1_MouseClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 621);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(590, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(145, 604);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(145, 689);
            label5.Name = "label5";
            label5.Size = new Size(0, 24);
            label5.TabIndex = 31;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(276, 452);
            label6.Name = "label6";
            label6.Size = new Size(156, 37);
            label6.TabIndex = 32;
            label6.Text = "Giriş Yap";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(558, 715);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(57, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 33;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(558, 715);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(57, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 34;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            timer2.Tick += timer2_Tick;
            // 
            // FrmGiris
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(705, 977);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private ComboBox comboBox1;
        private PictureBox pictureBox5;
        private Label label3;
        private Label label2;
        private Button button1;
        private Panel panel2;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
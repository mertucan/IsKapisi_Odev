namespace IsKapisi_Odev
{
    partial class FrmYayinlanan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            txtAra = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(113, 96, 202);
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(113, 96, 232);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(100, 150, 200);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 230, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(100, 100, 180);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(3, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.RowTemplate.DividerHeight = 2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1326, 333);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(56, 71, 120);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(961, 467);
            button1.Name = "button1";
            button1.Size = new Size(383, 63);
            button1.TabIndex = 25;
            button1.Text = "Başvuru Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 100, 180);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(1332, 375);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 488);
            label1.Name = "label1";
            label1.Size = new Size(374, 27);
            label1.TabIndex = 27;
            label1.Text = "Detaylı bilgi için üzerine tıklayınız.";
            // 
            // txtAra
            // 
            txtAra.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtAra.BackColor = Color.White;
            txtAra.BorderStyle = BorderStyle.None;
            txtAra.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAra.Location = new Point(15, 22);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(427, 37);
            txtAra.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(15, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 1);
            panel2.TabIndex = 29;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(56, 71, 120);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(958, 9);
            button2.Name = "button2";
            button2.Size = new Size(383, 63);
            button2.TabIndex = 30;
            button2.Text = "Arama Yap";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(457, 29);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(214, 31);
            checkBox1.TabIndex = 31;
            checkBox1.Text = "İşveren Araması";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(694, 29);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(258, 31);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Gereksinim Araması";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // FrmYayinlanan
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1356, 542);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(txtAra);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmYayinlanan";
            Text = "FrmYayinlanan";
            Load += FrmYayinlanan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private TextBox txtAra;
        private Panel panel2;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}
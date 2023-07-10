namespace BurcHesaplayici
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            dtpTarih = new DateTimePicker();
            button1 = new Button();
            pnlBurc = new Panel();
            btnClose = new Button();
            rtxAciklama = new RichTextBox();
            picResim = new PictureBox();
            lblAd = new Label();
            button2 = new Button();
            button3 = new Button();
            pnlBurc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picResim).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(150, 150);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "Doğum Tarihiniz:";
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(400, 159);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(150, 229);
            button1.Name = "button1";
            button1.Size = new Size(500, 50);
            button1.TabIndex = 2;
            button1.Text = "Burcumu Bul";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnBurcBul_Click;
            // 
            // pnlBurc
            // 
            pnlBurc.Controls.Add(btnClose);
            pnlBurc.Controls.Add(rtxAciklama);
            pnlBurc.Controls.Add(picResim);
            pnlBurc.Controls.Add(lblAd);
            pnlBurc.Controls.Add(button2);
            pnlBurc.Dock = DockStyle.Fill;
            pnlBurc.Location = new Point(0, 0);
            pnlBurc.Name = "pnlBurc";
            pnlBurc.Size = new Size(782, 453);
            pnlBurc.TabIndex = 3;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkGray;
            btnClose.FlatAppearance.BorderColor = Color.DarkGray;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(663, 411);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 30);
            btnClose.TabIndex = 6;
            btnClose.Text = "ÇIKIŞ";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // rtxAciklama
            // 
            rtxAciklama.BackColor = SystemColors.ButtonFace;
            rtxAciklama.BorderStyle = BorderStyle.None;
            rtxAciklama.Location = new Point(380, 100);
            rtxAciklama.Name = "rtxAciklama";
            rtxAciklama.Size = new Size(377, 296);
            rtxAciklama.TabIndex = 5;
            rtxAciklama.Text = "";
            // 
            // picResim
            // 
            picResim.Dock = DockStyle.Left;
            picResim.Location = new Point(0, 0);
            picResim.Name = "picResim";
            picResim.Size = new Size(355, 453);
            picResim.SizeMode = PictureBoxSizeMode.StretchImage;
            picResim.TabIndex = 3;
            picResim.TabStop = false;
            // 
            // lblAd
            // 
            lblAd.BackColor = Color.DarkGray;
            lblAd.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblAd.Location = new Point(355, 0);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(427, 75);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad";
            lblAd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.FlatAppearance.BorderColor = Color.DarkGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(381, 412);
            button2.Name = "button2";
            button2.Size = new Size(94, 30);
            button2.TabIndex = 0;
            button2.Text = "GERİ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnGeri_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(150, 296);
            button3.Name = "button3";
            button3.Size = new Size(500, 50);
            button3.TabIndex = 4;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnClose2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(782, 453);
            Controls.Add(pnlBurc);
            Controls.Add(button1);
            Controls.Add(dtpTarih);
            Controls.Add(label1);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Burç Hesaplayıcı";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            pnlBurc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpTarih;
        private Button button1;
        private Panel pnlBurc;
        private Button button2;
        private Label lblAd;
        private PictureBox picResim;
        private RichTextBox rtxAciklama;
        private Button btnClose;
        private Button button3;
    }
}
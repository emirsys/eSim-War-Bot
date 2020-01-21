namespace eSim_War_Bot
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLSaniye = new System.Windows.Forms.Label();
            this.LBLDakika = new System.Windows.Forms.Label();
            this.LBLSaat = new System.Windows.Forms.Label();
            this.LBLSure = new System.Windows.Forms.Label();
            this.BtnSifirla = new System.Windows.Forms.Button();
            this.BtnBasla = new System.Windows.Forms.Button();
            this.MtbSaat = new System.Windows.Forms.MaskedTextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeside = new System.Windows.Forms.Label();
            this.white_rad = new System.Windows.Forms.RadioButton();
            this.black_rad = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(306, 11);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1056, 579);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open E-Sim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(6, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 170);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PREMIUM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LBLSaniye
            // 
            this.LBLSaniye.AutoSize = true;
            this.LBLSaniye.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLSaniye.Location = new System.Drawing.Point(257, 311);
            this.LBLSaniye.Name = "LBLSaniye";
            this.LBLSaniye.Size = new System.Drawing.Size(42, 15);
            this.LBLSaniye.TabIndex = 34;
            this.LBLSaniye.Text = "SANİYE";
            // 
            // LBLDakika
            // 
            this.LBLDakika.AutoSize = true;
            this.LBLDakika.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLDakika.Location = new System.Drawing.Point(212, 311);
            this.LBLDakika.Name = "LBLDakika";
            this.LBLDakika.Size = new System.Drawing.Size(45, 15);
            this.LBLDakika.TabIndex = 33;
            this.LBLDakika.Text = "DAKİKA";
            // 
            // LBLSaat
            // 
            this.LBLSaat.AutoSize = true;
            this.LBLSaat.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLSaat.Location = new System.Drawing.Point(180, 311);
            this.LBLSaat.Name = "LBLSaat";
            this.LBLSaat.Size = new System.Drawing.Size(32, 15);
            this.LBLSaat.TabIndex = 32;
            this.LBLSaat.Text = "SAAT";
            // 
            // LBLSure
            // 
            this.LBLSure.AutoSize = true;
            this.LBLSure.Font = new System.Drawing.Font("Franklin Gothic Medium", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLSure.Location = new System.Drawing.Point(175, 321);
            this.LBLSure.Name = "LBLSure";
            this.LBLSure.Size = new System.Drawing.Size(125, 36);
            this.LBLSure.TabIndex = 31;
            this.LBLSure.Text = "00:00:00";
            this.LBLSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSifirla
            // 
            this.BtnSifirla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSifirla.Font = new System.Drawing.Font("Franklin Gothic Medium", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSifirla.Location = new System.Drawing.Point(124, 332);
            this.BtnSifirla.Name = "BtnSifirla";
            this.BtnSifirla.Size = new System.Drawing.Size(50, 17);
            this.BtnSifirla.TabIndex = 30;
            this.BtnSifirla.Text = "Sıfırla";
            this.BtnSifirla.UseVisualStyleBackColor = true;
            this.BtnSifirla.Click += new System.EventHandler(this.BtnSifirla_Click);
            // 
            // BtnBasla
            // 
            this.BtnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBasla.Font = new System.Drawing.Font("Franklin Gothic Medium", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBasla.Location = new System.Drawing.Point(124, 312);
            this.BtnBasla.Name = "BtnBasla";
            this.BtnBasla.Size = new System.Drawing.Size(50, 18);
            this.BtnBasla.TabIndex = 29;
            this.BtnBasla.Text = "Başlat";
            this.BtnBasla.UseVisualStyleBackColor = true;
            this.BtnBasla.Click += new System.EventHandler(this.BtnBasla_Click);
            // 
            // MtbSaat
            // 
            this.MtbSaat.Font = new System.Drawing.Font("Franklin Gothic Medium", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MtbSaat.Location = new System.Drawing.Point(7, 313);
            this.MtbSaat.Mask = "00:00:00";
            this.MtbSaat.Name = "MtbSaat";
            this.MtbSaat.Size = new System.Drawing.Size(110, 36);
            this.MtbSaat.TabIndex = 28;
            this.MtbSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 356);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(292, 23);
            this.progressBar1.TabIndex = 35;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 34);
            this.button3.TabIndex = 36;
            this.button3.Text = "oto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(7, 88);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(292, 20);
            this.url.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Savaş Linkini buraya giriniz aksi taktirde çalışmaz!";
            // 
            // changeside
            // 
            this.changeside.AutoSize = true;
            this.changeside.Location = new System.Drawing.Point(242, 576);
            this.changeside.Name = "changeside";
            this.changeside.Size = new System.Drawing.Size(0, 13);
            this.changeside.TabIndex = 40;
            this.changeside.Visible = false;
            // 
            // white_rad
            // 
            this.white_rad.AutoSize = true;
            this.white_rad.Location = new System.Drawing.Point(96, 290);
            this.white_rad.Name = "white_rad";
            this.white_rad.Size = new System.Drawing.Size(77, 17);
            this.white_rad.TabIndex = 41;
            this.white_rad.TabStop = true;
            this.white_rad.Text = "White Side";
            this.white_rad.UseVisualStyleBackColor = true;
            this.white_rad.CheckedChanged += new System.EventHandler(this.white_rad_CheckedChanged);
            // 
            // black_rad
            // 
            this.black_rad.AutoSize = true;
            this.black_rad.Location = new System.Drawing.Point(14, 290);
            this.black_rad.Name = "black_rad";
            this.black_rad.Size = new System.Drawing.Size(76, 17);
            this.black_rad.TabIndex = 42;
            this.black_rad.TabStop = true;
            this.black_rad.Text = "Black Side";
            this.black_rad.UseVisualStyleBackColor = true;
            this.black_rad.CheckedChanged += new System.EventHandler(this.black_rad_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 539);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 34);
            this.button4.TabIndex = 43;
            this.button4.Text = "vur";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1364, 591);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.black_rad);
            this.Controls.Add(this.white_rad);
            this.Controls.Add(this.changeside);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.url);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.LBLSaniye);
            this.Controls.Add(this.LBLDakika);
            this.Controls.Add(this.LBLSaat);
            this.Controls.Add(this.LBLSure);
            this.Controls.Add(this.BtnSifirla);
            this.Controls.Add(this.BtnBasla);
            this.Controls.Add(this.MtbSaat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eSim War Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLSaniye;
        private System.Windows.Forms.Label LBLDakika;
        private System.Windows.Forms.Label LBLSaat;
        private System.Windows.Forms.Label LBLSure;
        private System.Windows.Forms.Button BtnSifirla;
        private System.Windows.Forms.Button BtnBasla;
        private System.Windows.Forms.MaskedTextBox MtbSaat;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label changeside;
        private System.Windows.Forms.RadioButton white_rad;
        private System.Windows.Forms.RadioButton black_rad;
        private System.Windows.Forms.Button button4;
    }
}



namespace Calculator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dortbtn = new System.Windows.Forms.Button();
            this.sıfırbtn = new System.Windows.Forms.Button();
            this.artıbtn = new System.Windows.Forms.Button();
            this.bölübtn = new System.Windows.Forms.Button();
            this.carpibtn = new System.Windows.Forms.Button();
            this.virgülbtn = new System.Windows.Forms.Button();
            this.esittirbtn = new System.Windows.Forms.Button();
            this.ucbtn = new System.Windows.Forms.Button();
            this.ikibtn = new System.Windows.Forms.Button();
            this.birbtn = new System.Windows.Forms.Button();
            this.besbtn = new System.Windows.Forms.Button();
            this.altibtn = new System.Windows.Forms.Button();
            this.eksibtn = new System.Windows.Forms.Button();
            this.yedibtn = new System.Windows.Forms.Button();
            this.sekizbtn = new System.Windows.Forms.Button();
            this.dokuzbtn = new System.Windows.Forms.Button();
            this.negbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.geribtn = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.CEbtn = new System.Windows.Forms.Button();
            this.islem = new System.Windows.Forms.TextBox();
            this.Sonuc = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Sonuc);
            this.panel1.Controls.Add(this.islem);
            this.panel1.Controls.Add(this.CEbtn);
            this.panel1.Controls.Add(this.Cbtn);
            this.panel1.Controls.Add(this.geribtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dortbtn);
            this.panel1.Controls.Add(this.sıfırbtn);
            this.panel1.Controls.Add(this.artıbtn);
            this.panel1.Controls.Add(this.bölübtn);
            this.panel1.Controls.Add(this.carpibtn);
            this.panel1.Controls.Add(this.virgülbtn);
            this.panel1.Controls.Add(this.esittirbtn);
            this.panel1.Controls.Add(this.ucbtn);
            this.panel1.Controls.Add(this.ikibtn);
            this.panel1.Controls.Add(this.birbtn);
            this.panel1.Controls.Add(this.besbtn);
            this.panel1.Controls.Add(this.altibtn);
            this.panel1.Controls.Add(this.eksibtn);
            this.panel1.Controls.Add(this.yedibtn);
            this.panel1.Controls.Add(this.sekizbtn);
            this.panel1.Controls.Add(this.dokuzbtn);
            this.panel1.Controls.Add(this.negbtn);
            this.panel1.Location = new System.Drawing.Point(168, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 413);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dortbtn
            // 
            this.dortbtn.Location = new System.Drawing.Point(13, 232);
            this.dortbtn.Name = "dortbtn";
            this.dortbtn.Size = new System.Drawing.Size(57, 52);
            this.dortbtn.TabIndex = 33;
            this.dortbtn.Text = "4";
            this.dortbtn.UseVisualStyleBackColor = true;
            this.dortbtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // sıfırbtn
            // 
            this.sıfırbtn.Location = new System.Drawing.Point(76, 350);
            this.sıfırbtn.Name = "sıfırbtn";
            this.sıfırbtn.Size = new System.Drawing.Size(57, 52);
            this.sıfırbtn.TabIndex = 32;
            this.sıfırbtn.Text = "0";
            this.sıfırbtn.UseVisualStyleBackColor = true;
            this.sıfırbtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // artıbtn
            // 
            this.artıbtn.Location = new System.Drawing.Point(202, 290);
            this.artıbtn.Name = "artıbtn";
            this.artıbtn.Size = new System.Drawing.Size(57, 52);
            this.artıbtn.TabIndex = 31;
            this.artıbtn.Text = "+";
            this.artıbtn.UseVisualStyleBackColor = true;
            this.artıbtn.Click += new System.EventHandler(this.Islem);
            // 
            // bölübtn
            // 
            this.bölübtn.Location = new System.Drawing.Point(202, 116);
            this.bölübtn.Name = "bölübtn";
            this.bölübtn.Size = new System.Drawing.Size(57, 52);
            this.bölübtn.TabIndex = 30;
            this.bölübtn.Text = "/";
            this.bölübtn.UseVisualStyleBackColor = true;
            this.bölübtn.Click += new System.EventHandler(this.Islem);
            // 
            // carpibtn
            // 
            this.carpibtn.Location = new System.Drawing.Point(202, 174);
            this.carpibtn.Name = "carpibtn";
            this.carpibtn.Size = new System.Drawing.Size(57, 52);
            this.carpibtn.TabIndex = 29;
            this.carpibtn.Text = "x";
            this.carpibtn.UseVisualStyleBackColor = true;
            this.carpibtn.Click += new System.EventHandler(this.Islem);
            // 
            // virgülbtn
            // 
            this.virgülbtn.Location = new System.Drawing.Point(139, 350);
            this.virgülbtn.Name = "virgülbtn";
            this.virgülbtn.Size = new System.Drawing.Size(57, 52);
            this.virgülbtn.TabIndex = 28;
            this.virgülbtn.Text = ",";
            this.virgülbtn.UseVisualStyleBackColor = true;
            this.virgülbtn.Click += new System.EventHandler(this.Islem);
            // 
            // esittirbtn
            // 
            this.esittirbtn.Location = new System.Drawing.Point(202, 350);
            this.esittirbtn.Name = "esittirbtn";
            this.esittirbtn.Size = new System.Drawing.Size(57, 52);
            this.esittirbtn.TabIndex = 27;
            this.esittirbtn.Text = "=";
            this.esittirbtn.UseVisualStyleBackColor = true;
            this.esittirbtn.Click += new System.EventHandler(this.Islem);
            // 
            // ucbtn
            // 
            this.ucbtn.Location = new System.Drawing.Point(139, 290);
            this.ucbtn.Name = "ucbtn";
            this.ucbtn.Size = new System.Drawing.Size(57, 52);
            this.ucbtn.TabIndex = 26;
            this.ucbtn.Text = "3";
            this.ucbtn.UseVisualStyleBackColor = true;
            this.ucbtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // ikibtn
            // 
            this.ikibtn.Location = new System.Drawing.Point(76, 290);
            this.ikibtn.Name = "ikibtn";
            this.ikibtn.Size = new System.Drawing.Size(57, 52);
            this.ikibtn.TabIndex = 25;
            this.ikibtn.Text = "2";
            this.ikibtn.UseVisualStyleBackColor = true;
            this.ikibtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // birbtn
            // 
            this.birbtn.Location = new System.Drawing.Point(13, 290);
            this.birbtn.Name = "birbtn";
            this.birbtn.Size = new System.Drawing.Size(57, 52);
            this.birbtn.TabIndex = 24;
            this.birbtn.Text = "1";
            this.birbtn.UseVisualStyleBackColor = true;
            this.birbtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // besbtn
            // 
            this.besbtn.Location = new System.Drawing.Point(76, 232);
            this.besbtn.Name = "besbtn";
            this.besbtn.Size = new System.Drawing.Size(57, 52);
            this.besbtn.TabIndex = 23;
            this.besbtn.Text = "5";
            this.besbtn.UseVisualStyleBackColor = true;
            this.besbtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // altibtn
            // 
            this.altibtn.Location = new System.Drawing.Point(139, 232);
            this.altibtn.Name = "altibtn";
            this.altibtn.Size = new System.Drawing.Size(57, 52);
            this.altibtn.TabIndex = 22;
            this.altibtn.Text = "6";
            this.altibtn.UseVisualStyleBackColor = true;
            this.altibtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // eksibtn
            // 
            this.eksibtn.Location = new System.Drawing.Point(202, 232);
            this.eksibtn.Name = "eksibtn";
            this.eksibtn.Size = new System.Drawing.Size(57, 52);
            this.eksibtn.TabIndex = 21;
            this.eksibtn.Text = "-";
            this.eksibtn.UseVisualStyleBackColor = true;
            this.eksibtn.Click += new System.EventHandler(this.Islem);
            // 
            // yedibtn
            // 
            this.yedibtn.Location = new System.Drawing.Point(13, 174);
            this.yedibtn.Name = "yedibtn";
            this.yedibtn.Size = new System.Drawing.Size(57, 52);
            this.yedibtn.TabIndex = 20;
            this.yedibtn.Text = "7";
            this.yedibtn.UseVisualStyleBackColor = true;
            this.yedibtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // sekizbtn
            // 
            this.sekizbtn.Location = new System.Drawing.Point(76, 174);
            this.sekizbtn.Name = "sekizbtn";
            this.sekizbtn.Size = new System.Drawing.Size(57, 52);
            this.sekizbtn.TabIndex = 19;
            this.sekizbtn.Text = "8";
            this.sekizbtn.UseVisualStyleBackColor = true;
            this.sekizbtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // dokuzbtn
            // 
            this.dokuzbtn.Location = new System.Drawing.Point(139, 174);
            this.dokuzbtn.Name = "dokuzbtn";
            this.dokuzbtn.Size = new System.Drawing.Size(57, 52);
            this.dokuzbtn.TabIndex = 18;
            this.dokuzbtn.Text = "9";
            this.dokuzbtn.UseVisualStyleBackColor = true;
            this.dokuzbtn.Click += new System.EventHandler(this.rakamlar);
            // 
            // negbtn
            // 
            this.negbtn.Location = new System.Drawing.Point(13, 350);
            this.negbtn.Name = "negbtn";
            this.negbtn.Size = new System.Drawing.Size(57, 52);
            this.negbtn.TabIndex = 17;
            this.negbtn.Text = "+/-";
            this.negbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 93);
            this.textBox1.TabIndex = 34;
            // 
            // geribtn
            // 
            this.geribtn.Location = new System.Drawing.Point(139, 116);
            this.geribtn.Name = "geribtn";
            this.geribtn.Size = new System.Drawing.Size(57, 52);
            this.geribtn.TabIndex = 35;
            this.geribtn.Text = "<--";
            this.geribtn.UseVisualStyleBackColor = true;
            // 
            // Cbtn
            // 
            this.Cbtn.Location = new System.Drawing.Point(76, 116);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(57, 52);
            this.Cbtn.TabIndex = 36;
            this.Cbtn.Text = "C";
            this.Cbtn.UseVisualStyleBackColor = true;
            // 
            // CEbtn
            // 
            this.CEbtn.Location = new System.Drawing.Point(13, 116);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(57, 52);
            this.CEbtn.TabIndex = 37;
            this.CEbtn.Text = "CE";
            this.CEbtn.UseVisualStyleBackColor = true;
            // 
            // islem
            // 
            this.islem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islem.ForeColor = System.Drawing.Color.Gray;
            this.islem.Location = new System.Drawing.Point(23, 29);
            this.islem.Multiline = true;
            this.islem.Name = "islem";
            this.islem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.islem.Size = new System.Drawing.Size(226, 31);
            this.islem.TabIndex = 18;
            // 
            // Sonuc
            // 
            this.Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sonuc.Location = new System.Drawing.Point(23, 66);
            this.Sonuc.Multiline = true;
            this.Sonuc.Name = "Sonuc";
            this.Sonuc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sonuc.Size = new System.Drawing.Size(226, 31);
            this.Sonuc.TabIndex = 38;
            this.Sonuc.Text = "0";
            this.Sonuc.TextChanged += new System.EventHandler(this.Sonuc_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 555);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button dortbtn;
        private System.Windows.Forms.Button sıfırbtn;
        private System.Windows.Forms.Button artıbtn;
        private System.Windows.Forms.Button bölübtn;
        private System.Windows.Forms.Button carpibtn;
        private System.Windows.Forms.Button virgülbtn;
        private System.Windows.Forms.Button esittirbtn;
        private System.Windows.Forms.Button ucbtn;
        private System.Windows.Forms.Button ikibtn;
        private System.Windows.Forms.Button birbtn;
        private System.Windows.Forms.Button besbtn;
        private System.Windows.Forms.Button altibtn;
        private System.Windows.Forms.Button eksibtn;
        private System.Windows.Forms.Button yedibtn;
        private System.Windows.Forms.Button sekizbtn;
        private System.Windows.Forms.Button dokuzbtn;
        private System.Windows.Forms.Button negbtn;
        private System.Windows.Forms.Button CEbtn;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button geribtn;
        private System.Windows.Forms.TextBox Sonuc;
        private System.Windows.Forms.TextBox islem;
    }
}


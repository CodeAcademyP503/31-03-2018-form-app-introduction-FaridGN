namespace Cinema
{
    partial class Checkout
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
            this.lab1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.kino = new System.Windows.Forms.Label();
            this.Quit = new System.Windows.Forms.Button();
            this.saat = new System.Windows.Forms.Label();
            this.yer = new System.Windows.Forms.Label();
            this.manat = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(27, 20);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(35, 13);
            this.lab1.TabIndex = 1;
            this.lab1.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(119, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(125, 20);
            this.NameBox.TabIndex = 2;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(27, 72);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(49, 13);
            this.lab2.TabIndex = 3;
            this.lab2.Text = "Surname";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(119, 72);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(125, 20);
            this.SurnameBox.TabIndex = 4;
            // 
            // kino
            // 
            this.kino.AutoSize = true;
            this.kino.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kino.Location = new System.Drawing.Point(26, 198);
            this.kino.Name = "kino";
            this.kino.Size = new System.Drawing.Size(25, 13);
            this.kino.TabIndex = 5;
            this.kino.Text = "Film";
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(130, 108);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 6;
            this.Quit.Text = "Check now";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saat.Location = new System.Drawing.Point(21, 224);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(37, 13);
            this.saat.TabIndex = 7;
            this.saat.Text = "Seans";
            // 
            // yer
            // 
            this.yer.AutoSize = true;
            this.yer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yer.Location = new System.Drawing.Point(21, 250);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(34, 13);
            this.yer.TabIndex = 8;
            this.yer.Text = "Yerler";
            // 
            // manat
            // 
            this.manat.AutoSize = true;
            this.manat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manat.Location = new System.Drawing.Point(21, 278);
            this.manat.Name = "manat";
            this.manat.Size = new System.Drawing.Size(42, 13);
            this.manat.TabIndex = 9;
            this.manat.Text = "Mebleg";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ad.Location = new System.Drawing.Point(26, 146);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(20, 13);
            this.ad.TabIndex = 10;
            this.ad.Text = "Ad";
            // 
            // soyad
            // 
            this.soyad.AutoSize = true;
            this.soyad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.soyad.Location = new System.Drawing.Point(21, 171);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(37, 13);
            this.soyad.TabIndex = 11;
            this.soyad.Text = "Soyad";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 300);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.manat);
            this.Controls.Add(this.yer);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.kino);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.lab1);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label kino;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Label yer;
        private System.Windows.Forms.Label manat;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.Label soyad;
    }
}
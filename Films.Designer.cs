namespace Cinema
{
    partial class Films
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Films));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bat = new System.Windows.Forms.Button();
            this.harry = new System.Windows.Forms.PictureBox();
            this.potter = new System.Windows.Forms.Button();
            this.juras = new System.Windows.Forms.PictureBox();
            this.jurassic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juras)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bat
            // 
            this.bat.Location = new System.Drawing.Point(38, 201);
            this.bat.Name = "bat";
            this.bat.Size = new System.Drawing.Size(75, 23);
            this.bat.TabIndex = 1;
            this.bat.Text = "Batman";
            this.bat.UseVisualStyleBackColor = true;
            // 
            // harry
            // 
            this.harry.Image = ((System.Drawing.Image)(resources.GetObject("harry.Image")));
            this.harry.Location = new System.Drawing.Point(157, 44);
            this.harry.Name = "harry";
            this.harry.Size = new System.Drawing.Size(100, 138);
            this.harry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.harry.TabIndex = 2;
            this.harry.TabStop = false;
            // 
            // potter
            // 
            this.potter.Location = new System.Drawing.Point(157, 201);
            this.potter.Name = "potter";
            this.potter.Size = new System.Drawing.Size(75, 23);
            this.potter.TabIndex = 3;
            this.potter.Text = "Harry Potter";
            this.potter.UseVisualStyleBackColor = true;
            // 
            // juras
            // 
            this.juras.Image = ((System.Drawing.Image)(resources.GetObject("juras.Image")));
            this.juras.Location = new System.Drawing.Point(280, 44);
            this.juras.Name = "juras";
            this.juras.Size = new System.Drawing.Size(100, 138);
            this.juras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.juras.TabIndex = 4;
            this.juras.TabStop = false;
            // 
            // jurassic
            // 
            this.jurassic.Location = new System.Drawing.Point(289, 201);
            this.jurassic.Name = "jurassic";
            this.jurassic.Size = new System.Drawing.Size(91, 23);
            this.jurassic.TabIndex = 5;
            this.jurassic.Text = "Jurassic World";
            this.jurassic.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose film";
            // 
            // Films
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jurassic);
            this.Controls.Add(this.juras);
            this.Controls.Add(this.potter);
            this.Controls.Add(this.harry);
            this.Controls.Add(this.bat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Films";
            this.Text = "Films";
            this.Load += new System.EventHandler(this.Films_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bat;
        private System.Windows.Forms.PictureBox harry;
        private System.Windows.Forms.Button potter;
        private System.Windows.Forms.PictureBox juras;
        private System.Windows.Forms.Button jurassic;
        private System.Windows.Forms.Label label1;
    }
}
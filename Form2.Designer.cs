namespace Cinema
{
    partial class zallar
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
            this.zal1 = new System.Windows.Forms.Button();
            this.zal2 = new System.Windows.Forms.Button();
            this.zal3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zal1
            // 
            this.zal1.Location = new System.Drawing.Point(129, 50);
            this.zal1.Name = "zal1";
            this.zal1.Size = new System.Drawing.Size(75, 23);
            this.zal1.TabIndex = 0;
            this.zal1.Text = "Zal1";
            this.zal1.UseVisualStyleBackColor = true;
            this.zal1.Click += new System.EventHandler(this.enterzal1);
            // 
            // zal2
            // 
            this.zal2.Location = new System.Drawing.Point(129, 117);
            this.zal2.Name = "zal2";
            this.zal2.Size = new System.Drawing.Size(75, 23);
            this.zal2.TabIndex = 1;
            this.zal2.Text = "Zal2";
            this.zal2.UseVisualStyleBackColor = true;
            this.zal2.Click += new System.EventHandler(this.enterzal2);
            // 
            // zal3
            // 
            this.zal3.Location = new System.Drawing.Point(129, 178);
            this.zal3.Name = "zal3";
            this.zal3.Size = new System.Drawing.Size(75, 23);
            this.zal3.TabIndex = 2;
            this.zal3.Text = "Zal3";
            this.zal3.UseVisualStyleBackColor = true;
            this.zal3.Click += new System.EventHandler(this.enterzal3);
            // 
            // zallar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 275);
            this.Controls.Add(this.zal3);
            this.Controls.Add(this.zal2);
            this.Controls.Add(this.zal1);
            this.Name = "zallar";
            this.Text = "Zallar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zal1;
        private System.Windows.Forms.Button zal2;
        private System.Windows.Forms.Button zal3;
    }
}
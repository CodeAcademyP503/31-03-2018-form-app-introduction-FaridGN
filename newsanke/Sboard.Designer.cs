namespace mysnake
{
    partial class Sboard
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
            this.snake = new System.Windows.Forms.Button();
            this.food = new System.Windows.Forms.Button();
            this.myboard = new System.Windows.Forms.PictureBox();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myboard)).BeginInit();
            this.SuspendLayout();
            // 
            // snake
            // 
            this.snake.Location = new System.Drawing.Point(0, 0);
            this.snake.Name = "snake";
            this.snake.Size = new System.Drawing.Size(20, 20);
            this.snake.TabIndex = 0;
            this.snake.Text = "S";
            this.snake.UseVisualStyleBackColor = true;
            // 
            // food
            // 
            this.food.Location = new System.Drawing.Point(60, 60);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(20, 20);
            this.food.TabIndex = 1;
            this.food.Text = "F";
            this.food.UseVisualStyleBackColor = true;
            // 
            // myboard
            // 
            this.myboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.myboard.Location = new System.Drawing.Point(0, 0);
            this.myboard.Name = "myboard";
            this.myboard.Size = new System.Drawing.Size(320, 320);
            this.myboard.TabIndex = 2;
            this.myboard.TabStop = false;
            this.myboard.Visible = false;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(326, 319);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(40, 23);
            this.left.TabIndex = 3;
            this.left.Text = "Left";
            this.left.UseVisualStyleBackColor = true;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(408, 319);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(40, 23);
            this.right.TabIndex = 4;
            this.right.Text = "Right";
            this.right.UseVisualStyleBackColor = true;
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(364, 348);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(44, 23);
            this.down.TabIndex = 5;
            this.down.Text = "Down";
            this.down.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(364, 290);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(44, 23);
            this.up.TabIndex = 6;
            this.up.Text = "Up";
            this.up.UseVisualStyleBackColor = true;
            // 
            // Sboard
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(475, 402);
            this.Controls.Add(this.up);
            this.Controls.Add(this.down);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.snake);
            this.Controls.Add(this.food);
            this.Controls.Add(this.myboard);
            this.Name = "Sboard";
            ((System.ComponentModel.ISupportInitialize)(this.myboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button snake;
        private System.Windows.Forms.Button food;
        private System.Windows.Forms.PictureBox myboard;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button up;
    }
}
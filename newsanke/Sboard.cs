using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysnake
{
    public partial class Sboard : Form
    {
        public int LeftPos = 0;
        public int TopPos = 0;
        public List<Button> slist = new List<Button>();
        public Sboard()
        {
            InitializeComponent();
            myboard.Width = 320;
            myboard.Height = 320;

            snake.Height = 20;
            snake.Width = 20;
            food.Width = 20;
            food.Height = 20;
            snake.Left = LeftPos;
            snake.Top = TopPos;
            slist.Add(snake);

            Controls.Add(snake);
            Controls.Add(left);
            Controls.Add(right);
            Controls.Add(up);
            Controls.Add(down);
            Controls.Add(food);
            food.BringToFront();
            snake.BringToFront();

           

            left.Click += new EventHandler(Moveleft);
            right.Click += new EventHandler(Moveright);
            up.Click += new EventHandler(Moveup);
            down.Click += new EventHandler(Movedown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Moveleft(object sender, EventArgs e)
        {


            snake.Left -= snake.Width;

            if (snake.Left < 0)
            {
                snake.Left = myboard.Width - snake.Width;
            }
            for (int i = slist.Count-1; i > 0; i--)
            {
                slist[i].Left = slist[i - 1].Left + 20;
                slist[i].Top = slist[i - 1].Top;
                if (i >= 2)
                {
                    slist[i].Left = slist[i - 1].Left;
                    slist[i].Top = slist[i - 1].Top;
                }
            }

            if (snake.Location == food.Location)
            {
                Eat();
            }
        }


        private void Moveup(object sender, EventArgs e)
        {
            snake.Top -= snake.Height;

            if (snake.Top < 0)
            {
                snake.Top = myboard.Height - snake.Height;
            }
            for (int i = slist.Count - 1; i > 0; i--)
            {
                slist[i].Left = slist[i - 1].Left + 20;
                slist[i].Top = slist[i - 1].Top;
                if (i >= 2)
                {
                    slist[i].Left = slist[i - 1].Left;
                    slist[i].Top = slist[i - 1].Top;
                }
            }

            if (snake.Location == food.Location)
            {
                Eat();
            }
        }

        private void Movedown(object sender, EventArgs e)
        {
            snake.Top += snake.Height;

            if (snake.Top > myboard.Height - snake.Height - 20)
            {
                snake.Top = -snake.Height;
            }
            for (int i = slist.Count - 1; i > 0; i--)
            {
                slist[i].Left = slist[i - 1].Left + 20;
                slist[i].Top = slist[i - 1].Top;
                if (i >= 2)
                {
                    slist[i].Left = slist[i - 1].Left;
                    slist[i].Top = slist[i - 1].Top;
                }
            }

            if (snake.Location == food.Location)
            {
                Eat();
            }
        }

        private void Moveright(object sender, EventArgs e)
        {
            snake.Left += snake.Width;

            if (snake.Left > myboard.Width - snake.Width - 20)
            {
                snake.Left = -snake.Width;
            }
            for (int i = slist.Count - 1; i > 0; i--)
            {
                slist[i].Left = slist[i - 1].Left + 20;
                slist[i].Top = slist[i - 1].Top;
                if (i >= 2)
                {
                    slist[i].Left = slist[i - 1].Left;
                    slist[i].Top = slist[i - 1].Top;
                }
            }

            if (snake.Location == food.Location)
            {
                Eat();
            }
        }


        public void Generatefood()
        {
            int maxLeftPos = myboard.Width - food.Width;
            int maxTopPos = myboard.Height - food.Height; 
            Random rand = new Random();  
            Button body = new Button();
            body.Left = rand.Next(0, maxLeftPos);
            body.Top = rand.Next(0, maxTopPos); 
            body.Width = snake.Width;
            body.Height = snake.Height;
            body.BringToFront();
            slist.Add(body);
            Controls.Add(body);
        }
        public void Eat()
        {
            Controls.Remove(food); 
            Generatefood();  
        } 
    }
}

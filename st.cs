using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class st : Form
    {
        public int RowCount = 5;
        public int ColumnCount = 6;
        public int LeftPos = 60;
        public int TopPos = 0;
        public int SeatNumber = 1;
        public TextBox Result = new TextBox();
        public Button ReservBtn = new Button();
        public static List<Button> seanslar = new List<Button>();
        public static List<Button> seats = new List<Button>();
        public Button seans1 = new Button();
        public Button seans2 = new Button();
        public Button seans3 = new Button();
        public static List<Button> ReservedSeats = new List<Button>();

        public st()
        {
            InitializeComponent();

            for (int row = 0; row < RowCount; row++)
            {
                for (int column = 0; column < ColumnCount; column++)
                {
                    var seat = new Button();
                    seat.BackColor =Color.Gray;
                    seat.FlatAppearance.BorderSize = 1;
                    seat.Width = 50;
                    seat.Height = 50;
                    seat.Top = TopPos;
                    seat.Text = SeatNumber.ToString();
                    SeatNumber++;
                    seat.Click += new EventHandler(SelectSeats);
                    LeftPos += 50;
                    if (row == 0)
                    {
                        ColumnCount = 5;
                        seat.Left = LeftPos;
                        Controls.Add(seat);
                    }
                    else if (row == 1)
                    {
                        ColumnCount = 6;
                        seat.Left = LeftPos - 25;
                        Controls.Add(seat);
                    }
                    else if (row == 2)
                    {
                        ColumnCount = 7;
                        seat.Left = LeftPos - 50;
                        Controls.Add(seat);
                    }
                    else if (row == 3)
                    {
                        ColumnCount = 8;
                        seat.Left = LeftPos - 75;
                        Controls.Add(seat);
                    }
                    else
                    {
                        ColumnCount = 9;
                        seat.Left = LeftPos - 100;
                        Controls.Add(seat);
                    }
                }
                LeftPos = 60;
                TopPos += 50;

            }
            this.Width = ColumnCount * 50 + 35;
            this.Height = RowCount * 50 + 150;
            ReservBtn.Text = "Reserve";
            ReservBtn.AutoSize = true;
            ReservBtn.Click += new EventHandler(ReserveSeats);
            Controls.Add(ReservBtn);
            ReservBtn.Top = this.Height - ReservBtn.Height - 35;
            ReservBtn.Left = this.Width - ReservBtn.Width - 250;

            seans1.Text = "saat 12:00";
            seans1.AutoSize = true;
            seans1.Click += new EventHandler(Selectseans);
            Controls.Add(seans1);
            seans1.Top = this.Height - seans1.Height - 95;
            seans1.Left = this.Width - seans1.Width - 350;

            seans2.Text = "saat 14:00";
            seans2.AutoSize = true;
            seans2.Click += new EventHandler(Selectseans2);
            Controls.Add(seans2);
            seans2.Top = this.Height - seans1.Height - 95;
            seans2.Left = this.Width - seans1.Width - 200;

            seans3.Text = "saat 18:00";
            seans3.AutoSize = true;
            seans3.Click += new EventHandler(Selectseans3);
            Controls.Add(seans3);
            seans3.Top = this.Height - seans1.Height - 95;
            seans3.Left = this.Width - seans1.Width - 50;


        }

        public void SelectSeats(object obj, EventArgs e)
    {
        var btn = obj as Button;
        btn.BackColor = Color.Red;
        ReservedSeats.Add(btn);
            seats.Add(btn);


    }
        public void Selectseans(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Blue;
            seanslar.Add(btn);

        }

        public void Selectseans2(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Blue;
            seanslar.Add(btn);
        }

        public void Selectseans3(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Blue;
            seanslar.Add(btn);

        }

        public void ReserveSeats(object obj, EventArgs e)
        {
            foreach (Button item in ReservedSeats)
            {
                item.Enabled = false;
            }
            var checkOutForm = new Checkout();
            checkOutForm.Show();
        }

        private void st_Load(object sender, EventArgs e)
        {

        }
    }
}

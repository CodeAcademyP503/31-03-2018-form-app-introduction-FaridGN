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
        public int LeftPos = 0;
        public int TopPos = 0;
        public int SeatNumber = 1;
        public TextBox Result = new TextBox();
        public Button ReservBtn = new Button();
        public Button seans1 = new Button();
        public Button seans2 = new Button();
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
                    seat.BackgroundImageLayout = ImageLayout.Stretch;
                    seat.FlatStyle = FlatStyle.Flat;
                    seat.FlatAppearance.BorderSize = 0;
                    seat.Width = 50;
                    seat.Height = 50;
                    seat.Left = LeftPos;
                    seat.Top = TopPos;
                    seat.Text = SeatNumber.ToString();
                    SeatNumber++;
                    Controls.Add(seat);
                    seat.Click += new EventHandler(SelectSeats);
                    LeftPos += 50;
                }
                LeftPos = 0;
                TopPos += 50;

            }
            this.Width = ColumnCount * 50 + 17;
            this.Height = RowCount * 50 + 100;
            ReservBtn.Text = "Reserve";
            ReservBtn.AutoSize = true;
            ReservBtn.Click += new EventHandler(ReserveSeats);
            Controls.Add(ReservBtn);
            ReservBtn.Top = this.Height - ReservBtn.Height - 35;
            ReservBtn.Left = this.Width - ReservBtn.Width - 250;

            seans1.Text = "seans 12:00";
            seans1.AutoSize = true;
            seans1.Click += new EventHandler(Selectseans);
            Controls.Add(seans1);
            seans1.Top = this.Height - seans1.Height - 65;
            seans1.Left = this.Width - seans1.Width - 200;

            seans2.Text = "seans 14:00";
            seans2.AutoSize = true;
            seans2.Click += new EventHandler(Selectseans2);
            Controls.Add(seans2);
            seans2.Top = this.Height - seans1.Height - 65;
            seans2.Left = this.Width - seans1.Width - 100;

        }

    public void SelectSeats(object obj, EventArgs e)
    {
        var btn = obj as Button;
        btn.BackColor = Color.Red;
        ReservedSeats.Add(btn);


    }
        public void Selectseans(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Blue;
            ReservedSeats.Add(btn);

        }

        public void Selectseans2(object obj, EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Blue;
            ReservedSeats.Add(btn);

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

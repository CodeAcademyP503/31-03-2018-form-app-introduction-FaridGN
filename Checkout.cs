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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
            Quit.Click += new EventHandler(Quit_Click);
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            ad.Text += ": " + NameBox.Text;
            soyad.Text += ": " + SurnameBox.Text;

            foreach (Button item in Films.movie)
            {
                kino.Text += ": " + item.Text;
            }
            foreach (Button item in st.seanslar)
            {
                saat.Text += ": " + item.Text;
            }
            foreach (Button item in st.seats)
            {
                yer.Text += ": " + item.Text;
            }
            manat.Text += ": " + st.ReservedSeats.Count * 7 + " " + "AZN";
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}

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
            foreach (Button item in st.ReservedSeats)
            {
                Selected.Text += item.Text + " ,";
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            var result = " "+ NameBox.Text + " " + SurnameBox.Text + ". Siz " + "uygun olaraq"+ Selected.Text + " filmini, yerleri ve seansi reserv etmisiniz ve odeyeceyiniz mebleg " + st.ReservedSeats.Count * 7 + " AZN-dir.";
            Netice.Text += result;
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}

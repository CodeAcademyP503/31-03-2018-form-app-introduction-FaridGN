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
    public partial class Films : Form
    {
        public static List<Button> movie = new List<Button>();
        public Films()
        {
            InitializeComponent();
            bat.Click += new EventHandler(Startbatman);
            potter.Click += new EventHandler(HarryPotter);
            jurassic.Click += new EventHandler(JurassicWorld);
        }

        private void Startbatman(object sender, EventArgs e)
        {
            bat.BackColor = Color.Yellow;
            movie.Add(bat);
            var Zallist = new zallar();
            Zallist.Show();
        }

        private void HarryPotter(object sender, EventArgs e)
        {
            potter.BackColor = Color.Yellow;
            movie.Add(potter);
            var Zallist = new zallar();
            Zallist.Show();
        }

        private void JurassicWorld(object sender, EventArgs e)
        {
            jurassic.BackColor = Color.Yellow;
            movie.Add(jurassic);
            var Zallist = new zallar();
            Zallist.Show();
        }

        private void Films_Load(object sender, EventArgs e)
        {

        }
    }
}

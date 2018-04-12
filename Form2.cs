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
    public partial class zallar : Form
    { 
        public zallar()
        {
            InitializeComponent();
        }

        private void enterzal1(object sender, EventArgs e)
        {
            var stForm = new st();
            stForm.Show();
        }

        private void enterzal2(object sender, EventArgs e)
        {
            var stForm = new st();
            stForm.Show();
        }

        private void enterzal3(object sender, EventArgs e)
        {
            var stForm = new st();
            stForm.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace irgendeinTollesSpiel
{
    public partial class startseite : Form
    {
        public startseite()
        {
            InitializeComponent();
        }

        private void play_Click(object sender, EventArgs e)
        {
            game gameWindow = new game();
            gameWindow.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace minesSweeperGame
{
    public partial class minePiesa : UserControl
    {
        public minePiesa()
        {
            InitializeComponent();
        }

        private void minePiesa_Load(object sender, EventArgs e)
        {

        }

        private void minePiesa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackColor = Color.Black;
            }
            else if (e.Button == MouseButtons.Right)
            {
                BackColor = Color.Red;
            }
        }
    }
}

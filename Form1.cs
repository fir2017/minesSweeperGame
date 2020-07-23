using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace minesSweeperGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public minePiesa[,] MatriceMine = new minePiesa[30, 30];
        public int[,] valueofminesMatrix = new int[30, 30];

        public void addtoform()
        {
            int k = Controls.Count - 1;
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    k++;
                    Controls.Add(new minePiesa());
                    Controls[k].Left = (j * 12) + 50;    // j = (((j*12)+50) - 50)/12
                    Controls[k].Top = (i * 12) + 50;     // i = (((i*12)+50) - 50)/12 
                    Controls[k].Show();



                }
            }
        }


        //verifiy if is rightmousebutton or leftmousebutton pressed
        //if is leftmousebutton pressed then
        // onmineClicked verify if mine is mine or hole in valueofminesMatrix
            //if ismine then show all mine and gameover
            //else if ishole then find all the holes locatedin vecinity of hole and show all and add points
        //else
        //if is rightmousebutton pressed then
        //put a flag
        //


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addtoform();
        }
    }
}

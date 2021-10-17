using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            Button[,] btns = new Button[8, 8];
            int yukseklik = 0;
            int uzaklik = 0;

            for (int i = 0; i < btns.GetUpperBound(0); i++)
            {
                for (int j = 0; j < btns.GetUpperBound(1); j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Width = 60;
                    btns[i, j].Height = 60;
                    btns[i, j].Top = yukseklik;
                    btns[i, j].Left = uzaklik;
                    this.Controls.Add(btns[i, j]);
                    uzaklik += 60;

                    if ((i + j) % 2 == 0)
                    {
                        btns[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        btns[i, j].BackColor = Color.Black;
                    }

                }
                uzaklik = 0;
                yukseklik += 60;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
            
        private void rakamlar(object sender, EventArgs e)
        {
            if (Sonuc.Text == "0")
                Sonuc.Clear();

            Button btn = (Button)sender;
            Sonuc.Text += btn.Text;
                
        }
            
        private void Sonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Islem(object sender, EventArgs e)
        {
            
        }
    }
}

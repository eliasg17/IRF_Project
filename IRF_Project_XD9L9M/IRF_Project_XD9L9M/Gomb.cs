using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_XD9L9M
{
    class Gomb : Button
    {
        public Gomb()
        {
            Height = 40;
            Width = 80;
            BackColor = Color.SteelBlue;
            Font = new Font("Arial", 8);
            ForeColor = Color.White;

            MouseDown += Gomb_MouseDown;
        }

        private void Gomb_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.MidnightBlue;
            Font = new Font("Arial", 8, FontStyle.Italic);
        }
    }
}

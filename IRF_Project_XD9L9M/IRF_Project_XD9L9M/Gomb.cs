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
            Width = 110;
            BackColor = Color.SteelBlue;
            Font = new Font("Arial", 9);
            ForeColor = Color.White;

            MouseDown += Gomb_MouseDown;
            MouseEnter += Gomb_MouseEnter;
            MouseLeave += Gomb_MouseLeave;
        }

        private void Gomb_MouseLeave(object sender, EventArgs e)
        {
            Font = new Font("Arial", 9);
        }

        private void Gomb_MouseEnter(object sender, EventArgs e)
        {
            Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void Gomb_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.MidnightBlue;
            Font = new Font("Arial", 9, FontStyle.Italic);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_XD9L9M
{
    class DGVClass : DataGridView
    {
        public DGVClass()
        {
            Height = 400;
            Width = 650;
            BackgroundColor = Color.Gray;
            Font = new Font("Arial", 11);
            AutoResizeColumns();
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

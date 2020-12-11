using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_XD9L9M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadTermekek();
        }

        private List<Termek> _termekek = new List<Termek>();    
        private void LoadTermekek()
        {
            _termekek.Clear();
            using (StreamReader sr = new StreamReader("IRF_Project.csv", Encoding.Default))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');

                    _termekek.Add(new Termek(line[0], line[1], int.Parse(line[2])));
                }
            }
        }
    }
}

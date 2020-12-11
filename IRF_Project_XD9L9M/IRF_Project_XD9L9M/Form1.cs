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

            //DataGridView dgw = new DataGridView();
            //Controls.Add(dgw);


            Gomb g = new Gomb();
            g.Text = "Termék hozzáadása";
            g.Top = 260;
            g.Left = 690;
            g.Click += new EventHandler(g_Click);
            Controls.Add(g);

            Gomb g2 = new Gomb();
            g2.Text = "Excel létrehozása";
            g2.Top = 310;
            g2.Left = 690;
            g2.Click += new EventHandler(g2_Click);
            Controls.Add(g2);

            LoadTermekek();

            ListBox lb = new ListBox();
            lb.Items.Add(_termekek.ToString());
            Controls.Add(lb);
            

        }

        private void g_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void g2_Click(object sender, EventArgs e)
        {
            
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_XD9L9M
{
    public partial class Felvetel : Form
    {
        Form1 form1;
        public Felvetel(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            FelvetelBetoltes();
        }
        Label cim, l1, l2, l3;
        TextBox tb1, tb2;
        ComboBox cb1;
        Button b1;
        private void FelvetelBetoltes()
        {
            cim = new Label();
            cim.Left = 75;
            cim.Top = 15;
            cim.Font = new Font("Arial", 18);
            cim.Text = "Új termék felvétele";
            cim.AutoSize = true;
            Controls.Add(cim);

            l1 = new Label();
            l1.Left = 15;
            l1.Top = 60;
            l1.Font = new Font("Arial", 12);
            l1.Text = "Termék neve:";
            l1.Width = 130;
            l1.Height = 30;
            l1.TextAlign = ContentAlignment.MiddleLeft;
            Controls.Add(l1);

            tb1 = new TextBox();
            tb1.Left = 150;
            tb1.Top = 60;
            tb1.Font = new Font("Arial", 12);
            tb1.Width = 220;
            tb1.Height = 30;
            Controls.Add(tb1);

            l2 = new Label();
            l2.Left = 15;
            l2.Top = 110;
            l2.Font = new Font("Arial", 12);
            l2.Text = "Termék márkája:";
            l2.Width = 130;
            l2.Height = 30;
            l2.TextAlign = ContentAlignment.MiddleLeft;
            Controls.Add(l2);

            cb1 = new ComboBox();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.Font = new Font("Arial", 12);
            cb1.Left = 150;
            cb1.Top = 110;
            cb1.Width = 220;
            cb1.Height = 30;
            cb1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            Controls.Add(cb1);

            l3 = new Label();
            l3.Left = 15;
            l3.Top = 160;
            l3.Font = new Font("Arial", 12);
            l3.Text = "Termék ára:";
            l3.Width = 130;
            l3.Height = 30;
            l3.TextAlign = ContentAlignment.MiddleLeft;
            Controls.Add(l3);

            tb2 = new TextBox();
            tb2.Left = 150;
            tb2.Top = 160;
            tb2.Font = new Font("Arial", 12);
            tb2.Width = 220;
            tb2.Height = 30;
            Controls.Add(tb2);

            b1 = new Button();
            b1.BackColor = Color.Green;
            b1.Font = new Font("Arial", 14);
            b1.Left = 250;
            b1.Top = 200;
            b1.Text = "Hozzáadás";
            b1.Width = 120;
            b1.Height = 40;
            b1.Click += B1_Click;
            b1.TextChanged += B1_TextChanged;
            Controls.Add(b1);

            BezarGomb bg1 = new BezarGomb();
            bg1.Left = 340;
            bg1.Click += Bg1_Click;
            Controls.Add(bg1);
        }

        private void Bg1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateTB2()
        {
            Regex r = new Regex(@"^[0-9]*$");
            if (r.IsMatch(tb2.Text))
            {
                tb2.BackColor = Color.LightGreen;
                return true;
            }
            else
            {
                tb2.BackColor = Color.Red;
                return false;
            }
        }

        private void B1_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (ValidateTB2())
            {
                using (StreamWriter sw = new StreamWriter("IRF_Project.csv", true, Encoding.Default))
                {
                    sw.WriteLine(tb1.Text + ";" + cb1.Text + ";" + tb2.Text);
                }

                form1.Frissites();
                this.Close();
            }
        }
    }
}

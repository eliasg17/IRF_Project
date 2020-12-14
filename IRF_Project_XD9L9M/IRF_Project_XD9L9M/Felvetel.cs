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
        public Felvetel()
        {
            InitializeComponent();

            FelvetelBetoltes();
        }

        private void FelvetelBetoltes()
        {
            Label cim = new Label();
            cim.Left = 75;
            cim.Top = 10;
            cim.Font = new Font("Arial", 18);
            cim.Text = "Új termék felvétele";
            cim.AutoSize = true;
            Controls.Add(cim);

            Label l1 = new Label();
            l1.Left = 15;
            l1.Top = 65;
            l1.Font = new Font("Arial", 12);
            l1.Text = "Termék neve:";
            l1.AutoSize = true;
            Controls.Add(l1);

            TextBox tb1 = new TextBox();
            tb1.Left = 120;
            tb1.Top = 65;
            tb1.Font = new Font("Arial", 12);
            tb1.Width = 220;
            tb1.Height = 30;
            Controls.Add(tb1);

            Label l2 = new Label();
            l2.Left = 15;
            l2.Top = 110;
            l2.Font = new Font("Arial", 12);
            l2.Text = "Termék márkája:";
            l2.AutoSize = true;
            Controls.Add(l2);

            ComboBox cb1 = new ComboBox();
            cb1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb1.Font = new Font("Arial", 12);
            cb1.Left = 140;
            cb1.Top = 110;
            cb1.Width = 180;
            cb1.Height = 25;
            cb1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            Controls.Add(cb1);

            Label l3 = new Label();
            l3.Left = 15;
            l3.Top = 150;
            l3.Font = new Font("Arial", 12);
            l3.Text = "Termék ára:";
            l3.AutoSize = true;
            Controls.Add(l3);

            TextBox tb2 = new TextBox();
            tb2.Left = 120;
            tb2.Top = 150;
            tb2.Font = new Font("Arial", 12);
            tb2.Width = 220;
            tb2.Height = 30;
            Controls.Add(tb2);

            Button b1 = new Button();
            b1.BackColor = Color.Green;
            b1.Font = new Font("Arial", 14);
            b1.Left = 205;
            b1.Top = 195;
            b1.Text = "Hozzáadás";
            b1.Width = 135;
            b1.Height = 35;
            b1.Click += B1_Click;
            b1.TextChanged += B1_TextChanged;
            b1.Validating += B1_Validating;
            Controls.Add(b1);
        }

        private void B1_Validating(object sender, CancelEventArgs e)
        {
            //Regex r = new Regex(@"^[0-9]*$");
            //if (r.IsMatch(tb2.Text))
            //{
            //    tb2.BackColor = Color.LightGreen;
            //}
            //else
            //{
            //    tb2.BackColor = Color.Red;
            //    e.Cancel = true;
            //}
        }

        private void B1_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("IRF_Project.csv", true, Encoding.Default))
            {
                //sw.WriteLine(tb1.Text + ";" + cb1.Text + ";" + tb2.Text);
            }
            Form1 form1 = new Form1();
            form1.Refresh();
            form1.Beolvasas();
            this.Close();
        }
    }
}

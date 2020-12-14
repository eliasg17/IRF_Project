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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("IRF_Project.csv", true, Encoding.Default))
            {
                sw.WriteLine(textBox1.Text + ";" + comboBox1.Text + ";" + textBox2.Text);
            }
            Form1 form1 = new Form1();
            form1.Refresh();
            form1.Beolvasas();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex(@"^[0-9]*$");
            if (r.IsMatch(textBox2.Text))
            {
                textBox2.BackColor = Color.LightGreen;
            }
            else
            {
                textBox2.BackColor = Color.Red;
                e.Cancel = true;
            }
        }
    }
}

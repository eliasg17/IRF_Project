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
        }
    }
}

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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IRF_Project_XD9L9M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DGVClass dgv = new DGVClass();
            dgv.DataSource = _termekek;
            dgv.AutoResizeColumns();
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Controls.Add(dgv);

            Label label1 = new Label();
            label1.Left = 680;
            label1.Top = 10;
            label1.Height = 60;
            label1.Width = 80;
            label1.Text = "Mobil"+ Environment.NewLine +"Shop";
            label1.Font = new Font("Arial", 18);
            label1.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);

            //PictureBox label2 = new PictureBox();
            //Image i = Image.FromFile(@"iphone.png");
            //label2.Size = new Size(i.Width, i.Height);
            //label2.Image = i;
            //label2.Left = 680;
            //label2.Top = 40;
            //Controls.Add(label2);

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

            ListBox lb = new ListBox();
            lb.Items.Add(_termekek.ToString());
            Controls.Add(lb);

            LoadTermekek();
        }

        private void g_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void g2_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWB;
            Excel.Worksheet xlSheet;

            //try
            //{
            //    xlApp = new Excel.Application();
            //    xlWB = xlApp.Workbooks.Add(Missing.Value);
            //    xlSheet = xlWB.ActiveSheet;

            //    string[] headers = new string[]
            //    {
            //        "TermékNév",
            //        "MárkaNév",
            //        "Ár",
            //        "Árkategória"
            //    };

            //    for (int i = 0; i < headers.Length; i++)
            //    {
            //        xlSheet.Cells[1, 1 + i] = headers[i];
            //    }
            //    object[,] values = new object[Termek.Count, headers.Length];
            //    int counter = 0;
            //    foreach (Termek termek in Termek)
            //    {
            //        values[counter, 0] = termek.Termeknev;
            //        values[counter, 1] = termek.MarkaNev;
            //        values[counter, 2] = termek.Ar;
            //        values[counter, 3] = termek.Arkategoria;
            //        counter++;
            //    }
            //    xlSheet.get_Range(GetCell(2, 1), GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;
            //    Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            //    headerRange.Font.Bold = true;
            //    headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            //    headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            //    headerRange.EntireColumn.AutoFit();
            //    headerRange.RowHeight = 40;

            //    xlApp.Visible = true;
            //    xlApp.UserControl = true;
            //}
            //catch (Exception ex)
            //{
            //    string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
            //    MessageBox.Show(errMsg, "Error");

            //    xlWB.Close(false, Type.Missing, Type.Missing);
            //    xlApp.Quit();
            //    xlWB = null;
            //    xlApp = null;
            //}
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
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

                    Console.WriteLine("+" + line[2] + "+");

                    _termekek.Add(new Termek(line[0], line[1], line[2]));
                }
            }
        }
    }
}

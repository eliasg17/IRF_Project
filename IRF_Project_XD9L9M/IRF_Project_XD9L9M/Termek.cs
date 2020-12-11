using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_XD9L9M
{
    class Termek
    {

        private int _ar;

        public string Termeknev { get; set; }
        public Termek(string Termeknev, string Marka, int Ar)
        {
            this.Termeknev = Termeknev;
            this.MarkaNev = Marka;
            this._ar = Ar;
        }

        public string MarkaNev { get; set; }
        public int Marka
        {
            set
            {
                if (value == 1)
                {
                    MarkaNev = "Apple";
                }
                else if (value == 2)
                {
                    MarkaNev = "Huawei";
                }
                else if (value == 3)
                {
                    MarkaNev = "Samsung";
                }
                else if (value == 4)
                {
                    MarkaNev = "Xiaomi";
                }
                else if (value == 5)
                {
                    MarkaNev = "Oneplus";
                }
                else if (value == 6)
                {
                    MarkaNev = "Sony";
                }
                else if (value == 7)
                {
                    MarkaNev = "LG";
                }
                else
                {
                    MarkaNev = "Ismeretlen";
                }
            }
        }
        public int Ar { get; set; }

        public string Arkategoria
        {
            get { return Arkategoria; }
            set
            {
                if (_ar <50000)
                {
                    Arkategoria = "$";
                }
                else if (_ar >=50000 && _ar <150000)
                {
                    Arkategoria = "$$";
                }
                else if (_ar >=15000 && _ar < 300000)
                {
                    Arkategoria = "$$$";
                }
                else
                {
                    Arkategoria = "$$$$";
                }
            }
        }
    }
}

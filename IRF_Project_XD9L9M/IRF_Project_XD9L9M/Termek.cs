using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_XD9L9M
{
    class Termek
    {

        private string márka;
        private string ár;

        public string Terméknév { get; set; }
        public Termek(string Termeknev, string Marka, string Ar)
        {
            this.Terméknév = Termeknev;
            this.Márka = Marka;
            this.Ár = Ar;
        }

        public string Márka
        {
            get { return márka; }
            set
            {
                if (value == "1")
                {
                    márka = "Apple";
                }
                else if (value == "2")
                {
                    márka = "Huawei";
                }
                else if (value == "3")
                {
                    márka = "Samsung";
                }
                else if (value == "4")
                {
                    márka = "Xiaomi";
                }
                else if (value == "5")
                {
                    márka = "Oneplus";
                }
                else if (value == "6")
                {
                    márka = "Sony";
                }
                else if (value == "7")
                {
                    márka = "LG";
                }
                else
                {
                    márka = "Ismeretlen";
                }
            }
        }

        public string Ár
        {
            get { return ár; }
            set
            {
                ár = value + " Ft";
            }
        }

        //public string Arkategoria
        //{
        //    get { return Arkategoria; }
        //    set
        //    {
        //        if (_ar <50000)
        //        {
        //            Arkategoria = "$";
        //        }
        //        else if (_ar >=50000 && _ar <150000)
        //        {
        //            Arkategoria = "$$";
        //        }
        //        else if (_ar >=15000 && _ar < 300000)
        //        {
        //            Arkategoria = "$$$";
        //        }
        //        else
        //        {
        //            Arkategoria = "$$$$";
        //        }
        //    }
        //}
    }
}

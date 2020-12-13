using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_XD9L9M
{
    class Termek
    {

        //private int _ar;

        public string Terméknév { get; set; }
        public Termek(string Termeknev, string Marka, string Ar)
        {
            this.Terméknév = Termeknev;
            this.Márka = Marka;
            this.Ár = Ar;
        }

        public string Márka { get; set; }
        //public int Marka
        //{
        //    set
        //    {
        //        //if (value == 1)
        //        //{
        //        //    MárkaNév = "Apple";
        //        //}
        //        //else if (value == 2)
        //        //{
        //        //    MárkaNév = "Huawei";
        //        //}
        //        //else if (value == 3)
        //        //{
        //        //    MárkaNév = "Samsung";
        //        //}
        //        //else if (value == 4)
        //        //{
        //        //    MárkaNév = "Xiaomi";
        //        //}
        //        //else if (value == 5)
        //        //{
        //        //    MárkaNév = "Oneplus";
        //        //}
        //        //else if (value == 6)
        //        //{
        //        //    MárkaNév = "Sony";
        //        //}
        //        //else if (value == 7)
        //        //{
        //        //    MárkaNév = "LG";
        //        //}
        //        //else
        //        //{
        //        //    MárkaNév = "Ismeretlen";
        //        //}
        //    }
        //}
        public string Ár { get; set; }

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

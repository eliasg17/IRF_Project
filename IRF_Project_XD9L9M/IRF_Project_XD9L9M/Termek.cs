using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_XD9L9M
{
    class Termek
    {

        private string _marka;
        private int _ar;

        public string Termeknev { get; set; }
        public Termek(string Termeknev, string Marka, int Ar)
        {
            this.Termeknev = Termeknev;
            this._marka = Marka;
            this._ar = Ar;
        }
        
        //public int Marka
        //{
        //    get { return _marka; }
        //    set
        //    {
        //        if (_marka = "1")
        //        {
        //            _marka = "Apple";
        //        }
        //        else if (_marka == 2)
        //        {
        //            _marka = "Huawei";
        //        }
        //        else if (_marka == 3)
        //        {
        //            _marka = "Samsung";
        //        }
        //        else if (_marka == 4)
        //        {
        //            _marka = "Xiaomi";
        //        }
        //        else if (_marka == 5)
        //        {
        //            _marka = "Oneplus";
        //        }
        //        else if (_marka == 6)
        //        {
        //            _marka = "Sony";
        //        }
        //        else if (_marka = "7")
        //        {
        //            _marka = "LG";
        //        }
        //        else
        //        {
        //            _marka = "Ismeretlen";
        //        }
        //    }
        //}
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

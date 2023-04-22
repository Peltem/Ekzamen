using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz_3
{
    public class Kulinarnaia_Book
    {
        private string _rec;
        private int _gram;
        private int _kal;
        public Kulinarnaia_Book(string Rec, int Gram, int Kal)
        {
            Rec = recept;
            Gram = gram;
            Kal = kal;
        }
            
        
        public string recept
        {
            get => _rec; set { _rec = value; }
        }
        public int gram
        {
            get =>_gram;
            set { _gram = value; } 
        }
        public int kal
        {
            get=>_kal; set { _kal=value; }
        }

    }
}

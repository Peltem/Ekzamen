using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekz_3
{
    public class Dannie
    {

        public List<Kulinarnaia_Book> Base { get; private set; }
       
       

        public Dannie()
        {
            Base = new List<Kulinarnaia_Book>();
        }
        public void Initialize()
        {
            Base.Add(new Kulinarnaia_Book("Пицца",100,10));
            Base.Add(new Kulinarnaia_Book("Kartoshka", 100, 10));
        }
        }
    
}

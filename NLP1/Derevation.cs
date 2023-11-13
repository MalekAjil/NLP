using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP1
{
    public class Derevation
    {
        public string name, peising;
        public LinkedList<Extras> extra;
        public int extraNum;
        public Derevation()
        {
            extra = new LinkedList<Extras>();
        }
        public Derevation(string nm, string pei)
        {
            extra = new LinkedList<Extras>();
            this.name = nm;
            this.peising = pei;
        }
    }
}

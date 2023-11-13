using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP1
{
    public class Extras
    {
        private char name;       
        private int position;
        public Extras()
        {

        }
        public Extras(char nm,int pos)
        {
            this.name = nm;
            this.position = pos;
        }
        public char Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}

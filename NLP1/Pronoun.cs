using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP1
{
    public class Pronoun
    {
        private string name;
        private int num;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public Pronoun() { }
        public Pronoun(string nam,int n)
        {
            this.name = nam;
            this.num = n;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP1
{
    public class Verb
    {
        private string peising;
        private string sufix;
        private int sufixPos;
        private string postfix;
        private int postfixPos;
        private int pronounNum;

        public int PronounNum
        {
            get { return pronounNum; }
            set { pronounNum = value; }
        }
        public string Peising
        {
            get { return peising; }
            set { peising = value; }
        }    
        public string Sufix
        {
            get { return sufix; }
            set { sufix = value; }
        }
        public int SufixPos
        {
            get { return sufixPos; }
            set { sufixPos = value; }
        }
        public string Postfix
        {
            get { return postfix; }
            set { postfix = value; }
        } 
        public int PostfixPos
        {
            get { return postfixPos; }
            set { postfixPos = value; }
        }

        public Verb() { }
        public Verb(string peis,int pNum)
        {
            this.peising = peis;
            this.pronounNum = pNum;
        }
    }
}

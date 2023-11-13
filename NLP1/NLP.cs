using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP1
{
    public class NLP
    {
        public LinkedList<Derevation> derevations;
        public LinkedList<Pronoun> Pronounes;
        public LinkedList<Verb> Past;
        public LinkedList<Verb> Present;
        public LinkedList<Verb> Order;

        public LinkedList<string> words;
        public LinkedList<int> positions;
        public int wordsCount;

        public NLP() { }
        public void init()
        {
            derevations = new LinkedList<Derevation>();
            Pronounes = new LinkedList<Pronoun>();
            Past = new LinkedList<Verb>();
            Present = new LinkedList<Verb>();
            Order = new LinkedList<Verb>();
            words = new LinkedList<string>();
            positions = new LinkedList<int>();
        }

        public string findDerev(string txt)
        {
            char[] x, y;
            string msg = "",str="";
            //int c = cbDerev.SelectedIndex;
            x = txt.ToCharArray();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 'ّ')
                {
                    x[i] = x[i - 1];
                   // x[i] = ' ';
                }

            }
            for (int c = 0; c < derevations.Count; c++)
            {
                y = derevations.ElementAt(c).peising.ToCharArray();
                msg += derevations.ElementAt(c).name + " : ";
                for (int i = 0; i < y.Length; i++)
                {
                    if (x.Length > 4)
                    {
                        if (y[i] == 'ف')
                        { y[i] = x[0]; }
                        else if (y[i] == 'ع')
                        { y[i] = x[2]; }
                        else if (y[i] == 'ل')
                        { y[i] = x[4]; }
                    }
                    else
                    {
                        if (y[i] == 'ف')
                        { y[i] = x[0]; }
                        else if (y[i] == 'ع')
                        { y[i] = x[1]; }
                        else if (y[i] == 'ل')
                        { y[i] = x[2]; }
                    }
                }
                for (int i = 0; i < y.Length; i++)
                {
                    if (i + 3 < y.Length && x.Length>4)
                    {
                        str = y[i].ToString();
                        str += y[i+1];
                        str += y[i+2];
                        str += y[i + 3];
                        if (str == "أَاْ")
                        {
                            msg += 'آ'; i += 2;
                            continue;
                        }                        
                    }
                    else if (i + 1 < y.Length && x.Length < 4)
                    {
                        str = y[i].ToString();
                        str += y[i + 1];                        
                        if (str == "أا")
                        {
                            msg += 'آ'; i++;
                            continue;
                        }
                    }
                    msg += y[i];
                }
                
                msg += "\n";
            }
            return msg;
        }
        public string findPronounDerev(string txt)
        {
            char[] x, y;
            string msg = "", str="";;
            //int c = cbDerev.SelectedIndex;
            x = txt.ToCharArray();
            msg = "الضمير \tالماضي \tالمضارع \tالأمر\n\n";
            for (int c = 0; c < Pronounes.Count; c++)
            {
                x = txt.ToCharArray();
                if (c<7||c>11)
                {
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] == 'ّ')
                        {   x[i] = x[i - 1];      }
                    }
                }
                msg += Pronounes.ElementAt(c).Name + " \t";
                for (int k = 0; k < Past.Count; k++)
                {
                    if (Past.ElementAt(k).PronounNum == Pronounes.ElementAt(c).Num)
                    {
                        y = Past.ElementAt(k).Peising.ToCharArray();
                        for (int i = 0; i < y.Length; i++)
                        {
                            if (y[i] == 'ف')
                            { y[i] = x[0]; }
                            else if (y[i] == 'ع')
                            { y[i] = x[1]; }
                            else if (y[i] == 'ل')
                            { y[i] = x[2]; }
                        }
                        for (int i = 0; i < y.Length; i++)
                        {
                            msg += y[i];
                        }
                        break;
                    }
                }
                msg += " \t";
                x = txt.ToCharArray();
                for (int k = 0; k < Present.Count; k++)
                {
                    if (Present.ElementAt(k).PronounNum == Pronounes.ElementAt(c).Num)
                    {
                        y = Present.ElementAt(k).Peising.ToCharArray();
                        for (int i = 0; i < y.Length; i++)
                        {
                            if (y[i] == 'ف')
                            { y[i] = x[0]; }
                            else if (y[i] == 'ع')
                            { y[i] = x[1]; }
                            else if (y[i] == 'ل')
                            { y[i] = x[2]; }
                        }
                        for (int i = 0; i < y.Length; i++)
                        {
                            if (i + 1 < y.Length && x.Length < 4)
                            {
                                str = y[i].ToString();
                                str += y[i + 1];
                                if (str == "أأ")
                                {
                                    msg += 'آ'; i++;
                                    continue;
                                }
                            }
                            msg += y[i];
                        }
                        break;
                    }
                }
                msg += " \t";
                x = txt.ToCharArray();
                for (int k = 0; k < Order.Count; k++)
                {
                    if (Order.ElementAt(k).PronounNum == Pronounes.ElementAt(c).Num)
                    {
                        y = Order.ElementAt(k).Peising.ToCharArray();
                        for (int i = 0; i < y.Length; i++)
                        {
                            if (y[i] == 'ف')
                            { y[i] = x[0]; }
                            else if (y[i] == 'ع')
                            { y[i] = x[1]; }
                            else if (y[i] == 'ل')
                            { y[i] = x[2]; }
                        }                        
                        for (int i = 0; i < y.Length; i++)
                        {
                            if (i + 1 < y.Length)
                            {
                                str = y[i].ToString();
                                str += y[i + 1];
                                if (str == "اأ")
                                {
                                    i++;
                                    continue;
                                }
                            }
                            msg += y[i];
                        }
                        break;
                    }
                }
                msg += "\n";
            }
            return msg;
        }

        public string findOrigin(string txt)
        {
            string msg,str;
            char[] x, y;
            int k;
            x = txt.ToCharArray();
            y = txt.ToCharArray();
            if(txt.Length<4)
            {
                if (x[0] == 'آ')
                {
                    x[0] = 'أ';
                    x[1] = 'ا';
                }
            }
            for (int c = 0; c < derevations.Count; c++)
            {
                if (x.Length == derevations.ElementAt(c).peising.Length)
                {
                    int match = 0;
                    for (int i = 0; i < derevations.ElementAt(c).extra.Count; i++)
                    {
                        k = derevations.ElementAt(c).extra.ElementAt(i).Position;
                        if (x[k] == derevations.ElementAt(c).extra.ElementAt(i).Name)
                        { match++; }
                    }
                    if (match == derevations.ElementAt(c).extra.Count)
                    {
                        y = derevations.ElementAt(c).peising.ToCharArray();
                        msg = "إن هذه الكلمة هي : \n{ " + derevations.ElementAt(c).name + " } والكلمة الأصل هي : ' ";
                        for (int i = 0; i < y.Length; i++)
                        {
                            if (y[i] == 'ف')
                            { msg += x[i]; }
                            else if (y[i] == 'ع')
                            { msg += x[i]; }
                            else if (y[i] == 'ل')
                            { msg += x[i]; }
                        }
                        msg += " '\n";
                        return msg;
                    }
                    else continue;
                }
            }
            return "لا يوجد مشتق مطابق";
        }

        public void cutWords(string txt)
        {
            string str;
            wordsCount = 0;
            int wordPos = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == ' ' || txt[i] == '\n')
                {
                    if ((txt[wordPos] + txt[wordPos + 1]).ToString() == "ال"&&txt.Length>wordPos+3)
                    {
                        wordPos += 2;
                    }
                    str = txt[wordPos].ToString();
                    for (int j = wordPos+1; j < i; j++)
                    {
                        str += txt[j];
                    }
                    words.AddLast(str);
                    positions.AddLast(wordPos);
                    wordsCount++;
                    wordPos = i + 1;
                }                                
            }
            if (wordPos != txt.Length)
            {
                str = txt[wordPos].ToString();
                for (int j = wordPos + 1; j < txt.Length; j++)
                {
                    str += txt[j];
                }
                words.AddLast(str);
                positions.AddLast(wordPos);
                wordsCount++;
            }
        }
        public bool search(string txt)
        {
            char[] x,y;
            int k;
            x = txt.ToCharArray();
            for (int c = 0; c < derevations.Count; c++)
            {
                if (x.Length == derevations.ElementAt(c).peising.Length)
                {
                    int match = 0;
                    for (int i = 0; i < derevations.ElementAt(c).extra.Count; i++)
                    {
                        k = derevations.ElementAt(c).extra.ElementAt(i).Position;
                        if (x[k] == derevations.ElementAt(c).extra.ElementAt(i).Name)
                        { match++; }
                    }
                    if (match == derevations.ElementAt(c).extra.Count)
                    {                       
                        return true;
                    }
                    else continue;
                }
            }
            for (int c = 0; c < Pronounes.Count; c++)
            {
                y = Pronounes.ElementAt(c).Name.ToCharArray();
                if (x.Length == y.Length)
                {
                    int match = 0;
                    for (int i = 0; i < y.Length; i++)
                    {                      
                        if (x[i] == y[i])
                        { match++; }
                    }
                    if (match == y.Length)
                    {
                        return true;
                    }                    
                }
            }
            for (int c = 0; c < Past.Count; c++)
            {
                if (x.Length == Past.ElementAt(c).Peising.Length)
                {
                    int match = 0;

                    for (int i = 0; i < Past.ElementAt(c).Postfix.Length; i++)
                    {
                        if (x[i + Past.ElementAt(c).PostfixPos] == Past.ElementAt(c).Postfix[i])
                        { match++; }
                    }
                    if (match == Past.ElementAt(c).Postfix.Length)
                    {
                        return true;
                    }
                }
            }
            for (int c = 0; c < Present.Count; c++)
            {
                if (x.Length == Present.ElementAt(c).Peising.Length)
                {
                    int match = 0;

                    for (int i = 0; i < Present.ElementAt(c).Sufix.Length; i++)
                    {
                        if (x[i + Present.ElementAt(c).SufixPos] == Present.ElementAt(c).Sufix[i])
                        { match++; }
                    }
                    for (int i = 0; i < Present.ElementAt(c).Postfix.Length; i++)
                    {
                        if (x[i + Present.ElementAt(c).PostfixPos] == Present.ElementAt(c).Postfix[i])
                        { match++; }
                    }
                    if (match == Present.ElementAt(c).Sufix.Length+Present.ElementAt(c).Postfix.Length)
                    {
                        return true;
                    }
                }
            }
            for (int c = 0; c < Order.Count; c++)
            {
                if (x.Length == Order.ElementAt(c).Peising.Length)
                {
                    int match = 0;

                    for (int i = 0; i < Order.ElementAt(c).Sufix.Length; i++)
                    {
                        if (x[i + Order.ElementAt(c).SufixPos] == Order.ElementAt(c).Sufix[i])
                        { match++; }
                    }
                    for (int i = 0; i < Order.ElementAt(c).Postfix.Length; i++)
                    {
                        if (x[i + Order.ElementAt(c).PostfixPos] == Order.ElementAt(c).Postfix[i])
                        { match++; }
                    }
                    if (match == Order.ElementAt(c).Sufix.Length + Order.ElementAt(c).Postfix.Length)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool match(string txt1,string txt2)
        {
           string msg,str;
            char[] x, y;
            int k;
            x = txt1.ToCharArray();
            y = txt2.ToCharArray();
            
            for (int c = 0; c < derevations.Count; c++)
            {
                if (x.Length == derevations.ElementAt(c).peising.Length)
                {
                    int match = 0;
                    for (int i = 0; i < derevations.ElementAt(c).extra.Count; i++)
                    {
                        k = derevations.ElementAt(c).extra.ElementAt(i).Position;
                        if (x[k] == derevations.ElementAt(c).extra.ElementAt(i).Name)
                        { match++; }
                    }
                    if (match == derevations.ElementAt(c).extra.Count)
                    {
                        y = derevations.ElementAt(c).peising.ToCharArray();
                        msg = "إن هذه الكلمة هي : \n{ " + derevations.ElementAt(c).name + " } والكلمة الأصل هي : ' ";
                        for (int i = 0; i < y.Length; i++)
                        {
                            if (y[i] == 'ف')
                            { msg += x[i]; }
                            else if (y[i] == 'ع')
                            { msg += x[i]; }
                            else if (y[i] == 'ل')
                            { msg += x[i]; }
                        }
                        msg += " '\n";
                        return msg;
                    }
                    else continue;
                }
            }
            return "لا يوجد مشتق مطابق";
    }
    
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NLP1
{
    public class XMLclass
    {
        private static Derevation start , end;

      /*  //تصدير إلى ملف xml
        public static void ExportToXML(string fileName)
        {
            XmlTextWriter xmlw = new XmlTextWriter(fileName, Encoding.UTF8);
          //  xmlw.WriteString("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            xmlw.WriteStartElement("Automate");
            xmlw.WriteString("\n");
            xmlw.WriteStartElement("States");
            xmlw.WriteString("\n");

            foreach (State s in Automate.States)
            {
                xmlw.WriteStartElement("State");
                xmlw.WriteString("\n");
                xmlw.WriteStartElement("Name");
                xmlw.WriteString(s.name);
                xmlw.WriteEndElement();
                xmlw.WriteString("\n");
                xmlw.WriteStartElement("IsFinal");
                xmlw.WriteString(s.Is_Final.ToString());
                xmlw.WriteEndElement();
                xmlw.WriteString("\n");
                xmlw.WriteEndElement();
                xmlw.WriteString("\n");
                xmlw.WriteString("\n");
            }
            xmlw.WriteEndElement();
            xmlw.WriteString("\n");
            xmlw.WriteString("\n");
            xmlw.WriteStartElement("Transitions");
            xmlw.WriteString("\n");

            foreach (Transition t in Automate.transitions)
            {

                xmlw.WriteStartElement("Transition");
                xmlw.WriteString("\n");
                xmlw.WriteStartElement("Name");
                xmlw.WriteString(t.name.ToString());
                xmlw.WriteEndElement();
                xmlw.WriteString("\n");
                xmlw.WriteStartElement("StartState");
                xmlw.WriteString(t.Begin.name);
                xmlw.WriteEndElement();
                xmlw.WriteString("\n");
                xmlw.WriteStartElement("EndState");
                xmlw.WriteString(t.End.name);
                xmlw.WriteEndElement();
                xmlw.WriteString("\n");
                xmlw.WriteEndElement();
                xmlw.WriteString("\n");
                xmlw.WriteString("\n");

            }
            xmlw.WriteEndElement();
            xmlw.WriteString("\n");
            xmlw.WriteEndElement();

            xmlw.Close();
        }
        */
        public static void ImportDerevationsFromXML(string fileName, NLP nlp)
        {
            int DerevationCount, ExtraCount;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            Derevation tempderev;
            Extras tempExtra;
            XmlNode root;
            XmlNodeList node;
            root = doc.DocumentElement;
            DerevationCount = root.ChildNodes.Count;
            //قراءة العقد
            for (int m = 0; m < DerevationCount; m++)
            {
                node = root.ChildNodes;
                if (node.Item(m).Name == "derevation")
                {
                    node = root.ChildNodes[m].ChildNodes;
                    tempderev = new Derevation(node.Item(0).InnerText.Trim(),node.Item(1).InnerText.Trim());
                    ExtraCount = node.Item(2).ChildNodes.Count;
                    for (int n = 0; n < ExtraCount; n++)
                    {
                        node = root.ChildNodes[m].ChildNodes[2].ChildNodes;
                        if (node.Item(n).Name == "extra")
                        {
                            node = root.ChildNodes[m].ChildNodes[2].ChildNodes[n].ChildNodes;
                            tempExtra = new Extras(char.Parse(node.Item(0).InnerText.Trim()), Convert.ToInt32(node.Item(1).InnerText.Trim()));
                            tempderev.extra.AddLast(tempExtra);
                        }
                    }
                   nlp.derevations.AddLast(tempderev);
                }
            }
        }

        public static void ImportPronounesFromXML(string fileName,NLP nlp)
        {
            int PronounsCount, PastCount,PresentCount,OrderCount,c,m;
            int DerevationCount, ExtraCount;
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            Pronoun tempPron;
            Verb tempVerb;
            Derevation tempderev;
            Extras tempExtra;
            XmlNode root;
            XmlNodeList node;
            root = doc.DocumentElement;
            PronounsCount = root.ChildNodes[0].ChildNodes.Count;
            //قراءة العقد
            for (m = 0; m < PronounsCount; m++)
            {
                node = root.ChildNodes[0].ChildNodes;
                if (node.Item(m).Name == "pronoun")
                {
                    node = root.ChildNodes[0].ChildNodes[m].ChildNodes;
                    tempPron = new Pronoun(node.Item(0).InnerText.Trim(), Convert.ToInt32( node.Item(1).InnerText.Trim()));                    
                    nlp.Pronounes.AddLast(tempPron);
                }
            }
            PastCount = root.ChildNodes[1].ChildNodes.Count;
            for (m = 0; m < PastCount; m++)
            {
                node = root.ChildNodes[1].ChildNodes;
                if (node.Item(m).Name == "Past")
                {
                    node = root.ChildNodes[1].ChildNodes[m].ChildNodes;
                    tempVerb = new Verb(node.Item(1).InnerText.Trim(), Convert.ToInt32(node.Item(0).InnerText.Trim()));
                    tempVerb.Postfix = node.Item(2).InnerText.Trim();
                    tempVerb.PostfixPos = Convert.ToInt32(node.Item(3).InnerText.Trim());
                    nlp.Past.AddLast(tempVerb);
                }
            }
            PresentCount = root.ChildNodes[2].ChildNodes.Count;
            for (m = 0; m < PresentCount; m++)
            {
                node = root.ChildNodes[2].ChildNodes;
                if (node.Item(m).Name == "Present")
                {
                    node = root.ChildNodes[2].ChildNodes[m].ChildNodes;
                    tempVerb = new Verb(node.Item(1).InnerText.Trim(), Convert.ToInt32(node.Item(0).InnerText.Trim()));
                    tempVerb.Sufix = node.Item(2).InnerText.Trim();
                    tempVerb.SufixPos=Convert.ToInt32(node.Item(3).InnerText.Trim());
                    tempVerb.Postfix = node.Item(4).InnerText.Trim();
                    tempVerb.PostfixPos = Convert.ToInt32(node.Item(5).InnerText.Trim());
                    nlp.Present.AddLast(tempVerb);
                }
            }
            OrderCount = root.ChildNodes[3].ChildNodes.Count;
            for (m = 0; m < OrderCount; m++)
            {
                node = root.ChildNodes[3].ChildNodes;
                if (node.Item(m).Name == "Order")
                {
                    node = root.ChildNodes[3].ChildNodes[m].ChildNodes;
                    tempVerb = new Verb(node.Item(1).InnerText.Trim(), Convert.ToInt32(node.Item(0).InnerText.Trim()));
                    tempVerb.Sufix = node.Item(2).InnerText.Trim();
                    tempVerb.SufixPos = Convert.ToInt32(node.Item(3).InnerText.Trim());
                    tempVerb.Postfix = node.Item(4).InnerText.Trim();
                    tempVerb.PostfixPos = Convert.ToInt32(node.Item(5).InnerText.Trim());
                    nlp.Order.AddLast(tempVerb);
                }
            }
            DerevationCount = root.ChildNodes[4].ChildNodes.Count;
            //قراءة العقد
            for ( m = 0; m < DerevationCount; m++)
            {
                node = root.ChildNodes[4].ChildNodes;
                if (node.Item(m).Name == "derevation")
                {
                    node = root.ChildNodes[4].ChildNodes[m].ChildNodes;
                    tempderev = new Derevation(node.Item(0).InnerText.Trim(), node.Item(1).InnerText.Trim());
                    ExtraCount = node.Item(2).ChildNodes.Count;
                    for (int n = 0; n < ExtraCount; n++)
                    {
                        node = root.ChildNodes[4].ChildNodes[m].ChildNodes[2].ChildNodes;
                        if (node.Item(n).Name == "extra")
                        {
                            node = root.ChildNodes[4].ChildNodes[m].ChildNodes[2].ChildNodes[n].ChildNodes;
                            tempExtra = new Extras(char.Parse(node.Item(0).InnerText.Trim()), Convert.ToInt32(node.Item(1).InnerText.Trim()));
                            tempderev.extra.AddLast(tempExtra);
                        }
                    }
                    nlp.derevations.AddLast(tempderev);
                }
            }
        }
        /*
        public static State getState(string name)
        {
            for (int i = 0; i < Automate.States.Count; i++)
            {
                if (Automate.States.ElementAt(i).name == name)
                    return Automate.States.ElementAt(i);
            }
            return null;
        }
        */
    }
}

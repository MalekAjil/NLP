using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLP1
{
    public partial class Form1 : Form
    {
        public NLP nlp;
        public Form1()
        {
            InitializeComponent();
            nlp = new NLP();
        }
       

        private void btnDerev_Click(object sender, EventArgs e)
        {
            nlp.derevations = new LinkedList<Derevation>();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XMLclass.ImportDerevationsFromXML(ofd.FileName,nlp);
                btnFindDerev.Enabled = true;
                btnFindOrign.Enabled = true;
            }
        }
       
        private void btnFindDerev_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >=3)
            {
                rtbOutput.Text = nlp.findDerev(textBox1.Text);
            }
            else
            {
                rtbOutput.Text = "ادخل كلمة مشكلة صحيحة";
            }
        }

        private void btnFindOrign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >=3)
            {
                rtbOutput.Text = nlp.findOrigin(textBox1.Text);
            }
            else
            {
                rtbOutput.Text = "ادخل كلمة مشكلة صحيحة";
            }
        }

        private void btnPronounDerev_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >=3)
            {
                rtbOutput.Text = nlp.findPronounDerev(textBox1.Text);
            }
            else
            {
                rtbOutput.Text = "ادخل كلمة من أكثر من حرفين";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //rtbOutput.SelectionBackColor = Color.Red;
            if (rtbOutput.Text.Length >= 3)
            {
                nlp.cutWords(rtbOutput.Text);
                for (int i = 0; i < nlp.words.Count; i++)
                {
                    if (nlp.search(nlp.words.ElementAt(i)))
                    {
                        rtbOutput.SelectionBackColor = Color.Yellow;
                        rtbOutput.SelectionColor = Color.Blue;
                        rtbOutput.Select(nlp.positions.ElementAt(i), nlp.words.ElementAt(i).Length);
                    }
                }
                label1.Text = "";
            }
            else
            {
                label1.Text = "ادخل جملة صحيحة";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.showForm2(nlp);
        }

        private void btnPronoun_Click(object sender, EventArgs e)
        {
            nlp.init();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XMLclass.ImportPronounesFromXML(ofd.FileName, nlp);
                btnFindDerev.Enabled = true;
                btnFindOrign.Enabled = true;
                btnPronounDerev.Enabled = true;
                btnSearch.Enabled = true;
            }
        }

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {
           // rtbOutput.SelectionBackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbOutput.BackColor = Color.White;
            rtbOutput.Select();
            rtbOutput.Clear();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            int matchs = 0;
            char[] x, y;
            if (rtbOutput.Text.Length >= 3 && textBox1.Text.Length>=3)
            {
                nlp.cutWords(rtbOutput.Text);
                for (int i = 0; i < nlp.words.Count; i++)
                {
                    if (nlp.words.ElementAt(i).Length==textBox1.Text.Length)
                    {
                        x = textBox1.Text.ToArray();
                        y=
                        rtbOutput.SelectionBackColor = Color.Yellow;
                        rtbOutput.SelectionColor = Color.Blue;
                        rtbOutput.Select(nlp.positions.ElementAt(i), nlp.words.ElementAt(i).Length);
                    }
                }
                label1.Text = "";
            }
            else
            {
                label1.Text = "ادخل جملة صحيحة";
            }
        }

      
    }
}

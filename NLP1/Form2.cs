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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public NLP nlp;
        public void showForm2(NLP nl)
        {
            this.nlp = nl;
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 3)
            {
                nlp.cutWords(richTextBox1.Text);
                for (int i = 0; i < nlp.words.Count; i++)
                {
                    if (nlp.search(nlp.words.ElementAt(i)))
                    {
                        richTextBox1.SelectionBackColor = Color.Yellow;
                        richTextBox1.Select(nlp.positions.ElementAt(i), nlp.words.ElementAt(i).Length);
                    }                        
                }
            }
            else
            {
                label1.Text = "ادخل جملة صحيحة";
            }
        }

        private void btnPronoun_Click(object sender, EventArgs e)
        {
            nlp.init();
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                XMLclass.ImportPronounesFromXML(ofd.FileName, nlp);
                btnPronoun.Enabled = false;
                btnSearch.Enabled = true;
            }
        }
    }
}

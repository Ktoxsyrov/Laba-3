using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using laba4;
namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           //static int main() { return 0; };
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "Text files(*.txt)|*.txt";
        }
        List<string> list = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\Рабочий стол";
            ofd.Filter = "Text files(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stopwatch t = new Stopwatch();
                t.Start();
                string text = System.IO.File.ReadAllText(ofd.FileName);
                textBox1.Text = text;
                char[] separators = {' ','.','!','?',',','\n',':',';' };
                string[] textarr = text.Split(separators);
              
                foreach (string word in textarr)
                {
                    string str = word.Trim();
                    if (!list.Contains(word))
                        list.Add(word);
                }
                t.Stop();
                textBox1.Text = t.Elapsed.ToString();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { Stopwatch t = new Stopwatch();
            t.Start();
            if (list.Contains(textBox2.Text))
            {

                listBox1.BeginUpdate();
                listBox1.Items.Add(textBox2.Text);
                listBox1.EndUpdate();
            }
            t.Stop();
            textBox2.Text = null;
            textBox3.Text=t.Elapsed.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void search2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testretezcestach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string text = textBox1.Text;
            string abecedniZnaky = "a b c d e f g h i j k l m n o p q r s t u v w x y z ";
            text = text.Trim();
            text = text.ToLower();
            //int pocet = 0;
            //int predchozi = 0;
            //char predchozip = "";
            
            while(text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            
            string[] slova = text.Split(' ');
            foreach(string slovicka in slova)
            {
                foreach(char pismeno in slovicka)
                {
                    if (abecedniZnaky.Contains(pismeno))
                    {

                        //if (pismeno == predchozip)
                        //{
                        //    pocet++;
                        //}
                        //else
                        //{
                        //    predchozi = pocet;
                        //    pocet = 1;
                        //}
                        //predchozip = pismeno;
                        
                        abecedniZnaky = abecedniZnaky.Replace(pismeno, ' ');
                    }
                    
                 

                }

                
                
            }
            label2.Text = text;
            label1.Text ="Pismena co ti zbyvaji: " + abecedniZnaky;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string abecedniZnaky = "a b c d e f g h i j k l m n o p q r s t u v w x y z ";
            string dalsiznak = textBox2.Text;
            dalsiznak = dalsiznak.Trim();
            if (dalsiznak.Length == 1)
            {
                char znak = char.Parse(dalsiznak);
                if (dalsiznak.Length == 1 && abecedniZnaky.Contains(dalsiznak))
                {
                    label2.Text = label2.Text.Replace('_', znak);
                }
                else
                {
                    MessageBox.Show("Zadej pouze jedno pismeno");
                }
                label1.Text = label1.Text.Replace(znak, ' ');
            }
            else
            {
                MessageBox.Show("Zadej pouze jedno pismeno");
            }

        }
    }
}

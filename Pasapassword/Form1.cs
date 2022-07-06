using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasapassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
        int soruno=0 ,dogru=0, yanlis=0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if(textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;
                    case 3:
                        if (textBox1.Text == "country")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break ;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;
                    case 5:
                        if (textBox1.Text == "e")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fırat")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label3.Text = dogru.ToString();

                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();

                        }
                        break;


                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Next";
            soruno++;
            this.Text = soruno.ToString();         /*Forumun sol köşesi this.text oluyor*/

            switch (soruno)
            {
                case 1:
                    richTextBox1.Text = "Coastal region of country";
                    button1.BackColor = Color.Yellow;
                    break;
                case 2:
                    richTextBox1.Text = "The city where kemalpasa dessert is famous";
                    button2.BackColor = Color.Yellow;
                    break;
                case 3:
                    richTextBox1.Text = "Ülke's english";
                    button3.BackColor = Color.Yellow;
                    break;
                case 4:
                    richTextBox1.Text = "Berries famous city";
                    button4.BackColor = Color.Yellow;
                    break;
                case 5:
                    richTextBox1.Text = "Apple";
                    button5.BackColor = Color.Yellow;
                    break;
                case 6:
                    richTextBox1.Text = "My house street";
                    button6.BackColor = Color.Yellow;
                    break;
                case 7:
                    richTextBox1.Text = "Mother's mom";
                    button7.BackColor = Color.Yellow;
                    break;
                case 8:
                    richTextBox1.Text = "Burger's brand";
                    button8.BackColor = Color.Yellow;
                    break;
                case 9:
                    richTextBox1.Text = "Ben kelimesinin ingilizcesi";
                    button16.BackColor = Color.Yellow;
                    break;
                case 10:
                    richTextBox1.Text = "Needle";
                    button17.BackColor = Color.Yellow;
                    break;










            }

        }
    }
}

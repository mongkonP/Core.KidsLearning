using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Ext;
using TORServices.Forms;

namespace Core.KidsLearning.frm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string s = "";
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {

                    
                    richTextBox1.Text+= "\"" + ((a == 0) ? "+" : "-") + "_" + ((b == 0) ? "+" : "-") + "\",";
                }
            }
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    for (int c = 0; c < 2; c++)
                    {
                        richTextBox1.Text += "\"" + ((a == 0) ? "+" : "-") + "_" + ((b == 0) ? "+" : "-") + "_" + ((c == 0) ? "+" : "-") + "\",";
                    }
                }
            }
            for (int a = 0; a < 2; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    for (int c = 0; c < 2; c++)
                        for (int d = 0; d < 2; d++)
                        {
                            {
                                richTextBox1.Text += "\"" + ((a == 0) ? "+" : "-") + "_" + ((b == 0) ? "+" : "-") + "_" + ((c == 0) ? "+" : "-") + "_" + ((d == 0) ? "+" : "-") + "\",";
                            }
                        }
                }
            }*/

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d, c, b;
            int o, n;
            for (n = 1; n <= 50; n++)
            {
                d = (RandomNumberGenerator.GetInt32(100, 1000) % 10) + 1;
                c = (RandomNumberGenerator.GetInt32(100, 1000) % 10) + 1;
                b = (RandomNumberGenerator.GetInt32(100, 1000) % 10) + 1;
                o = RandomNumberGenerator.GetInt32(100, 1000) % 4;
                if (o == 0)
                {
                    if (b + c >= d)
                    {
                        richTextBox1.WriteLine($"{b} + {c} = {d} + {((b + c) - d)}");
                    }
                    else
                    {
                        richTextBox1.WriteLine($"{b}+ {c} =  {d} + {(d - (b + c))}");
                    }
                }
                else if (o == 1)
                {
                    if ((b + c) - d >= d)
                    {
                        richTextBox1.WriteLine($"{b}+ {c}= {((b + c) - d)}- {d}");
                    }
                    else
                    {
                        richTextBox1.WriteLine($"{b}+ {c}= {d}- {((b + c) - d)}");
                    }
                }
                else if (o == 2)
                {
                    if (b >= c)
                    {
                        richTextBox1.WriteLine($"{((b + c) + d)}- {c}= {b}+{d}");
                    }
                    else
                    {
                        richTextBox1.WriteLine($"{((b + c) + d)}- {b}= {c}+ {d}");
                    }
                }
                else if (o == 3)
                {
                    if (c >= d)
                    {
                        richTextBox1.WriteLine($"{b + (c - d)}- {b}= {c}- {d}");
                    }
                    else
                    {
                        richTextBox1.WriteLine($"{b + (d - c)}- {b}= {d}- {c}");
                    }
                }
            }
        }
    }
}

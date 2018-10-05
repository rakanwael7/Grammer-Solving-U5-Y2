using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usdt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (MessageBox.Show("Yes     "+" موجوده فى الجمله ولا لآ لو موجوده دوس "+"used to", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                ac.Enabled = true;
                ae.Enabled = false;
                label7.Show();
            }
            else
            {
                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;

                ae.Enabled = true;
                ac.Enabled = false;
                label7.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("did") || textBox1.Text.Contains("didn't"))
            {
                textBox2.Text = textBox1.Text.Replace("...", " [ Use To ]");
            }
            else if (textBox1.Text.Contains("but") || textBox1.Text.Contains("young") || textBox1.Text.Contains("never") || textBox1.Text.Contains("now"))
            {
                if (textBox1.Text.Contains("young") && textBox1.Text.Contains("love") && textBox1.Text.Contains("enjoy"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ didn't Use To ]");
                }
                else if (textBox1.Text.EndsWith("g"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ didn't Use To ]");
                }
                else if (textBox1.Text.Contains("never"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ Used To ]");
                }
                else if (textBox1.Text.Contains("now"))
                {
                    if (textBox1.Text.Contains("isn't") || textBox1.Text.Contains("doesn't") || textBox1.Text.Contains("don't") || textBox1.Text.Contains("aren't") || textBox1.Text.Contains("haven't") || textBox1.Text.Contains("hasn't") || textBox1.Text.Contains("not"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", " [ Used to ]");
                    }
                    else
                    {
                        textBox2.Text = textBox1.Text.Replace("...", " [didn't Use to ]");
                    }
                }
                else if (textBox1.Text.Contains("but") && textBox1.Text.Contains("is"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [didn't Use To ]");
                }
                else if (textBox1.Text.Contains("but") && textBox1.Text.Contains("does"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ didn't Use To ]");
                }
                else if (textBox1.Text.Contains("but") && textBox1.Text.Contains("do"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ didn't Use To ]");
                }
                else if (textBox1.Text.Contains("but") && textBox1.Text.Contains("are"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [didn't Use To ]");
                }
                else if (textBox1.Text.Contains("young"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ Used To ]");
                }

                else if (textBox1.Text.Contains("ing"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ Used for ]");
                }
                
            }

            else if (textBox1.Text.Contains("when"))
            {
                textBox2.Text = textBox1.Text.Replace("...", " [ Used to ]");
            }
            else if (textBox1.Text.Contains("am") || textBox1.Text.Contains("is") || textBox1.Text.Contains("are") )
            {
                if (textBox1.Text.Contains("he") || textBox1.Text.Contains("she") || textBox1.Text.Contains("they") || textBox1.Text.Contains("we") || textBox1.Text.Contains("I"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ Used to ]");
                }
                else if (textBox1.Text.Contains("ing"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", " [ Used for ]");
                }
                else
                {
                    textBox2.Text = textBox1.Text.Replace("...", "[Used to]");
                }
            }
            else
            {
                textBox2.Text = textBox1.Text.Replace("...", " [ used to ]");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("is used for ") || textBox1.Text.Contains("are used for") || textBox1.Text.Contains("am used for"))
            {
                if (a.Text.Contains("ing"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", a.Text);
                }
                else if (b.Text.Contains("ing"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", b.Text);
                }
                else if (c.Text.Contains("ing"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", c.Text);
                }
                else if (d.Text.Contains("ing"))
                {
                    textBox2.Text = textBox1.Text.Replace("...", d.Text);
                }
            }


            else if (textBox1.Text.Contains("is used to ") || textBox1.Text.Contains("are used to") || textBox1.Text.Contains("am used to") || textBox1.Text.Contains("not used to"))
            {


                if (textBox1.Text.Contains("he") || textBox1.Text.Contains("she") || textBox1.Text.Contains("they") || textBox1.Text.Contains("I") || a.Text.Contains("we"))
                {
                    if (a.Text.Contains("ing"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", a.Text);
                    }
                    else if (b.Text.Contains("ing"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", b.Text);
                    }
                    else if (c.Text.Contains("ing"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", c.Text);
                    }
                    else if (d.Text.Contains("ing"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", d.Text);
                    }
                } 



                else
                {
                    if (!a.Text.EndsWith("d") && !a.Text.EndsWith("g") && !a.Text.EndsWith("s"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", a.Text);
                    }
                    else if (!b.Text.EndsWith("d") && !b.Text.EndsWith("g") && !b.Text.EndsWith("s"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", b.Text);
                    }
                    else if (!c.Text.EndsWith("d") && !c.Text.EndsWith("g") && !c.Text.EndsWith("s"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", c.Text);
                    }
                    else if (!d.Text.EndsWith("d") && !d.Text.EndsWith("g") && !d.Text.EndsWith("s"))
                    {
                        textBox2.Text = textBox1.Text.Replace("...", d.Text);
                    }
                }
            } 
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ae.Enabled == false)
            {
                ae.Enabled = true;
                ac.Enabled = false;

                a.Enabled = false;
                b.Enabled = false;
                c.Enabled = false;
                d.Enabled = false;
                label7.Hide();
            }
            else
            {
                ae.Enabled = false;
                ac.Enabled = true;

                a.Enabled = true;
                b.Enabled = true;
                c.Enabled = true;
                d.Enabled = true;
                label7.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (a.Enabled == true)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Icon = SystemIcons.WinLogo;
                notifyIcon1.BalloonTipTitle = "ثانيه بس ! ";
                notifyIcon1.BalloonTipText = "لو الافعال شاذه الاجابه هتبقي غلط" + 
                            Environment.NewLine + 
                            Environment.NewLine;
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(100);
            }
        }

    }
}

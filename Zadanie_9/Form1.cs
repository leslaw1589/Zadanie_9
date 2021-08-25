using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            numLength.Value = 5;
            numPass.Value = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = generate(numLength.Value, numPass.Value);

            label4.Text = password;

            if (!label3.Visible) label3.Visible = true;
            if (!label4.Visible) label4.Visible = true;

        }

        private string generate(decimal length, decimal hardness)
        {
            string pass = "";

            Random r = new Random();

            int Randfunc(int min, int max)
            {
                int n = r.Next(min, max);
                return n;
            }

            switch (hardness)
            {
                case 1:
                    {
                        for (int i = 0; i < length; i++)
                        {
                            pass += Convert.ToChar(Randfunc(48, 57));
                        }
                        return pass;
                    }
                case 2:
                    {
                        for (int i = 0; i < length; i++)
                        {
                            switch (Randfunc(1, 3))
                            {
                                case 1:
                                    {
                                        pass += Convert.ToChar(Randfunc(48, 57));
                                        break;
                                    }
                                case 2:
                                    {
                                        pass += Convert.ToChar(Randfunc(65, 90));
                                        break;
                                    }
                                case 3:
                                    {
                                        pass += Convert.ToChar(Randfunc(97, 122));
                                        break;
                                    }
                            }
                        }
                        return pass;
                    }
                case 3:
                    {
                        for (int i = 0; i < length; i++)
                        {
                            pass += Convert.ToChar(Randfunc(33, 126));
                        }
                        return pass;
                    }

                default: return pass;
            }
        }
    }
}

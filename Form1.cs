using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int n =int.Parse(textBox1.Text);
            char[] znaky= new char[n];
            Random rnd = new Random();
            int min = '0';
            int max = 'B';
            for(int i =0;i<n;i++)
            {
                char znak = (char)(rnd.Next(min, max+1));
                listBox1.Items.Add(znak);
                znaky[i] = znak;
            }
            if (char.IsDigit(znaky[n-1]))
            {
                for (int i = 0; i < n; i++)
                {
                    if (char.IsDigit(znaky[i])) znaky[i] = 'x';
                }
            }
            else
            {
                int nejvetsiAsciiKod = int.Parse(('0'-1).ToString());
                int poradiNejvetsiho = 0;
                
                for (int i = 0;i<n;i++) 
                {
                    if ((int)znaky[i]>nejvetsiAsciiKod)
                    {
                        poradiNejvetsiho = i;
                        nejvetsiAsciiKod = (int)znaky[i];
                    }
                }

                znaky[poradiNejvetsiho]= znaky[n-1];
                znaky[n - 1] = (char)(nejvetsiAsciiKod);
            }
            foreach(char c in znaky)
            {
                listBox2.Items.Add(c);
            }
        }
    }
}

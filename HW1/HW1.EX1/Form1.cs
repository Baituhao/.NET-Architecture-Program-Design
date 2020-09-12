using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1.EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            int max = 0;
            bool parseSuccess = int.TryParse(textBox1.Text, out number);
            if (!parseSuccess)
            {
                MessageBox.Show("please enter a int number");
                return;
            }
            parseSuccess = int.TryParse(textBox2.Text, out max);
            if (!parseSuccess)
            {
                MessageBox.Show("Please enter a int range");
                return;
            }

            // randomly generate number in listbox1
            listBox1.Items.Clear();
            int[] list = new int[number];
            Random rand = new Random();
            for (int i = 0; i < number; i++)
            {
                // generate a new random number list
                int a = rand.Next(0,max+1);
                list[i] = a;
            }
            Array.Sort(list);
            foreach ( int randnumber in list)
            {
                // add the list into listbox1
                listBox1.Items.Add(randnumber);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // create a list primes to store all primes under the max
            listBox2.Items.Clear();
            int max = 0;
            bool parseSuccess = int.TryParse(textBox2.Text, out max);
            if (!parseSuccess)
            {
                MessageBox.Show("Please enter a int range");
                return;
            }

            List<int> primes = new List<int>();
            primes.Add(2);
            for (int i = 3; i * i < max; i += 2)
            {
                bool prime_flag = true;
                foreach (int prime in primes)
                {
                    if (i % prime == 0)
                    {
                        prime_flag = false;
                        break;
                    }
                }
                if (prime_flag)
                {
                    primes.Add(i);
                }
            }

            /*
            // show the primes
            primes.Sort();
            foreach (int prime in primes)
            {
                listBox2.Items.Add(prime);
            }
            */
        

            List<int> prime_in_listbox1 = new List<int>();
            foreach(int number in listBox1.Items)
            {
                bool prime_flag = true;
                foreach(int prime in primes)
                {
                    if( number % prime == 0)
                    {
                        prime_flag = false;
                        break;
                    }
                }
                if (prime_flag)
                {
                    prime_in_listbox1.Add(number);
                }
            }
            prime_in_listbox1.Sort();
            foreach(int prime in prime_in_listbox1)
            {
                listBox2.Items.Add(prime);
            }
            int n_of_primes = prime_in_listbox1.Count();
            label3.Text = n_of_primes.ToString() + " Primes In Total.";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

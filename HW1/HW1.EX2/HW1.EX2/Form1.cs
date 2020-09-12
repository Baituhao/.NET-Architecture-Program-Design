using System;
using System.Collections;
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

        int N = 100; // the number of entities in array
        int MIN = 20; // the minimum of range
        int MAX = 1000; // the maximum of range

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] array = new int[N];
            Random rand = new Random();
            for(int i = 0; i < N; i++ )
            {
                array[i] = rand.Next(MIN, MAX);
            }
            Array.Sort(array);
            listBox1.Items.Add($"N = {N}");
            listBox1.Items.Add($"{MIN} ~ {MAX}");

            foreach(int entity in array)
            {
                listBox1.Items.Add(entity);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int[] array = new int[N];
            int min, max;
            Int64 sum;
            double average;

            for(int i = 2;i < listBox1.Items.Count;i++)
            {
                array[i - 2] = (int)listBox1.Items[i];
            }

            min = array.Min();
            max = array.Max();
            sum = array.Sum();
            average = ((double)sum) / array.Count();

            listBox2.Items.Add($"min = {min}");
            listBox2.Items.Add($"max = {max}");
            listBox2.Items.Add($"sum = {sum}");
            listBox2.Items.Add($"avg = {average}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW1.EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string str = "";
            List<int> list = new List<int>();
            for(int i = 2; i <= 100; i ++)
            {
                list.Add(i);
                str +=  i.ToString() + " "; 
            }

            listView1.Items.Add("Origin" + str);
            
            for(int i = 2; i*i <= 100; i++)
            {
                str = "";
                List<int> list2Remove = new List<int>();
                foreach (int entity in list)
                {
                    if ((entity % i == 0) & (entity / i > 1))
                        list2Remove.Add(entity);
                    else
                        str += entity.ToString() + " ";
                }
                foreach(int entity in list2Remove)
                {
                    list.Remove(entity);
                }
                listView1.Items.Add($"Remove mult of {i} : " + str);

            }
        }
    }
}

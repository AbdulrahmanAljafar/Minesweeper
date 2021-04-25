using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        List<string> list= new List<string>() { "t", "t", "t", "f", "t", "t", "t", "t","f", "t", "t", "f", "t", "t", "t", "t"};
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button1.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button1.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button5.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button5.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button4.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button4.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button3.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button3.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button11.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button11.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button8.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button8.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /*button2.BackColor = Color.Red;
            string text = "loss";
            MessageBox.Show(text);*/
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button2.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button2.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text); 
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button19.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button19.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button10.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button10.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button7.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button7.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button18.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button18.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button17.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button17.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button9.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button9.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button6.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button6.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button16.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button16.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int index = random.Next(list.Count);

            if (list[index] == "t")
            {
                list.RemoveAt(index);
                button15.BackColor = Color.Blue;
            }
            else
            {
                list.RemoveAt(index);
                button15.BackColor = Color.Red;
                string text = "loss";
                MessageBox.Show(text);
            }
        }
    }
}

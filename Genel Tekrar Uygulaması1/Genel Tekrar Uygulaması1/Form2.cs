using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genel_Tekrar_Uygulaması1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            listBox2.Items.Add("6");
            listBox3.Items.Add(textBox1.Text);
            if (radioButton1.Checked)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                listBox2.Items.Clear();
                listBox3.Items.Clear();

            }
            listBox5.Items.Add(textBox2.Text);
            listBox6.Items.Add(textBox3.Text);
            listBox7.Items.Add(comboBox1.Text);
            listBox8.Items.Add(comboBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            listBox2.Items.Add("1");
            listBox3.Items.Add(textBox1.Text);
            if(radioButton1.Checked)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if(radioButton2.Checked)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                listBox2.Items.Clear();
                listBox3.Items.Clear();

            }
            listBox5.Items.Add(textBox2.Text);
            listBox6.Items.Add(textBox3.Text);
            listBox7.Items.Add(comboBox1.Text);
            listBox8.Items.Add(comboBox2.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 giris = new Form3();
            giris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            listBox2.Items.Add("2");
            listBox3.Items.Add(textBox1.Text);
            if (radioButton1.Checked)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                listBox2.Items.Clear();
                listBox3.Items.Clear();

            }
            listBox5.Items.Add(textBox2.Text);
            listBox6.Items.Add(textBox3.Text);
            listBox7.Items.Add(comboBox1.Text);
            listBox8.Items.Add(comboBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            listBox2.Items.Add("3");
            listBox3.Items.Add(textBox1.Text);
            if (radioButton1.Checked)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                listBox2.Items.Clear();
                listBox3.Items.Clear();

            }
            listBox5.Items.Add(textBox2.Text);
            listBox6.Items.Add(textBox3.Text);
            listBox7.Items.Add(comboBox1.Text);
            listBox8.Items.Add(comboBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            listBox2.Items.Add("4");
            listBox3.Items.Add(textBox1.Text);
            if (radioButton1.Checked)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                listBox2.Items.Clear();
                listBox3.Items.Clear();

            }
            listBox5.Items.Add(textBox2.Text);
            listBox6.Items.Add(textBox3.Text);
            listBox7.Items.Add(comboBox1.Text);
            listBox8.Items.Add(comboBox2.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            listBox2.Items.Add("5");
            listBox3.Items.Add(textBox1.Text);
            if (radioButton1.Checked)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            else
            {
                MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                listBox2.Items.Clear();
                listBox3.Items.Clear();

            }
            listBox5.Items.Add(textBox2.Text);
            listBox6.Items.Add(textBox3.Text);
            listBox7.Items.Add(comboBox1.Text);
            listBox8.Items.Add(comboBox2.Text);
        }
    }
}

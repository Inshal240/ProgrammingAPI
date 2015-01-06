using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProgrammingAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] options = System.IO.File.ReadAllLines("Libraries.txt");
            foreach (string option in options)
            {
                comboBox1.Items.Add(option);
                comboBox2.Items.Add(option);
                comboBox3.Items.Add(option);
                comboBox4.Items.Add(option);
                comboBox5.Items.Add(option);
                comboBox6.Items.Add(option);
                comboBox7.Items.Add(option);
                comboBox8.Items.Add(option);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

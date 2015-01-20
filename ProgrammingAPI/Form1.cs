using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ProgrammingAPI
{
    public partial class Form1 : Form
    {
        string Sensors;
        string[] options = System.IO.File.ReadAllLines("Libraries.txt");
        string[] initials = System.IO.File.ReadAllLines("Initials.txt");
        
        public Form1()
        {
            InitializeComponent();
            
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
            string[] selection = new string[8];
            selection[0] = comboBox2.Text;
            selection[1] = comboBox3.Text;
            selection[2] = comboBox4.Text;
            selection[3] = comboBox5.Text;
            selection[4] = comboBox8.Text;
            selection[5] = comboBox7.Text;
            selection[6] = comboBox6.Text;
            selection[7] = comboBox1.Text;
            Sensors = "";
            
            foreach (string sensor in selection){
                int i = 0;
                bool found = false;
                foreach (string option in options) {
                    if (sensor == option) {
                        Sensors = Sensors + initials[i];
                        found = true;
                        break;
                    }
                    i++;
                }
                if(!found)
                    Sensors = Sensors + "N";
            
            }
            richTextBox1.Text = Sensors;
            
            
            
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

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

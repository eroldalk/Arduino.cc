using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_Blink
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  
            foreach (string port in ports)
                comboBox1.Items.Add(port); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");      
            label1.Text = "OPEN"; 
            button2.Enabled = true;    
            button1.Enabled = false;   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");   
            label1.Text = "CLOSE";
            button1.Enabled = true;   
            button2.Enabled = false;  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString(); 
            serialPort1.Open(); 
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();  
        }
    }
}

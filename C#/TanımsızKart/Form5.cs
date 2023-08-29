using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Data.SqlClient;

namespace TanımsızKart
{
    public partial class Form5 : Form
    {
        string[] portlar = SerialPort.GetPortNames();
        public Form5()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Close();
        }

        

        private void Form5_Load(object sender, EventArgs e)
        {
            
            foreach (string port in portlar)
            {
           
                textBox2.Text = Form0.Gidenbilgi.ToString();

                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();



            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            string data = serialPort1.ReadLine();
            textBox2.Text = data.Trim().ToString();
         

            if (data.Trim().ToString() == "UPDATE")
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                this.Hide();
                serialPort1.Close();
                Form4 form4 = new Form4();
              
                form4.ShowDialog();
               
               


            }

            
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
            {

                DialogResult Cikis;
                Cikis = MessageBox.Show("Program Will Be Closed Are You Sure?", "ARE YOU SURE ?", MessageBoxButtons.YesNo);
                if (Cikis == DialogResult.Yes)
                {
                    serialPort1.Close();
                    Application.Exit();
                }
                if (Cikis == DialogResult.No)
                {

                }
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}


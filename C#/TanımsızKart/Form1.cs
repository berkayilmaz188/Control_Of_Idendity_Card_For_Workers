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
    public partial class Form1 : Form
    {
        string[] portlar = SerialPort.GetPortNames();


        public Form1()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
           

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Control.CheckForIllegalCrossThreadCalls = false;
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Hide();
            

        }





        private void Button2_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            //textBox2.Text = Form0.Gidenbilgi.ToString();
            foreach (string port in portlar)
            {
               

                textBox2.Text = Form0.Gidenbilgi.ToString();
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();

                
            }
           



        }
        

        public void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox2.Text = Form0.Gidenbilgi.ToString();
            string data = serialPort1.ReadLine();

           

            if (data.Trim().ToString() == "REG")
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                serialPort1.Close();
                this.Hide();
                Form3 form3 = new Form3();

                form3.ShowDialog();
                




            }
       

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.Open();
            this.Hide();
          

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

    }
}


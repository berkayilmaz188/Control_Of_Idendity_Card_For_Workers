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
    public partial class Form0 : Form
    {
        static public string Gidenbilgi = "";
        public static string GidenSaat = "";
        
        int b;

        string[] portlar = SerialPort.GetPortNames();
       
        public Form0()
        {
           
            InitializeComponent();
            serialPort1.BaudRate = 9600;
        }
       
        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToLongDateString();
            label4.Text = dt.ToLongTimeString();
           
            GidenSaat = label4.Text.ToString();
         
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label3.Left++;
            if (label3.Left == 706)
                label3.Left = -960;
        


        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (label3.BackColor == Color.MidnightBlue)
                label3.BackColor = Color.RoyalBlue;
            else
                label3.BackColor = Color.MidnightBlue;
            if (label3.ForeColor == Color.Blue)
                label3.ForeColor = Color.Bisque;
            else
                label3.ForeColor = Color.Blue;
          

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        public void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            {
                string data = serialPort1.ReadLine();
                SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-G8BAQ84U\SQLEXPRESS;Initial Catalog=Kayıtlar;Integrated Security=True");


                serialPort1.Close();


                if (data.Trim().ToString() == "MUTLU")
                {

                    

                    serialPort1.Close();

            
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 1 + "'", baglan);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                        Control.CheckForIllegalCrossThreadCalls = false;
                        txtbox.Text = read[1].ToString();
                        
                        if (txtbox.Text == "")
                        {
                            Gidenbilgi = "1";
                            this.Hide();
                            Form3.no = "MUTLU";
                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                            serialPort1.Close();
                           



                        }
                        else
                        {
                            if (b > 0)
                            {
                                Gidenbilgi = "1";
                                this.Hide();
                                Form5 form5 = new Form5();

                                form5.ShowDialog();
                                txtbox.Clear();
                                
                                serialPort1.Close();
                            }
                            else
                            {
                                Gidenbilgi = "1";
                                Form2 form2 = new Form2();
                                form2.ShowDialog();
                                this.Hide();
                                serialPort1.Close();
                                
                            }


                        }

                    }


                    //Gidenbilgi = textBox2.Text.ToString();




                }
                if (data.Trim().ToString() == "MEG")
                {
                    
                    // label2.Text = "presss gegenpress 4-4-2";
                    //button1.PerformClick();
                    // hoacaya burayı sor   neden porttan OK stringini almasına ragmen if içine girmiyor
                    serialPort1.Close();
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 2 + "'", baglan);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                        Control.CheckForIllegalCrossThreadCalls = false;
                        txtbox.Text = read[1].ToString();
                        if (txtbox.Text == "")
                        {
                            Gidenbilgi = "2";
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                            txtbox.Clear();
                            serialPort1.Close();

                          

                        }
                        else
                        {
                            if (b > 0)
                            {
                                Gidenbilgi = "2";
                                this.Hide();
                                Form5 form5 = new Form5();

                                form5.ShowDialog();
                                txtbox.Clear();
                                serialPort1.Close();
                                
                            }
                            else
                            {
                               
                                Gidenbilgi = "2";
                                this.Hide();
                                Form2 form2 = new Form2();
                               
                                form2.ShowDialog();
                                
                                serialPort1.Close();

                               
                            }

                        }

                    }
                }
                if (data.Trim().ToString() == "ECEM")
                {
                    serialPort1.Close();
                    baglan.Open();
                    SqlCommand ekle = new SqlCommand("Insert Into Kayıtlarım  (CardNo) Values(@p1)", baglan);
                    ekle.Parameters.AddWithValue("@P1", 3);
                    ekle.ExecuteNonQuery();
                    serialPort1.Close();
                   
                    SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 3 + "'", baglan);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                        Control.CheckForIllegalCrossThreadCalls = false;
                        txtbox.Text = read[1].ToString();
                        if (txtbox.Text == "")
                        {
                            
                            Gidenbilgi = "3";
                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                            txtbox.Clear();
                            serialPort1.Close();
                            this.Hide();
                           


                        }
                        else
                        {
                            if (b > 0)
                            {
                                Gidenbilgi = "3";
                                
                                Form5 form5 = new Form5();

                                form5.ShowDialog();
                                txtbox.Clear();
                                serialPort1.Close();
                                this.Hide();
                               
                            }
                            else
                            {
                                Gidenbilgi = "3";
                                Form2 form2 = new Form2();
                                form2.ShowDialog();
                                this.Hide();
                                serialPort1.Close();
                                
                            }
                        }

                    }
                }
                if (data.Trim().ToString() == "BERKAY")
                {

                    serialPort1.Close();
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 4 + "'", baglan);
                    SqlDataReader read = komut.ExecuteReader();
                    while (read.Read())
                    {
                        Control.CheckForIllegalCrossThreadCalls = false;
                        txtbox.Text = read[1].ToString();
                        if (txtbox.Text == "")
                        {
                            this.Hide();
                            Gidenbilgi = "4";
                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                            txtbox.Clear();
                            serialPort1.Close();
                            



                        }
                        else
                        {
                            if (b > 0)
                            {
                                Gidenbilgi = "4";
                                this.Hide();
                                Form5 form5 = new Form5();
                            
                                form5.ShowDialog();
                                txtbox.Clear();
                                serialPort1.Close();
                                

                            }
                            else
                            {
                                Gidenbilgi = "4";
                                Form2 form2 = new Form2();
                                form2.ShowDialog();
                                this.Hide();
                                serialPort1.Close();
                                
                            }
                        }
                       

                    }
                  
                }

            }

        }

       private void Form0_Load(object sender, EventArgs e)
        {
            foreach (string port in portlar)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                    var baslangıc = Convert.ToDateTime("19:30:00");
                    var simdi = DateTime.Now;
                    TimeSpan sure = baslangıc - simdi;
                    textBox4.Text = sure.TotalMinutes.ToString();
                    b = Convert.ToInt32(sure.TotalMinutes);
                
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form0.Gidenbilgi = textBox2.Text.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "MUTLU")
            {
               
                
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }

            if (textBox2.Text == "MEG")
            {
               

                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            if (textBox2.Text == "ECEM")
            {
               

                Form3 form3 = new Form3();
                form3.ShowDialog();

            }
            if (textBox2.Text == "BERKAY")
            {


                Form3 form3 = new Form3();
                form3.ShowDialog();

            }



        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
             
            {



            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btnkpt_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

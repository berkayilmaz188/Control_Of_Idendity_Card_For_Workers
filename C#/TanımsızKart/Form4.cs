using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.IO.Ports;

namespace TanımsızKart
{
    public partial class Form4 : Form
    {
        string[] portlar = SerialPort.GetPortNames();
        SqlCommand komut;
        SqlDataAdapter da;
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-G8BAQ84U\\SQLEXPRESS;Initial Catalog=Kayıtlar;Integrated Security=True");
        public void ClearALLControls()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear(); textBox7.Clear(); textBox8.Clear();

        }
        private void verilerigoruntule()
        {


            da = new SqlDataAdapter("Select *From kayıtlarım", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSHOW_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Kayıtlarım";
            SqlDataAdapter da = new SqlDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);


        }


        public void Form4_Load(object sender, EventArgs e)
        {
            baglan.Open();
            //serialPort1.Close();
            foreach (string port in portlar)
            {
               
                textBox12.Text = Form0.Gidenbilgi.ToString();

                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();
                //baglan.Open();



            }
          
            if (textBox9.Text == "1")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 1 + "'", baglan);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox10.Text = read[6].ToString();

                }
            }
            if (textBox9.Text == "2")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 2 + "'", baglan);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox10.Text = read[6].ToString();
                   
                }


            }
            if (textBox9.Text == "3")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 3 + "'", baglan);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox10.Text = read[6].ToString();
                    

                }
            }
            if (textBox9.Text == "4")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 4 + "'", baglan);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox10.Text = read[6].ToString();
                  
                }
            
            }


            verilerigoruntule();
            baglan.Open();
            textBox9.Text = Form0.Gidenbilgi.ToString();
            if (textBox9.Text == "1")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 1 + "'", baglan);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox1.Text = read[1].ToString();
                    textBox2.Text = read[2].ToString();
                    textBox3.Text = read[3].ToString();
                    textBox4.Text = read[4].ToString();
                    textBox5.Text = read[5].ToString();
                    textBox6.Text = read[6].ToString();
                    textBox7.Text = read[7].ToString();
                    textBox8.Text = read[8].ToString();
                    textBox9.Text = read[0].ToString();
                

                }
                baglan.Close();
                

            }
            if (textBox9.Text == "2")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 2 + "'", baglan);
                //baglan.Open();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {

                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox1.Text = read[1].ToString();
                    textBox2.Text = read[2].ToString();
                    textBox3.Text = read[3].ToString();
                    textBox4.Text = read[4].ToString();
                    textBox5.Text = read[5].ToString();
                    textBox6.Text = read[6].ToString();
                    textBox7.Text = read[7].ToString();
                    textBox8.Text = read[8].ToString();
                    textBox9.Text = read[0].ToString();
                    
                }
                baglan.Close();


            }
            if (textBox9.Text == "3")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 3 + "'", baglan);
                //baglan.Open();
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox1.Text = read[1].ToString();
                    textBox2.Text = read[2].ToString();
                    textBox3.Text = read[3].ToString();
                    textBox4.Text = read[4].ToString();
                    textBox5.Text = read[5].ToString();
                    textBox6.Text = read[6].ToString();
                    textBox7.Text = read[7].ToString();
                    textBox8.Text = read[8].ToString();
                    textBox9.Text = read[0].ToString();
                   
                }
                baglan.Close();
            }
            if (textBox9.Text == "4")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 4 + "'", baglan);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox1.Text = read[1].ToString();
                    textBox2.Text = read[2].ToString();
                    textBox3.Text = read[3].ToString();
                    textBox4.Text = read[4].ToString();
                    textBox5.Text = read[5].ToString();
                    textBox6.Text = read[6].ToString();
                    textBox7.Text = read[7].ToString();
                    textBox8.Text = read[8].ToString();
                    textBox9.Text = read[0].ToString();
                    
                }
             
                baglan.Close();
            }

        }
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void kayıtlarımgöster()
        {
            baglan.Open();
            da = new SqlDataAdapter("Select *From kayıtlarım", baglan);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglan.Close();



        }


        private void Button1_Click(object sender, EventArgs e)
        {
            baglan.Open();

            string sorgu = "Update Kayıtlarım SET Name=@Name,[Identity]=@Identity,Email=@Email,Phone=@Phone,Department=@Department,HES=@HES,Working=@Working,Pictures=@Pictures WHERE CardNo=@CardNo";
            komut = new SqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@CardNo", Convert.ToInt32(textBox9.Text));
            komut.Parameters.AddWithValue("@Identity", textBox2.Text);
            komut.Parameters.AddWithValue("@Email", textBox3.Text);
            komut.Parameters.AddWithValue("@Phone", textBox4.Text);
            komut.Parameters.AddWithValue("@Department", textBox5.Text);
            komut.Parameters.AddWithValue("@HES", textBox6.Text);
            komut.Parameters.AddWithValue("@Working", textBox7.Text);
            komut.Parameters.AddWithValue("@Pictures", textBox8.Text);
            komut.Parameters.AddWithValue("@Name", textBox1.Text);
           
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("The update process completed successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kayıtlarımgöster();

           


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Will Be Closed Are You Sure?", "ARE YOU SURE ?", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                baglan.Close();

                serialPort1.Close();
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            OpenFileDialog resim = new OpenFileDialog();
            resim.ShowDialog();
              pictureBox1.ImageLocation = resim.FileName;
            textBox8.Text = resim.FileName;
        }

        private void PictureBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {
            openFileDialog1.FileName = textBox8.Text;
        }

        private void PictureBox1_ParentChanged(object sender, EventArgs e)
        {
            openFileDialog1.FileName = textBox8.Text;
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            
              }
       
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
         
           
            string data = serialPort1.ReadLine();
           

            if (data.Trim().ToString() == "HES")
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                if (textBox9.Text == "1")
                {
                    if (textBox6.Text == "D1E6161116")
                    {
                        MessageBox.Show("Hes Code Matched", "HES CODE ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hes Code didint Matched", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    }

                }
                if (textBox9.Text == "2")
                    if (textBox6.Text == "L6M4611517")
                    {
                        MessageBox.Show("Hes Code Matched","HES CODE ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Hes Code didint Matched", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    }

                if (textBox9.Text=="3")
                    if(textBox6.Text=="N4E7212212")
                    {
                        MessageBox.Show("Hes Code Matched", "HES CODE ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Hes Code didint Matched", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    }

                if (textBox9.Text=="4")
                    if(textBox6.Text=="USKXM213912")
                    {
                        MessageBox.Show("Hes Code Matched", "HES CODE ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hes Code didint Matched","WARNING",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

                    }


                serialPort1.Close();

            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {
            //OpenFileDialog resim = new OpenFileDialog();
            //pictureBox1.ImageLocation = resim.FileName;
            //textBox8.Text = resim.FileName;

        }
    }
    }


           
        

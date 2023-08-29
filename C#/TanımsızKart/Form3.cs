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




namespace TanımsızKart
{
    public partial class Form3 : Form
    {
        SqlCommand komut;
        SqlDataAdapter da;
        public Form3()

        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-G8BAQ84U\SQLEXPRESS;Initial Catalog=Kayıtlar;Integrated Security=True");
        static public string no;
        
        private void verilerigöster()
        {

            SqlCommand komut = new SqlCommand("select *from kayıtlarım", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Name"].ToString();
                ekle.SubItems.Add(oku["Identity"].ToString());
                ekle.SubItems.Add(oku["Email"].ToString());
                ekle.SubItems.Add(oku["Phone"].ToString());
                ekle.SubItems.Add(oku["Department"].ToString());
                ekle.SubItems.Add(oku["HES"].ToString());
                ekle.SubItems.Add(oku["Working"].ToString());
                ekle.SubItems.Add(oku["Pictures"].ToString());


                baglan.Close();




            }

           

        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Cancel_Button_click(object sender, EventArgs e)
        {

            baglan.Close();
            Application.Exit();
            


        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        public void Form3_Load(object sender, EventArgs e)
        {
            baglan.Open();
            Control.CheckForIllegalCrossThreadCalls = false;

            textBox9.Text = Form0.Gidenbilgi.ToString();
            if (textBox9.Text == "1")
            {
                textBox10.Text = "1";


            }
            if (textBox9.Text == "2")
            {
                textBox10.Text = "2";


            }
            if (textBox9.Text == "3")
            {
                textBox10.Text = "3";


            }
            if (textBox9.Text == "4")
            {
                textBox10.Text = "4";


            }
            

            //this.kayıtlarımTableAdapter1.Fill(this.kayıtlarDataSet991.Kayıtlarım);
            // TODO: This line of code loads data into the 'kayıtlarDataSet.Kayıtlarım' table. You can move, or remove it, as needed.


           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
                
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {

               

               string sorgu ="Update Kayıtlarım SET Name=@Name,[Identity]=@Identity,Email=@Email,Phone=@Phone,Department=@Department,HES=@HES,Working=@Working,Pictures=@Pictures WHERE CardNo=@CardNo";
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
                //baglan.Open();
               
                komut.ExecuteNonQuery();
                //verilerigöster();
                baglan.Close();
                MessageBox.Show(" Registration has been done successfully.");
              
            }
                else
                {

                    MessageBox.Show("Please fill in all sections.");



                
            }
          
        }

      
   

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Will Be Closed Are You Sure?", "ARE YOU SURE ?", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                baglan.Close();
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {

            }
        }

       

    

        private void Btnfile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox8.Text = openFileDialog1.FileName;
        }
    }
}

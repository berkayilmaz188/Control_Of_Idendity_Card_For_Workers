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
    public partial class Form2 : Form
    {
        string[] portlar = SerialPort.GetPortNames();
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-G8BAQ84U\\SQLEXPRESS;Initial Catalog=Kayıtlar;Integrated Security=True");


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kayıtlarDataSet2.Kayıtlarım' table. You can move, or remove it, as needed.
           // this.kayıtlarımTableAdapter.Fill(this.kayıtlarDataSet11.Kayıtlarım);
            // TODO: This line of code loads data into the 'kayıtlarDataSet1.Kayıtlarım' table. You can move, or remove it, as needed.
            //this.kayıtlarımTableAdapter.Fill(this.kayıtlarDataSet1.Kayıtlarım);
            MessageBox.Show("_____ logged in during working hours!");
        }
        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from Kayıtlarım", baglanti);
            DataTable tablo = new DataTable();

            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_AutoSizeRowsModeChanged(object sender, DataGridViewAutoSizeModeEventArgs e)
        {

        }
        
      

        private void Button3_Click_1(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Will Be Closed Are You Sure?", "ARE YOU SURE ?", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Kayıtlarım where CardNo='" + dataGridView2.SelectedRows[i].Cells[0].Value.ToString() + "'", baglanti);

                komut.ExecuteNonQuery();
                baglanti.Close();


            }
            MessageBox.Show("Silme işlemi başarılı");
            dataGridView2.DataSource = yenile();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = yenile();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KayıtlarımBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {


            baglanti.Open();
            textBox1.Text = Form0.Gidenbilgi.ToString();
            if (textBox1.Text == "1")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 1 + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox3.Text = read[1].ToString();

                }


            }
            if (textBox1.Text == "2")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 2 + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox3.Text = read[1].ToString();

                }



            }
            if (textBox1.Text == "3")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 3 + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox3.Text = read[1].ToString();

                }


            }

                if (textBox1.Text == "4")
            {
                SqlCommand komut = new SqlCommand("select *from Kayıtlarım where CardNo like '" + 4 + "'", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Control.CheckForIllegalCrossThreadCalls = false;
                    textBox3.Text = read[1].ToString();

                }



            }
            baglanti.Close();

            foreach (string port in portlar)
            {
                //serialPort1.Open();

                textBox2.Text = Form0.Gidenbilgi.ToString();

                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Open();


            }
            MessageBox.Show("An employee named   "+textBox3.Text.ToString()+"   logged in working hours!","WARNING",MessageBoxButtons.OK,MessageBoxIcon.Warning);





            // TODO: This line of code loads data into the 'kayıtlarDataSet99.Kayıtlarım' table. You can move, or remove it, as needed.
            // this.kayıtlarımTableAdapter.Fill(this.kayıtlarDataSet99.Kayıtlarım);
            // TODO: This line of code loads data into the 'kayıtlarDataSet11.Kayıtlarım' table. You can move, or remove it, as needed.
            //this.kayıtlarımTableAdapter.Fill(this.kayıtlarDataSet.Kayıtlarım);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Kayıtlarım";
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView2.DataSource = dt;


            //baglanti.Open();
            //da = new SqlDataAdapter("Select *From kayıtlarım", baglanti);
            //DataTable tablo = new DataTable();
            //da.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Will Be Closed Are You Sure?", "ARE YOU SURE ?", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Kayıtlarım where CardNo='" + dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", baglanti);
            SqlCommand ekle = new SqlCommand("Insert Into Kayıtlarım  (CardNo) Values(@p1)", baglanti);
             ekle.Parameters.AddWithValue("@P1", dataGridView2.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            ekle.ExecuteNonQuery();
            serialPort1.Close();
            baglanti.Close();





            //for (int i = 0; i < dataGridView2.SelectedRows.Count; i++)
            //{
                
            //    baglanti.Open();
            //    SqlCommand komut = new SqlCommand("delete from Kayıtlarım where CardNo=@CardNo",baglanti);
               
               
            //    //   SqlCommand komut = new SqlCommand("delete from Kayıtlarım where CardNo='" + dataGridView2.SelectedRows[i].Cells[0].Value.ToString() + "'", baglanti);

            //    SqlCommand ekle = new SqlCommand("Insert Into Kayıtlarım  (CardNo) Values(@p1)", baglanti);
            //    ekle.Parameters.AddWithValue("@P1", i);
            //    ekle.ExecuteNonQuery();
            //    komut.ExecuteNonQuery();
            //    baglanti.Close();


            //}
            MessageBox.Show("Deletion was successful.");
            dataGridView2.DataSource = yenile();

        }

        private void SerialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadLine();
            Control.CheckForIllegalCrossThreadCalls = false;
            textBox2.Text = data.Trim().ToString();

            if (data.Trim().ToString() == "LIST")
            {


                string sql = "SELECT * FROM Kayıtlarım";
                SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView2.DataSource = dt;
                serialPort1.Close();

            }
         

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
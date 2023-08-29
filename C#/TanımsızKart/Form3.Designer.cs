namespace TanımsızKart
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnfile = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kayıtlarımBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataSet11 = new TanımsızKart.KayıtlarDataSet();
            this.kayıtlarDataSet1 = new TanımsızKart.KayıtlarDataSet();
            this.kayıtlarDataSet2 = new TanımsızKart.KayıtlarDataSet();
            this.kayıtlarDataSet991 = new TanımsızKart.KayıtlarDataSet99();
            this.kayıtlarımTableAdapter1 = new TanımsızKart.KayıtlarDataSet99TableAdapters.KayıtlarımTableAdapter();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarımBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet991)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 18F);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(106, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name Surname :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 18F);
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(106, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 18F);
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(106, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone Number :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Ivory;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox1.Location = new System.Drawing.Point(415, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 27);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Ivory;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox2.Location = new System.Drawing.Point(415, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 27);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Ivory;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox3.Location = new System.Drawing.Point(415, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(268, 27);
            this.textBox3.TabIndex = 20;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Ivory;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox4.Location = new System.Drawing.Point(415, 270);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(268, 27);
            this.textBox4.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Stencil", 40F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(154, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(541, 82);
            this.label7.TabIndex = 20;
            this.label7.Text = "New Register ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Stencil", 14F);
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(415, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 21;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Ivory;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox5.Location = new System.Drawing.Point(415, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(268, 27);
            this.textBox5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 18F);
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(106, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 35);
            this.label6.TabIndex = 23;
            this.label6.Text = "Department :";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Ivory;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox6.Location = new System.Drawing.Point(415, 350);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(268, 27);
            this.textBox6.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Stencil", 18F);
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(106, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 35);
            this.label8.TabIndex = 25;
            this.label8.Text = "HES Code :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Stencil", 14F);
            this.button2.ForeColor = System.Drawing.Color.Ivory;
            this.button2.Location = new System.Drawing.Point(554, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 59);
            this.button2.TabIndex = 27;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Stencil", 18F);
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(106, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 35);
            this.label9.TabIndex = 28;
            this.label9.Text = "Working Hours :";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Ivory;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Cooper Black", 14F);
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox7.Location = new System.Drawing.Point(415, 389);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(268, 27);
            this.textBox7.TabIndex = 29;
            // 
            // btnfile
            // 
            this.btnfile.BackColor = System.Drawing.Color.Ivory;
            this.btnfile.FlatAppearance.BorderSize = 0;
            this.btnfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfile.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnfile.Location = new System.Drawing.Point(1053, 349);
            this.btnfile.Name = "btnfile";
            this.btnfile.Size = new System.Drawing.Size(62, 25);
            this.btnfile.TabIndex = 30;
            this.btnfile.Text = "...";
            this.btnfile.UseVisualStyleBackColor = false;
            this.btnfile.Click += new System.EventHandler(this.Btnfile_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Ivory;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox8.Location = new System.Drawing.Point(742, 351);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(305, 23);
            this.textBox8.TabIndex = 310;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-10, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 131);
            this.panel1.TabIndex = 311;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1063, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 325;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 18F);
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(104, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 35);
            this.label2.TabIndex = 321;
            this.label2.Text = "Identity no :";
            // 
            // kayıtlarımBindingSource
            // 
            this.kayıtlarımBindingSource.DataMember = "Kayıtlarım";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(938, 546);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(143, 105);
            this.listView1.TabIndex = 322;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayıtlarDataSet1
            // 
            this.kayıtlarDataSet1.DataSetName = "DataSet1";
            this.kayıtlarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayıtlarDataSet2
            // 
            this.kayıtlarDataSet2.DataSetName = "DataSet1";
            this.kayıtlarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayıtlarDataSet991
            // 
            this.kayıtlarDataSet991.DataSetName = "KayıtlarDataSet99";
            this.kayıtlarDataSet991.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayıtlarımTableAdapter1
            // 
            this.kayıtlarımTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Poor Richard", 14F);
            this.textBox9.Location = new System.Drawing.Point(348, 568);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(250, 34);
            this.textBox9.TabIndex = 323;
            this.textBox9.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Poor Richard", 14F);
            this.textBox10.Location = new System.Drawing.Point(1021, 487);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(250, 34);
            this.textBox10.TabIndex = 324;
            this.textBox10.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Stencil", 20F);
            this.label10.ForeColor = System.Drawing.Color.Ivory;
            this.label10.Location = new System.Drawing.Point(604, 568);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 40);
            this.label10.TabIndex = 325;
            this.label10.Text = "label10";
            this.label10.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1116, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnfile);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Screen";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarımBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet991)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnfile;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource kayıtlarımBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdentityNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hESCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesDataGridViewTextBoxColumn;
        //private KayıtlarDataSet1TableAdapters.KayıtlarımTableAdapter kayıtlarımTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private KayıtlarDataSet dataSet11;
        private KayıtlarDataSet kayıtlarDataSet1;
        private KayıtlarDataSet kayıtlarDataSet2;
        private KayıtlarDataSet99 kayıtlarDataSet991;
        private KayıtlarDataSet99TableAdapters.KayıtlarımTableAdapter kayıtlarımTableAdapter1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
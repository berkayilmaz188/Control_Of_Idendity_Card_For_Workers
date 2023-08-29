namespace TanımsızKart
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cardNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdentityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picturesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayıtlarımBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kayıtlarDataSet99 = new TanımsızKart.KayıtlarDataSet99();
            this.kayıtlarımTableAdapter = new TanımsızKart.KayıtlarDataSet99TableAdapters.KayıtlarımTableAdapter();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarımBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet99)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Ivory;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox8.Name = "textBox8";
            this.textBox8.TextChanged += new System.EventHandler(this.TextBox8_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Ivory;
            this.button3.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button3, "button3");
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.PictureBox1_ChangeUICues);
            this.pictureBox1.ParentChanged += new System.EventHandler(this.PictureBox1_ParentChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Name = "label3";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.ForeColor = System.Drawing.Color.Ivory;
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button4, "button4");
            this.button4.ForeColor = System.Drawing.Color.Ivory;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button5, "button5");
            this.button5.ForeColor = System.Drawing.Color.Ivory;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Name = "label4";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Ivory;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Ivory;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Ivory;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Ivory;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox4.Name = "textBox4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Name = "label6";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Ivory;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox5.Name = "textBox5";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Name = "label8";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Ivory;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox6.Name = "textBox6";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Name = "label9";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Ivory;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox7.Name = "textBox7";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label7);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Name = "label1";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox9, "textBox9");
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.textBox9.Name = "textBox9";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ıdentityDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.hESDataGridViewTextBoxColumn,
            this.workingDataGridViewTextBoxColumn,
            this.picturesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kayıtlarımBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // cardNoDataGridViewTextBoxColumn
            // 
            this.cardNoDataGridViewTextBoxColumn.DataPropertyName = "CardNo";
            resources.ApplyResources(this.cardNoDataGridViewTextBoxColumn, "cardNoDataGridViewTextBoxColumn");
            this.cardNoDataGridViewTextBoxColumn.Name = "cardNoDataGridViewTextBoxColumn";
            this.cardNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıdentityDataGridViewTextBoxColumn
            // 
            this.ıdentityDataGridViewTextBoxColumn.DataPropertyName = "Identity";
            resources.ApplyResources(this.ıdentityDataGridViewTextBoxColumn, "ıdentityDataGridViewTextBoxColumn");
            this.ıdentityDataGridViewTextBoxColumn.Name = "ıdentityDataGridViewTextBoxColumn";
            this.ıdentityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            resources.ApplyResources(this.phoneDataGridViewTextBoxColumn, "phoneDataGridViewTextBoxColumn");
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            resources.ApplyResources(this.departmentDataGridViewTextBoxColumn, "departmentDataGridViewTextBoxColumn");
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hESDataGridViewTextBoxColumn
            // 
            this.hESDataGridViewTextBoxColumn.DataPropertyName = "HES";
            resources.ApplyResources(this.hESDataGridViewTextBoxColumn, "hESDataGridViewTextBoxColumn");
            this.hESDataGridViewTextBoxColumn.Name = "hESDataGridViewTextBoxColumn";
            this.hESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingDataGridViewTextBoxColumn
            // 
            this.workingDataGridViewTextBoxColumn.DataPropertyName = "Working";
            resources.ApplyResources(this.workingDataGridViewTextBoxColumn, "workingDataGridViewTextBoxColumn");
            this.workingDataGridViewTextBoxColumn.Name = "workingDataGridViewTextBoxColumn";
            this.workingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // picturesDataGridViewTextBoxColumn
            // 
            this.picturesDataGridViewTextBoxColumn.DataPropertyName = "Pictures";
            resources.ApplyResources(this.picturesDataGridViewTextBoxColumn, "picturesDataGridViewTextBoxColumn");
            this.picturesDataGridViewTextBoxColumn.Name = "picturesDataGridViewTextBoxColumn";
            this.picturesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kayıtlarımBindingSource
            // 
            this.kayıtlarımBindingSource.DataMember = "Kayıtlarım";
            this.kayıtlarımBindingSource.DataSource = this.kayıtlarDataSet99;
            // 
            // kayıtlarDataSet99
            // 
            this.kayıtlarDataSet99.DataSetName = "KayıtlarDataSet99";
            this.kayıtlarDataSet99.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kayıtlarımTableAdapter
            // 
            this.kayıtlarımTableAdapter.ClearBeforeFill = true;
            // 
            // btnSHOW
            // 
            this.btnSHOW.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSHOW.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSHOW, "btnSHOW");
            this.btnSHOW.ForeColor = System.Drawing.Color.Ivory;
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.UseVisualStyleBackColor = false;
            // 
            // textBox10
            // 
            resources.ApplyResources(this.textBox10, "textBox10");
            this.textBox10.Name = "textBox10";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // textBox11
            // 
            resources.ApplyResources(this.textBox11, "textBox11");
            this.textBox11.Name = "textBox11";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // textBox12
            // 
            resources.ApplyResources(this.textBox12, "textBox12");
            this.textBox12.Name = "textBox12";
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarımBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet99)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KayıtlarDataSet99 kayıtlarDataSet99;
        private System.Windows.Forms.BindingSource kayıtlarımBindingSource;
        private KayıtlarDataSet99TableAdapters.KayıtlarımTableAdapter kayıtlarımTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdentityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.TextBox textBox10;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox12;
    }
}
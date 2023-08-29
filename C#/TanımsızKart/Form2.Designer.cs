namespace TanımsızKart
{
    partial class Form2
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
            this.kayıtlarDataSet3 = new TanımsızKart.KayıtlarDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kayıtlarDataSet2 = new TanımsızKart.KayıtlarDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdentityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kayıtlarDataSet99 = new TanımsızKart.KayıtlarDataSet99();
            this.kayıtlarımTableAdapter = new TanımsızKart.KayıtlarDataSet99TableAdapters.KayıtlarımTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet99)).BeginInit();
            this.SuspendLayout();
            // 
            // kayıtlarDataSet3
            // 
            this.kayıtlarDataSet3.DataSetName = "DataSet1";
            this.kayıtlarDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Kayıtlarım";
            // 
            // kayıtlarDataSet2
            // 
            this.kayıtlarDataSet2.DataSetName = "DataSet1";
            this.kayıtlarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.ıdentityDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.phoneDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.hESDataGridViewTextBoxColumn,
            this.workingDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(-6, -2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(985, 295);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CardNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "CardNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıdentityDataGridViewTextBoxColumn
            // 
            this.ıdentityDataGridViewTextBoxColumn.DataPropertyName = "Identity";
            this.ıdentityDataGridViewTextBoxColumn.HeaderText = "Identity";
            this.ıdentityDataGridViewTextBoxColumn.Name = "ıdentityDataGridViewTextBoxColumn";
            this.ıdentityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn3.HeaderText = "Department";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // hESDataGridViewTextBoxColumn
            // 
            this.hESDataGridViewTextBoxColumn.DataPropertyName = "HES";
            this.hESDataGridViewTextBoxColumn.HeaderText = "HES";
            this.hESDataGridViewTextBoxColumn.Name = "hESDataGridViewTextBoxColumn";
            this.hESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingDataGridViewTextBoxColumn
            // 
            this.workingDataGridViewTextBoxColumn.DataPropertyName = "Working";
            this.workingDataGridViewTextBoxColumn.HeaderText = "Working";
            this.workingDataGridViewTextBoxColumn.Name = "workingDataGridViewTextBoxColumn";
            this.workingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pictures";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pictures";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Kayıtlarım";
            this.bindingSource2.DataSource = this.kayıtlarDataSet99;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Stencil", 12F);
            this.button4.Location = new System.Drawing.Point(368, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 66);
            this.button4.TabIndex = 1;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Stencil", 12F);
            this.button6.Location = new System.Drawing.Point(661, 299);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(231, 66);
            this.button6.TabIndex = 3;
            this.button6.Text = "EXIT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Stencil", 12F);
            this.button5.Location = new System.Drawing.Point(89, 299);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 66);
            this.button5.TabIndex = 4;
            this.button5.Text = "LIST";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(543, 518);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(954, 518);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(661, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(842, 371);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(935, 394);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form2";
            this.Tag = "";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kayıtlarDataSet99)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kayıtlarımBindingSource;
        //private KayıtlarDataSet1 kayıtlarDataSet1;
        private System.Windows.Forms.BindingSource kayıtlarımBindingSource1;
    //    private KayıtlarDataSet1TableAdapters.KayıtlarımTableAdapter kayıtlarımTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn picturesDataGridViewTextBoxColumn;
       // private KayıtlarDataSet2 kayıtlarDataSet2;
        private System.Windows.Forms.BindingSource kayıtlarımBindingSource2;
        //private KayıtlarDataSet2TableAdapters.KayıtlarımTableAdapter kayıtlarımTableAdapter1;
        private KayıtlarDataSet kayıtlarDataSet3;
       // private KayıtlarDataSet1 kayıtlarDataSet11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private KayıtlarDataSet kayıtlarDataSet2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private KayıtlarDataSet99 kayıtlarDataSet99;
        private System.Windows.Forms.BindingSource bindingSource2;
        private KayıtlarDataSet99TableAdapters.KayıtlarımTableAdapter kayıtlarımTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdentityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}
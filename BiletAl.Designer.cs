using System.Windows.Forms;

namespace Uçak_Bileti_Otomasyonu
{
    partial class BiletAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletAl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbHavayolu = new System.Windows.Forms.ComboBox();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yolcuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ucakbiletotomasyonuDataSet3 = new Uçak_Bileti_Otomasyonu.ucakbiletotomasyonuDataSet3();
            this.yolcuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ucakbiletotomasyonuDataSet1 = new Uçak_Bileti_Otomasyonu.ucakbiletotomasyonuDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.ucakbiletotomasyonuDataSet = new Uçak_Bileti_Otomasyonu.ucakbiletotomasyonuDataSet();
            this.yolcuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yolcuTableAdapter = new Uçak_Bileti_Otomasyonu.ucakbiletotomasyonuDataSetTableAdapters.yolcuTableAdapter();
            this.ucakbiletotomasyonuDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yolcuTableAdapter1 = new Uçak_Bileti_Otomasyonu.ucakbiletotomasyonuDataSet1TableAdapters.yolcuTableAdapter();
            this.yolcuTableAdapter2 = new Uçak_Bileti_Otomasyonu.ucakbiletotomasyonuDataSet3TableAdapters.yolcuTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(41, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(41, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(41, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cep Tel No :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 91);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(163, 118);
            this.textBox2.MaxLength = 25;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_keyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 145);
            this.textBox3.MaxLength = 11;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_keyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(163, 172);
            this.textBox4.MaxLength = 11;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_keyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(408, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Bilet Bilgileri";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(421, 205);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(318, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kategori : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(318, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sınıf :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 17;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 40);
            this.button3.TabIndex = 18;
            this.button3.Text = "Arama";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 44);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(318, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Havayolları:";
            // 
            // cmbHavayolu
            // 
            this.cmbHavayolu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHavayolu.FormattingEnabled = true;
            this.cmbHavayolu.Items.AddRange(new object[] {
            "THY",
            "Anadolujet",
            "Pegasus"});
            this.cmbHavayolu.Location = new System.Drawing.Point(421, 88);
            this.cmbHavayolu.Name = "cmbHavayolu";
            this.cmbHavayolu.Size = new System.Drawing.Size(121, 21);
            this.cmbHavayolu.TabIndex = 12;
            this.cmbHavayolu.SelectedIndexChanged += new System.EventHandler(this.cmbHavayolu_SelectedIndexChanged);
            // 
            // cmbNereden
            // 
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Items.AddRange(new object[] {
            "ADANA",
            "ANTALYA",
            "ANKARA",
            "BURSA",
            "DİYARBAKIR",
            "GAZİANTEP",
            "İSTANBUL",
            "İZMİR",
            "MALATYA",
            "VAN"});
            this.cmbNereden.Location = new System.Drawing.Point(421, 115);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(121, 21);
            this.cmbNereden.TabIndex = 12;
            this.cmbNereden.SelectedIndexChanged += new System.EventHandler(this.CmbNereden_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(318, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nereden:";
            // 
            // cmbNereye
            // 
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Items.AddRange(new object[] {
            "ADANA",
            "ANTALYA",
            "ANKARA",
            "BURSA",
            "DİYARBAKIR",
            "GAZİANTEP",
            "İSTANBUL",
            "İZMİR",
            "MALATYA",
            "VAN"});
            this.cmbNereye.Location = new System.Drawing.Point(421, 142);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(121, 21);
            this.cmbNereye.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(318, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nereye:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(41, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cinsiyet :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(163, 199);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bay";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(212, 198);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bayan";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(422, 250);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 39);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView1.DataSource = this.yolcuBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(25, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Soyad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tc";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tc";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefon";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Cinsiyet";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cinsiyet";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Koltuk";
            this.dataGridViewTextBoxColumn7.HeaderText = "Koltuk";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Havayolu";
            this.dataGridViewTextBoxColumn8.HeaderText = "Havayolu";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nereden";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nereden";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nereye";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nereye";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Sınıf";
            this.dataGridViewTextBoxColumn11.HeaderText = "Sınıf";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Kategori";
            this.dataGridViewTextBoxColumn12.HeaderText = "Kategori";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // yolcuBindingSource2
            // 
            this.yolcuBindingSource2.DataMember = "yolcu";
            this.yolcuBindingSource2.DataSource = this.ucakbiletotomasyonuDataSet3;
            // 
            // ucakbiletotomasyonuDataSet3
            // 
            this.ucakbiletotomasyonuDataSet3.DataSetName = "ucakbiletotomasyonuDataSet3";
            this.ucakbiletotomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yolcuBindingSource1
            // 
            this.yolcuBindingSource1.DataMember = "yolcu";
            this.yolcuBindingSource1.DataSource = this.ucakbiletotomasyonuDataSet1;
            // 
            // ucakbiletotomasyonuDataSet1
            // 
            this.ucakbiletotomasyonuDataSet1.DataSetName = "ucakbiletotomasyonuDataSet1";
            this.ucakbiletotomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 23;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ucakbiletotomasyonuDataSet
            // 
            this.ucakbiletotomasyonuDataSet.DataSetName = "ucakbiletotomasyonuDataSet";
            this.ucakbiletotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yolcuBindingSource
            // 
            this.yolcuBindingSource.DataMember = "yolcu";
            this.yolcuBindingSource.DataSource = this.ucakbiletotomasyonuDataSet;
            // 
            // yolcuTableAdapter
            // 
            this.yolcuTableAdapter.ClearBeforeFill = true;
            // 
            // ucakbiletotomasyonuDataSetBindingSource
            // 
            this.ucakbiletotomasyonuDataSetBindingSource.DataSource = this.ucakbiletotomasyonuDataSet;
            this.ucakbiletotomasyonuDataSetBindingSource.Position = 0;
            // 
            // yolcuTableAdapter1
            // 
            this.yolcuTableAdapter1.ClearBeforeFill = true;
            // 
            // yolcuTableAdapter2
            // 
            this.yolcuTableAdapter2.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(102, 469);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 40);
            this.button5.TabIndex = 24;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // BiletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Uçak_Bileti_Otomasyonu.Properties.Resources.uçak;
            this.ClientSize = new System.Drawing.Size(1098, 544);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.cmbHavayolu);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BiletAl";
            this.Text = "BiletAl";
            this.Load += new System.EventHandler(this.BiletAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yolcuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucakbiletotomasyonuDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    
        private System.Windows.Forms.Label label5;
        private ComboBox cmbHavayolu;
        private ComboBox cmbNereden;
        private Label label9;
        private ComboBox cmbNereye;
        private Label label10;
        private Label label11;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnEkle;
        private DataGridView dataGridView1;
        private Button button1;
        private ucakbiletotomasyonuDataSet ucakbiletotomasyonuDataSet;
        private BindingSource yolcuBindingSource;
        private ucakbiletotomasyonuDataSetTableAdapters.yolcuTableAdapter yolcuTableAdapter;
        private BindingSource ucakbiletotomasyonuDataSetBindingSource;
        private DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn koltukDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn havayoluDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn neredenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nereyeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sınıfDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private ucakbiletotomasyonuDataSet1 ucakbiletotomasyonuDataSet1;
        private BindingSource yolcuBindingSource1;
        private ucakbiletotomasyonuDataSet1TableAdapters.yolcuTableAdapter yolcuTableAdapter1;
        private ucakbiletotomasyonuDataSet3 ucakbiletotomasyonuDataSet3;
        private BindingSource yolcuBindingSource2;
        private ucakbiletotomasyonuDataSet3TableAdapters.yolcuTableAdapter yolcuTableAdapter2;
        private Button button5;
    }
}
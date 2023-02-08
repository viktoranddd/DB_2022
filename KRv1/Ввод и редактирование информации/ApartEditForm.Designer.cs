namespace KRv1
{
    partial class ApartEditForm
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
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idApartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idHouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apPersonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRv1DataSet = new KRv1.KRv1DataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.apartamentTableAdapter = new KRv1.KRv1DataSetTableAdapters.ApartamentTableAdapter();
            this.kRv4DataSet = new KRv1.KRv4DataSet();
            this.apartamentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.apartamentTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.ApartamentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(518, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 51);
            this.button5.TabIndex = 42;
            this.button5.Text = "Изменить запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(63, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 41;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Количество жильцов:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(16, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 38;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(656, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 51);
            this.button3.TabIndex = 37;
            this.button3.Text = "Удалить запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(285, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 51);
            this.button2.TabIndex = 36;
            this.button2.Text = "Обновить таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(123, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 51);
            this.button1.TabIndex = 35;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Площадь квартиры:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(63, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 23);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Номер квартиры:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Дом:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Добавление информации:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idApartamentDataGridViewTextBoxColumn,
            this.idHouseDataGridViewTextBoxColumn,
            this.apNumberDataGridViewTextBoxColumn,
            this.apPersonsDataGridViewTextBoxColumn,
            this.apAreaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apartamentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(285, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 344);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idApartamentDataGridViewTextBoxColumn
            // 
            this.idApartamentDataGridViewTextBoxColumn.DataPropertyName = "IdApartament";
            this.idApartamentDataGridViewTextBoxColumn.HeaderText = "Id квартиры";
            this.idApartamentDataGridViewTextBoxColumn.Name = "idApartamentDataGridViewTextBoxColumn";
            this.idApartamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idHouseDataGridViewTextBoxColumn
            // 
            this.idHouseDataGridViewTextBoxColumn.DataPropertyName = "IdHouse";
            this.idHouseDataGridViewTextBoxColumn.HeaderText = "Id дома";
            this.idHouseDataGridViewTextBoxColumn.Name = "idHouseDataGridViewTextBoxColumn";
            this.idHouseDataGridViewTextBoxColumn.Width = 75;
            // 
            // apNumberDataGridViewTextBoxColumn
            // 
            this.apNumberDataGridViewTextBoxColumn.DataPropertyName = "ApNumber";
            this.apNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.apNumberDataGridViewTextBoxColumn.Name = "apNumberDataGridViewTextBoxColumn";
            this.apNumberDataGridViewTextBoxColumn.Width = 75;
            // 
            // apPersonsDataGridViewTextBoxColumn
            // 
            this.apPersonsDataGridViewTextBoxColumn.DataPropertyName = "ApPersons";
            this.apPersonsDataGridViewTextBoxColumn.HeaderText = "Кол-во жильцов";
            this.apPersonsDataGridViewTextBoxColumn.Name = "apPersonsDataGridViewTextBoxColumn";
            this.apPersonsDataGridViewTextBoxColumn.Width = 125;
            // 
            // apAreaDataGridViewTextBoxColumn
            // 
            this.apAreaDataGridViewTextBoxColumn.DataPropertyName = "ApArea";
            this.apAreaDataGridViewTextBoxColumn.HeaderText = "Площадь (в кв.м)";
            this.apAreaDataGridViewTextBoxColumn.Name = "apAreaDataGridViewTextBoxColumn";
            this.apAreaDataGridViewTextBoxColumn.Width = 125;
            // 
            // apartamentBindingSource
            // 
            this.apartamentBindingSource.DataMember = "Apartament";
            this.apartamentBindingSource.DataSource = this.kRv1DataSet;
            // 
            // kRv1DataSet
            // 
            this.kRv1DataSet.DataSetName = "KRv1DataSet";
            this.kRv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(63, 303);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 23);
            this.textBox3.TabIndex = 43;
            // 
            // apartamentTableAdapter
            // 
            this.apartamentTableAdapter.ClearBeforeFill = true;
            // 
            // kRv4DataSet
            // 
            this.kRv4DataSet.DataSetName = "KRv4DataSet";
            this.kRv4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartamentBindingSource1
            // 
            this.apartamentBindingSource1.DataMember = "Apartament";
            this.apartamentBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // apartamentTableAdapter1
            // 
            this.apartamentTableAdapter1.ClearBeforeFill = true;
            // 
            // ApartEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ApartEditForm";
            this.Text = "ApartEditForm";
            this.Load += new System.EventHandler(this.ApartEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private KRv1DataSet kRv1DataSet;
        private System.Windows.Forms.BindingSource apartamentBindingSource;
        private KRv1DataSetTableAdapters.ApartamentTableAdapter apartamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idApartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPersonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apAreaDataGridViewTextBoxColumn;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource apartamentBindingSource1;
        private KRv4DataSetTableAdapters.ApartamentTableAdapter apartamentTableAdapter1;
    }
}
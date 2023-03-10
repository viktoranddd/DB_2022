namespace KRv1
{
    partial class HouseEditForm
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.streetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRv1DataSet = new KRv1.KRv1DataSet();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseTableAdapter = new KRv1.KRv1DataSetTableAdapters.HouseTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.streetTableAdapter = new KRv1.KRv1DataSetTableAdapters.StreetTableAdapter();
            this.kRv4DataSet = new KRv1.KRv4DataSet();
            this.houseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.houseTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.HouseTableAdapter();
            this.streetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.streetTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.StreetTableAdapter();
            this.idHouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.hNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hLevelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(16, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 23;
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
            this.button3.TabIndex = 22;
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
            this.button2.TabIndex = 21;
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
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(64, 301);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 62);
            this.textBox3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Описание:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(63, 232);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 23);
            this.textBox2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Номер дома:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Название улицы:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Добавление информации:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHouseDataGridViewTextBoxColumn,
            this.idStreetDataGridViewTextBoxColumn,
            this.hNumberDataGridViewTextBoxColumn,
            this.hLevelsDataGridViewTextBoxColumn,
            this.hDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.houseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(285, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 344);
            this.dataGridView1.TabIndex = 12;
            // 
            // streetBindingSource
            // 
            this.streetBindingSource.DataMember = "Street";
            this.streetBindingSource.DataSource = this.kRv1DataSet;
            // 
            // kRv1DataSet
            // 
            this.kRv1DataSet.DataSetName = "KRv1DataSet";
            this.kRv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataMember = "House";
            this.houseBindingSource.DataSource = this.kRv1DataSet;
            // 
            // houseTableAdapter
            // 
            this.houseTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(63, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Количество этажей:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(518, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 51);
            this.button5.TabIndex = 27;
            this.button5.Text = "Изменить запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // streetTableAdapter
            // 
            this.streetTableAdapter.ClearBeforeFill = true;
            // 
            // kRv4DataSet
            // 
            this.kRv4DataSet.DataSetName = "KRv4DataSet";
            this.kRv4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // houseBindingSource1
            // 
            this.houseBindingSource1.DataMember = "House";
            this.houseBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // houseTableAdapter1
            // 
            this.houseTableAdapter1.ClearBeforeFill = true;
            // 
            // streetBindingSource1
            // 
            this.streetBindingSource1.DataMember = "Street";
            this.streetBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // streetTableAdapter1
            // 
            this.streetTableAdapter1.ClearBeforeFill = true;
            // 
            // idHouseDataGridViewTextBoxColumn
            // 
            this.idHouseDataGridViewTextBoxColumn.DataPropertyName = "IdHouse";
            this.idHouseDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idHouseDataGridViewTextBoxColumn.Name = "idHouseDataGridViewTextBoxColumn";
            this.idHouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idHouseDataGridViewTextBoxColumn.Width = 50;
            // 
            // idStreetDataGridViewTextBoxColumn
            // 
            this.idStreetDataGridViewTextBoxColumn.DataPropertyName = "IdStreet";
            this.idStreetDataGridViewTextBoxColumn.DataSource = this.streetBindingSource1;
            this.idStreetDataGridViewTextBoxColumn.DisplayMember = "StName";
            this.idStreetDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idStreetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.idStreetDataGridViewTextBoxColumn.Name = "idStreetDataGridViewTextBoxColumn";
            this.idStreetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idStreetDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idStreetDataGridViewTextBoxColumn.ValueMember = "IdStreet";
            this.idStreetDataGridViewTextBoxColumn.Width = 150;
            // 
            // hNumberDataGridViewTextBoxColumn
            // 
            this.hNumberDataGridViewTextBoxColumn.DataPropertyName = "HNumber";
            this.hNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.hNumberDataGridViewTextBoxColumn.Name = "hNumberDataGridViewTextBoxColumn";
            this.hNumberDataGridViewTextBoxColumn.Width = 75;
            // 
            // hLevelsDataGridViewTextBoxColumn
            // 
            this.hLevelsDataGridViewTextBoxColumn.DataPropertyName = "HLevels";
            this.hLevelsDataGridViewTextBoxColumn.HeaderText = "Количество этажей";
            this.hLevelsDataGridViewTextBoxColumn.Name = "hLevelsDataGridViewTextBoxColumn";
            this.hLevelsDataGridViewTextBoxColumn.Width = 135;
            // 
            // hDescriptionDataGridViewTextBoxColumn
            // 
            this.hDescriptionDataGridViewTextBoxColumn.DataPropertyName = "HDescription";
            this.hDescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.hDescriptionDataGridViewTextBoxColumn.Name = "hDescriptionDataGridViewTextBoxColumn";
            this.hDescriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // HouseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HouseEditForm";
            this.Text = "HouseEditForm";
            this.Load += new System.EventHandler(this.HouseEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KRv1DataSet kRv1DataSet;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private KRv1DataSetTableAdapters.HouseTableAdapter houseTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource streetBindingSource;
        private KRv1DataSetTableAdapters.StreetTableAdapter streetTableAdapter;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource houseBindingSource1;
        private KRv4DataSetTableAdapters.HouseTableAdapter houseTableAdapter1;
        private System.Windows.Forms.BindingSource streetBindingSource1;
        private KRv4DataSetTableAdapters.StreetTableAdapter streetTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hLevelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDescriptionDataGridViewTextBoxColumn;
    }
}
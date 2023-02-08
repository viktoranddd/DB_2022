namespace KRv1.Осуществление_запросов
{
    partial class HouseRequestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idApartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apPersonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartamentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRv1DataSet = new KRv1.KRv1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(391, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 33);
            this.button1.TabIndex = 38;
            this.button1.Text = "Вывести список должников";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 37;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(308, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Общая сумма долга:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idApartamentDataGridViewTextBoxColumn,
            this.apNumberDataGridViewTextBoxColumn,
            this.apPersonsDataGridViewTextBoxColumn,
            this.apAreaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.apartamentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 263);
            this.dataGridView1.TabIndex = 35;
            // 
            // idApartamentDataGridViewTextBoxColumn
            // 
            this.idApartamentDataGridViewTextBoxColumn.DataPropertyName = "IdApartament";
            this.idApartamentDataGridViewTextBoxColumn.HeaderText = "Id квартиры";
            this.idApartamentDataGridViewTextBoxColumn.Name = "idApartamentDataGridViewTextBoxColumn";
            this.idApartamentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apNumberDataGridViewTextBoxColumn
            // 
            this.apNumberDataGridViewTextBoxColumn.DataPropertyName = "ApNumber";
            this.apNumberDataGridViewTextBoxColumn.HeaderText = "Номер квартиры";
            this.apNumberDataGridViewTextBoxColumn.Name = "apNumberDataGridViewTextBoxColumn";
            this.apNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.apNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // apPersonsDataGridViewTextBoxColumn
            // 
            this.apPersonsDataGridViewTextBoxColumn.DataPropertyName = "ApPersons";
            this.apPersonsDataGridViewTextBoxColumn.HeaderText = "Кол-во жильцов";
            this.apPersonsDataGridViewTextBoxColumn.Name = "apPersonsDataGridViewTextBoxColumn";
            this.apPersonsDataGridViewTextBoxColumn.ReadOnly = true;
            this.apPersonsDataGridViewTextBoxColumn.Width = 125;
            // 
            // apAreaDataGridViewTextBoxColumn
            // 
            this.apAreaDataGridViewTextBoxColumn.DataPropertyName = "ApArea";
            this.apAreaDataGridViewTextBoxColumn.HeaderText = "Площадь (в кв.м)";
            this.apAreaDataGridViewTextBoxColumn.Name = "apAreaDataGridViewTextBoxColumn";
            this.apAreaDataGridViewTextBoxColumn.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Квартиры, имеющие задолженности:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Дом:";
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
            // HouseRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "HouseRequestForm";
            this.Text = "HouseRequestForm";
            this.Load += new System.EventHandler(this.HouseRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private KRv1DataSet kRv1DataSet;
        private System.Windows.Forms.BindingSource apartamentBindingSource;
        private KRv1DataSetTableAdapters.ApartamentTableAdapter apartamentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idApartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPersonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apAreaDataGridViewTextBoxColumn;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource apartamentBindingSource1;
        private KRv4DataSetTableAdapters.ApartamentTableAdapter apartamentTableAdapter1;
    }
}
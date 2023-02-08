namespace KRv1.Осуществление_запросов
{
    partial class PayerRequestForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.payerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerPatronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRv1DataSet = new KRv1.KRv1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.payerTableAdapter = new KRv1.KRv1DataSetTableAdapters.PayerTableAdapter();
            this.kRv4DataSet = new KRv1.KRv4DataSet();
            this.payerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.payerTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PayerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(391, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 33);
            this.button1.TabIndex = 52;
            this.button1.Text = "Вывести список плательщиков";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 409);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 51;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payerSurnameDataGridViewTextBoxColumn,
            this.payerNameDataGridViewTextBoxColumn,
            this.payerPatronymicDataGridViewTextBoxColumn,
            this.payerPhoneDataGridViewTextBoxColumn,
            this.payerEmailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.payerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 263);
            this.dataGridView1.TabIndex = 49;
            // 
            // payerSurnameDataGridViewTextBoxColumn
            // 
            this.payerSurnameDataGridViewTextBoxColumn.DataPropertyName = "PayerSurname";
            this.payerSurnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.payerSurnameDataGridViewTextBoxColumn.Name = "payerSurnameDataGridViewTextBoxColumn";
            this.payerSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payerNameDataGridViewTextBoxColumn
            // 
            this.payerNameDataGridViewTextBoxColumn.DataPropertyName = "PayerName";
            this.payerNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.payerNameDataGridViewTextBoxColumn.Name = "payerNameDataGridViewTextBoxColumn";
            this.payerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payerPatronymicDataGridViewTextBoxColumn
            // 
            this.payerPatronymicDataGridViewTextBoxColumn.DataPropertyName = "PayerPatronymic";
            this.payerPatronymicDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.payerPatronymicDataGridViewTextBoxColumn.Name = "payerPatronymicDataGridViewTextBoxColumn";
            this.payerPatronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payerPhoneDataGridViewTextBoxColumn
            // 
            this.payerPhoneDataGridViewTextBoxColumn.DataPropertyName = "PayerPhone";
            this.payerPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.payerPhoneDataGridViewTextBoxColumn.Name = "payerPhoneDataGridViewTextBoxColumn";
            this.payerPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // payerEmailDataGridViewTextBoxColumn
            // 
            this.payerEmailDataGridViewTextBoxColumn.DataPropertyName = "PayerEmail";
            this.payerEmailDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.payerEmailDataGridViewTextBoxColumn.Name = "payerEmailDataGridViewTextBoxColumn";
            this.payerEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.payerEmailDataGridViewTextBoxColumn.Width = 200;
            // 
            // payerBindingSource
            // 
            this.payerBindingSource.DataMember = "Payer";
            this.payerBindingSource.DataSource = this.kRv1DataSet;
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
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Плательщики:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 21);
            this.comboBox1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Квартира:";
            // 
            // payerTableAdapter
            // 
            this.payerTableAdapter.ClearBeforeFill = true;
            // 
            // kRv4DataSet
            // 
            this.kRv4DataSet.DataSetName = "KRv4DataSet";
            this.kRv4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payerBindingSource1
            // 
            this.payerBindingSource1.DataMember = "Payer";
            this.payerBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // payerTableAdapter1
            // 
            this.payerTableAdapter1.ClearBeforeFill = true;
            // 
            // PayerRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "PayerRequestForm";
            this.Text = "PayerRequestForm";
            this.Load += new System.EventHandler(this.PayerRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private KRv1DataSet kRv1DataSet;
        private System.Windows.Forms.BindingSource payerBindingSource;
        private KRv1DataSetTableAdapters.PayerTableAdapter payerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerPatronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payerEmailDataGridViewTextBoxColumn;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource payerBindingSource1;
        private KRv4DataSetTableAdapters.PayerTableAdapter payerTableAdapter1;
    }
}
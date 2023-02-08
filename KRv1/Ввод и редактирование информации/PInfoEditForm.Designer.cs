namespace KRv1
{
    partial class PInfoEditForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPaymentInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idApartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kRv4DataSet = new KRv1.KRv4DataSet();
            this.paymentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRv1DataSet = new KRv1.KRv1DataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.paymentInfoTableAdapter = new KRv1.KRv1DataSetTableAdapters.PaymentInfoTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.paymentInfoTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PaymentInfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).BeginInit();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Статус оплаты:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(64, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 39;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Период:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Квартира:";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaymentInfoDataGridViewTextBoxColumn,
            this.idApartamentDataGridViewTextBoxColumn,
            this.pIPeriodDataGridViewTextBoxColumn,
            this.pIStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentInfoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(285, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 344);
            this.dataGridView1.TabIndex = 28;
            // 
            // idPaymentInfoDataGridViewTextBoxColumn
            // 
            this.idPaymentInfoDataGridViewTextBoxColumn.DataPropertyName = "IdPaymentInfo";
            this.idPaymentInfoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idPaymentInfoDataGridViewTextBoxColumn.Name = "idPaymentInfoDataGridViewTextBoxColumn";
            this.idPaymentInfoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPaymentInfoDataGridViewTextBoxColumn.Width = 50;
            // 
            // idApartamentDataGridViewTextBoxColumn
            // 
            this.idApartamentDataGridViewTextBoxColumn.DataPropertyName = "IdApartament";
            this.idApartamentDataGridViewTextBoxColumn.HeaderText = "Id квартиры";
            this.idApartamentDataGridViewTextBoxColumn.Name = "idApartamentDataGridViewTextBoxColumn";
            // 
            // pIPeriodDataGridViewTextBoxColumn
            // 
            this.pIPeriodDataGridViewTextBoxColumn.DataPropertyName = "PIPeriod";
            this.pIPeriodDataGridViewTextBoxColumn.HeaderText = "Начало периода";
            this.pIPeriodDataGridViewTextBoxColumn.Name = "pIPeriodDataGridViewTextBoxColumn";
            this.pIPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // pIStatusDataGridViewTextBoxColumn
            // 
            this.pIStatusDataGridViewTextBoxColumn.DataPropertyName = "PIStatus";
            this.pIStatusDataGridViewTextBoxColumn.HeaderText = "Статус оплаты";
            this.pIStatusDataGridViewTextBoxColumn.Name = "pIStatusDataGridViewTextBoxColumn";
            this.pIStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentInfoBindingSource1
            // 
            this.paymentInfoBindingSource1.DataMember = "PaymentInfo";
            this.paymentInfoBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // kRv4DataSet
            // 
            this.kRv4DataSet.DataSetName = "KRv4DataSet";
            this.kRv4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentInfoBindingSource
            // 
            this.paymentInfoBindingSource.DataMember = "PaymentInfo";
            this.paymentInfoBindingSource.DataSource = this.kRv1DataSet;
            // 
            // kRv1DataSet
            // 
            this.kRv1DataSet.DataSetName = "KRv1DataSet";
            this.kRv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(64, 236);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 21);
            this.comboBox2.TabIndex = 43;
            // 
            // paymentInfoTableAdapter
            // 
            this.paymentInfoTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(64, 167);
            this.maskedTextBox1.Mask = "00.0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(193, 20);
            this.maskedTextBox1.TabIndex = 44;
            // 
            // paymentInfoTableAdapter1
            // 
            this.paymentInfoTableAdapter1.ClearBeforeFill = true;
            // 
            // PInfoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PInfoEditForm";
            this.Text = "PInfoEditForm";
            this.Load += new System.EventHandler(this.PInfoEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private KRv1DataSet kRv1DataSet;
        private System.Windows.Forms.BindingSource paymentInfoBindingSource;
        private KRv1DataSetTableAdapters.PaymentInfoTableAdapter paymentInfoTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaymentInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idApartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIStatusDataGridViewTextBoxColumn;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource paymentInfoBindingSource1;
        private KRv4DataSetTableAdapters.PaymentInfoTableAdapter paymentInfoTableAdapter1;
    }
}
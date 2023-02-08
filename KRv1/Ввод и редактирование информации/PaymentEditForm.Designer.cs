namespace KRv1
{
    partial class PaymentEditForm
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idApartamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPaymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.paymentTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kRv4DataSet = new KRv1.KRv4DataSet();
            this.pAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAccuralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBenefitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRv1DataSet = new KRv1.KRv1DataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new KRv1.KRv1DataSetTableAdapters.PaymentTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.paymentTypeTableAdapter = new KRv1.KRv1DataSetTableAdapters.PaymentTypeTableAdapter();
            this.paymentTypeTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PaymentTypeTableAdapter();
            this.paymentTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(62, 340);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(192, 23);
            this.textBox3.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Льгота:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "Тариф:";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(518, 380);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 51);
            this.button5.TabIndex = 58;
            this.button5.Text = "Изменить запись";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(16, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 57;
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
            this.button3.TabIndex = 56;
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
            this.button2.TabIndex = 55;
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
            this.button1.TabIndex = 54;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(62, 290);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 23);
            this.textBox2.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Объём пользования:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(62, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 23);
            this.textBox1.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Период:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Добавление информации:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaymentDataGridViewTextBoxColumn,
            this.idApartamentDataGridViewTextBoxColumn,
            this.pPeriodDataGridViewTextBoxColumn,
            this.idPaymentTypeDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn,
            this.pTariffDataGridViewTextBoxColumn,
            this.pAccuralDataGridViewTextBoxColumn,
            this.pBenefitDataGridViewTextBoxColumn,
            this.pTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(285, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(503, 344);
            this.dataGridView1.TabIndex = 48;
            // 
            // idPaymentDataGridViewTextBoxColumn
            // 
            this.idPaymentDataGridViewTextBoxColumn.DataPropertyName = "IdPayment";
            this.idPaymentDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idPaymentDataGridViewTextBoxColumn.Name = "idPaymentDataGridViewTextBoxColumn";
            this.idPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPaymentDataGridViewTextBoxColumn.Width = 50;
            // 
            // idApartamentDataGridViewTextBoxColumn
            // 
            this.idApartamentDataGridViewTextBoxColumn.DataPropertyName = "IdApartament";
            this.idApartamentDataGridViewTextBoxColumn.HeaderText = "Id квартиры";
            this.idApartamentDataGridViewTextBoxColumn.Name = "idApartamentDataGridViewTextBoxColumn";
            // 
            // pPeriodDataGridViewTextBoxColumn
            // 
            this.pPeriodDataGridViewTextBoxColumn.DataPropertyName = "PPeriod";
            this.pPeriodDataGridViewTextBoxColumn.HeaderText = "Начало периода";
            this.pPeriodDataGridViewTextBoxColumn.Name = "pPeriodDataGridViewTextBoxColumn";
            this.pPeriodDataGridViewTextBoxColumn.Width = 125;
            // 
            // idPaymentTypeDataGridViewTextBoxColumn
            // 
            this.idPaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "IdPaymentType";
            this.idPaymentTypeDataGridViewTextBoxColumn.DataSource = this.paymentTypeBindingSource1;
            this.idPaymentTypeDataGridViewTextBoxColumn.DisplayMember = "PTName";
            this.idPaymentTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.idPaymentTypeDataGridViewTextBoxColumn.HeaderText = "Вид платежа";
            this.idPaymentTypeDataGridViewTextBoxColumn.Name = "idPaymentTypeDataGridViewTextBoxColumn";
            this.idPaymentTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPaymentTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPaymentTypeDataGridViewTextBoxColumn.ValueMember = "IdPaymentType";
            this.idPaymentTypeDataGridViewTextBoxColumn.Width = 175;
            // 
            // paymentTypeBindingSource1
            // 
            this.paymentTypeBindingSource1.DataMember = "PaymentType";
            this.paymentTypeBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // kRv4DataSet
            // 
            this.kRv4DataSet.DataSetName = "KRv4DataSet";
            this.kRv4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pAmountDataGridViewTextBoxColumn
            // 
            this.pAmountDataGridViewTextBoxColumn.DataPropertyName = "PAmount";
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "Объем пользования";
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            this.pAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // pTariffDataGridViewTextBoxColumn
            // 
            this.pTariffDataGridViewTextBoxColumn.DataPropertyName = "PTariff";
            this.pTariffDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.pTariffDataGridViewTextBoxColumn.Name = "pTariffDataGridViewTextBoxColumn";
            // 
            // pAccuralDataGridViewTextBoxColumn
            // 
            this.pAccuralDataGridViewTextBoxColumn.DataPropertyName = "PAccural";
            this.pAccuralDataGridViewTextBoxColumn.HeaderText = "Подитог";
            this.pAccuralDataGridViewTextBoxColumn.Name = "pAccuralDataGridViewTextBoxColumn";
            // 
            // pBenefitDataGridViewTextBoxColumn
            // 
            this.pBenefitDataGridViewTextBoxColumn.DataPropertyName = "PBenefit";
            this.pBenefitDataGridViewTextBoxColumn.HeaderText = "Льгота";
            this.pBenefitDataGridViewTextBoxColumn.Name = "pBenefitDataGridViewTextBoxColumn";
            // 
            // pTotalDataGridViewTextBoxColumn
            // 
            this.pTotalDataGridViewTextBoxColumn.DataPropertyName = "PTotal";
            this.pTotalDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.pTotalDataGridViewTextBoxColumn.Name = "pTotalDataGridViewTextBoxColumn";
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // paymentTypeBindingSource
            // 
            this.paymentTypeBindingSource.DataMember = "PaymentType";
            this.paymentTypeBindingSource.DataSource = this.kRv1DataSet;
            // 
            // kRv1DataSet
            // 
            this.kRv1DataSet.DataSetName = "KRv1DataSet";
            this.kRv1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.kRv1DataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "Квартира:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 64;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(62, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 21);
            this.comboBox2.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(35, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Вид платежа:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(62, 145);
            this.maskedTextBox1.Mask = "00.0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(190, 20);
            this.maskedTextBox1.TabIndex = 67;
            // 
            // paymentTypeTableAdapter
            // 
            this.paymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTypeTableAdapter1
            // 
            this.paymentTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // PaymentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PaymentEditForm";
            this.Text = "PaymentEditForm";
            this.Load += new System.EventHandler(this.PaymentEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private KRv1DataSet kRv1DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private KRv1DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private KRv1DataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource1;
        private KRv4DataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idApartamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPaymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAccuralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBenefitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private KRv4DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter1;
    }
}
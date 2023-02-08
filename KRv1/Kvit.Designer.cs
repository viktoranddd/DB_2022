namespace KRv1
{
    partial class Kvit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.paymentTypeTableAdapter = new KRv1.KRv1DataSetTableAdapters.PaymentTypeTableAdapter();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.paymentTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PaymentTableAdapter();
            this.paymentTypeTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PaymentTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaymentTypeDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn,
            this.pTariffDataGridViewTextBoxColumn,
            this.pAccuralDataGridViewTextBoxColumn,
            this.pBenefitDataGridViewTextBoxColumn,
            this.pTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPaymentTypeDataGridViewTextBoxColumn
            // 
            this.idPaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "IdPaymentType";
            this.idPaymentTypeDataGridViewTextBoxColumn.DataSource = this.paymentTypeBindingSource1;
            this.idPaymentTypeDataGridViewTextBoxColumn.DisplayMember = "PTName";
            this.idPaymentTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idPaymentTypeDataGridViewTextBoxColumn.HeaderText = "Вид платежа";
            this.idPaymentTypeDataGridViewTextBoxColumn.Name = "idPaymentTypeDataGridViewTextBoxColumn";
            this.idPaymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPaymentTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idPaymentTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idPaymentTypeDataGridViewTextBoxColumn.ValueMember = "IdPaymentType";
            this.idPaymentTypeDataGridViewTextBoxColumn.Width = 225;
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
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "Потребление";
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            this.pAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pTariffDataGridViewTextBoxColumn
            // 
            this.pTariffDataGridViewTextBoxColumn.DataPropertyName = "PTariff";
            this.pTariffDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.pTariffDataGridViewTextBoxColumn.Name = "pTariffDataGridViewTextBoxColumn";
            this.pTariffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAccuralDataGridViewTextBoxColumn
            // 
            this.pAccuralDataGridViewTextBoxColumn.DataPropertyName = "PAccural";
            this.pAccuralDataGridViewTextBoxColumn.HeaderText = "Подитог";
            this.pAccuralDataGridViewTextBoxColumn.Name = "pAccuralDataGridViewTextBoxColumn";
            this.pAccuralDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pBenefitDataGridViewTextBoxColumn
            // 
            this.pBenefitDataGridViewTextBoxColumn.DataPropertyName = "PBenefit";
            this.pBenefitDataGridViewTextBoxColumn.HeaderText = "Льгота";
            this.pBenefitDataGridViewTextBoxColumn.Name = "pBenefitDataGridViewTextBoxColumn";
            this.pBenefitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pTotalDataGridViewTextBoxColumn
            // 
            this.pTotalDataGridViewTextBoxColumn.DataPropertyName = "PTotal";
            this.pTotalDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.pTotalDataGridViewTextBoxColumn.Name = "pTotalDataGridViewTextBoxColumn";
            this.pTotalDataGridViewTextBoxColumn.ReadOnly = true;
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
            // paymentTypeTableAdapter
            // 
            this.paymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(44, 97);
            this.maskedTextBox1.Mask = "00.0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(45, 20);
            this.maskedTextBox1.TabIndex = 71;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 21);
            this.comboBox1.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(17, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 69;
            this.label6.Text = "Квартира:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "Период:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(21, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 38);
            this.button1.TabIndex = 72;
            this.button1.Text = "Сформировать квитанцию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(349, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Количество платежей:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(349, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Подитог:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(349, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Льгота: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(349, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Итог: ";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(12, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 25);
            this.button4.TabIndex = 77;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTypeTableAdapter1
            // 
            this.paymentTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // Kvit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kvit";
            this.Text = "Kvit";
            this.Load += new System.EventHandler(this.Kvit_Load);
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

        private System.Windows.Forms.DataGridView dataGridView1;
        private KRv1DataSet kRv1DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private KRv1DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private KRv1DataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private KRv4DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource1;
        private KRv4DataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter1;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPaymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAccuralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBenefitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTotalDataGridViewTextBoxColumn;
    }
}
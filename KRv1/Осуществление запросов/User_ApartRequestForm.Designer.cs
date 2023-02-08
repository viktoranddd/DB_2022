namespace KRv1.Осуществление_запросов
{
    partial class User_ApartRequestForm
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
            this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRv1DataSet = new KRv1.KRv1DataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentTableAdapter = new KRv1.KRv1DataSetTableAdapters.PaymentTableAdapter();
            this.paymentTypeTableAdapter = new KRv1.KRv1DataSetTableAdapters.PaymentTypeTableAdapter();
            this.kRv4DataSet = new KRv1.KRv4DataSet();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PaymentTableAdapter();
            this.paymentTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTypeTableAdapter1 = new KRv1.KRv4DataSetTableAdapters.PaymentTypeTableAdapter();
            this.pPeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPaymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAccuralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBenefitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(391, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 33);
            this.button1.TabIndex = 52;
            this.button1.Text = "Вывести список задолженностей";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(308, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Общая сумма долга:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pPeriodDataGridViewTextBoxColumn,
            this.idPaymentTypeDataGridViewTextBoxColumn,
            this.pAmountDataGridViewTextBoxColumn,
            this.pTariffDataGridViewTextBoxColumn,
            this.pAccuralDataGridViewTextBoxColumn,
            this.pBenefitDataGridViewTextBoxColumn,
            this.pTotalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 263);
            this.dataGridView1.TabIndex = 49;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Имеющиеся задолженности:";
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
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTypeTableAdapter
            // 
            this.paymentTypeTableAdapter.ClearBeforeFill = true;
            // 
            // kRv4DataSet
            // 
            this.kRv4DataSet.DataSetName = "KRv4DataSet";
            this.kRv4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTypeBindingSource1
            // 
            this.paymentTypeBindingSource1.DataMember = "PaymentType";
            this.paymentTypeBindingSource1.DataSource = this.kRv4DataSet;
            // 
            // paymentTypeTableAdapter1
            // 
            this.paymentTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // pPeriodDataGridViewTextBoxColumn
            // 
            this.pPeriodDataGridViewTextBoxColumn.DataPropertyName = "PPeriod";
            this.pPeriodDataGridViewTextBoxColumn.HeaderText = "Начало периода";
            this.pPeriodDataGridViewTextBoxColumn.Name = "pPeriodDataGridViewTextBoxColumn";
            this.pPeriodDataGridViewTextBoxColumn.ReadOnly = true;
            this.pPeriodDataGridViewTextBoxColumn.Width = 115;
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
            this.idPaymentTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // pAmountDataGridViewTextBoxColumn
            // 
            this.pAmountDataGridViewTextBoxColumn.DataPropertyName = "PAmount";
            this.pAmountDataGridViewTextBoxColumn.HeaderText = "Объем пользования";
            this.pAmountDataGridViewTextBoxColumn.Name = "pAmountDataGridViewTextBoxColumn";
            this.pAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAmountDataGridViewTextBoxColumn.Width = 135;
            // 
            // pTariffDataGridViewTextBoxColumn
            // 
            this.pTariffDataGridViewTextBoxColumn.DataPropertyName = "PTariff";
            this.pTariffDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.pTariffDataGridViewTextBoxColumn.Name = "pTariffDataGridViewTextBoxColumn";
            this.pTariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.pTariffDataGridViewTextBoxColumn.Width = 75;
            // 
            // pAccuralDataGridViewTextBoxColumn
            // 
            this.pAccuralDataGridViewTextBoxColumn.DataPropertyName = "PAccural";
            this.pAccuralDataGridViewTextBoxColumn.HeaderText = "Подитог";
            this.pAccuralDataGridViewTextBoxColumn.Name = "pAccuralDataGridViewTextBoxColumn";
            this.pAccuralDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAccuralDataGridViewTextBoxColumn.Width = 75;
            // 
            // pBenefitDataGridViewTextBoxColumn
            // 
            this.pBenefitDataGridViewTextBoxColumn.DataPropertyName = "PBenefit";
            this.pBenefitDataGridViewTextBoxColumn.HeaderText = "Льгота";
            this.pBenefitDataGridViewTextBoxColumn.Name = "pBenefitDataGridViewTextBoxColumn";
            this.pBenefitDataGridViewTextBoxColumn.ReadOnly = true;
            this.pBenefitDataGridViewTextBoxColumn.Width = 75;
            // 
            // pTotalDataGridViewTextBoxColumn
            // 
            this.pTotalDataGridViewTextBoxColumn.DataPropertyName = "PTotal";
            this.pTotalDataGridViewTextBoxColumn.HeaderText = "Итог";
            this.pTotalDataGridViewTextBoxColumn.Name = "pTotalDataGridViewTextBoxColumn";
            this.pTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.pTotalDataGridViewTextBoxColumn.Width = 75;
            // 
            // User_ApartRequestForm
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
            this.Name = "User_ApartRequestForm";
            this.Text = "User_ApartRequestForm";
            this.Load += new System.EventHandler(this.User_ApartRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRv4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource1)).EndInit();
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
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private KRv1DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private KRv1DataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter;
        private KRv4DataSet kRv4DataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private KRv4DataSetTableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource1;
        private KRv4DataSetTableAdapters.PaymentTypeTableAdapter paymentTypeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPeriodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idPaymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAccuralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBenefitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTotalDataGridViewTextBoxColumn;
    }
}
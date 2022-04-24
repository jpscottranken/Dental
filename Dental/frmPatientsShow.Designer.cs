namespace Dental
{
    partial class frmPatientsShow
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.patIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gentleDentalDatabaseDataSet = new Dental.GentleDentalDatabaseDataSet();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.patientsTableAdapter = new Dental.GentleDentalDatabaseDataSetTableAdapters.PatientsTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentleDentalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AutoGenerateColumns = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patIDDataGridViewTextBoxColumn,
            this.patNameDataGridViewTextBoxColumn,
            this.patEmailDataGridViewTextBoxColumn,
            this.patPhoneDataGridViewTextBoxColumn});
            this.dgvPatients.DataSource = this.patientsBindingSource;
            this.dgvPatients.Location = new System.Drawing.Point(12, 36);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.Size = new System.Drawing.Size(773, 404);
            this.dgvPatients.TabIndex = 0;
            // 
            // patIDDataGridViewTextBoxColumn
            // 
            this.patIDDataGridViewTextBoxColumn.DataPropertyName = "PatID";
            this.patIDDataGridViewTextBoxColumn.HeaderText = "PatID";
            this.patIDDataGridViewTextBoxColumn.Name = "patIDDataGridViewTextBoxColumn";
            this.patIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patNameDataGridViewTextBoxColumn
            // 
            this.patNameDataGridViewTextBoxColumn.DataPropertyName = "PatName";
            this.patNameDataGridViewTextBoxColumn.HeaderText = "PatName";
            this.patNameDataGridViewTextBoxColumn.Name = "patNameDataGridViewTextBoxColumn";
            this.patNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patEmailDataGridViewTextBoxColumn
            // 
            this.patEmailDataGridViewTextBoxColumn.DataPropertyName = "PatEmail";
            this.patEmailDataGridViewTextBoxColumn.HeaderText = "PatEmail";
            this.patEmailDataGridViewTextBoxColumn.Name = "patEmailDataGridViewTextBoxColumn";
            this.patEmailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patPhoneDataGridViewTextBoxColumn
            // 
            this.patPhoneDataGridViewTextBoxColumn.DataPropertyName = "PatPhone";
            this.patPhoneDataGridViewTextBoxColumn.HeaderText = "PatPhone";
            this.patPhoneDataGridViewTextBoxColumn.Name = "patPhoneDataGridViewTextBoxColumn";
            this.patPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.gentleDentalDatabaseDataSet;
            // 
            // gentleDentalDatabaseDataSet
            // 
            this.gentleDentalDatabaseDataSet.DataSetName = "GentleDentalDatabaseDataSet";
            this.gentleDentalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Location = new System.Drawing.Point(401, 7);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(115, 21);
            this.btnEditPatient.TabIndex = 1;
            this.btnEditPatient.Text = "Edit Patient";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            this.btnEditPatient.Click += new System.EventHandler(this.btnEditPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeletePatient.Location = new System.Drawing.Point(535, 7);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(115, 21);
            this.btnDeletePatient.TabIndex = 2;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(670, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 21);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPatientsShow
            // 
            this.AcceptButton = this.btnEditPatient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnDeletePatient;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnEditPatient);
            this.Controls.Add(this.dgvPatients);
            this.Name = "frmPatientsShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients Main Form";
            this.Load += new System.EventHandler(this.frmPatientsShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentleDentalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private GentleDentalDatabaseDataSet gentleDentalDatabaseDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private GentleDentalDatabaseDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClose;
    }
}
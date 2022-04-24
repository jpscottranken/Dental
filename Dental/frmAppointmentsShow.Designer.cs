namespace Dental
{
    partial class frmAppointmentsShow
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
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.apptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apptScheduledDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gentleDentalDatabaseDataSet = new Dental.GentleDentalDatabaseDataSet();
            this.btnAllAppointments = new System.Windows.Forms.Button();
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboPatientName = new System.Windows.Forms.ComboBox();
            this.appointmentsTableAdapter = new Dental.GentleDentalDatabaseDataSetTableAdapters.AppointmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentleDentalDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoGenerateColumns = false;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apptIDDataGridViewTextBoxColumn,
            this.aTTypeIDDataGridViewTextBoxColumn,
            this.apptDescriptionDataGridViewTextBoxColumn,
            this.patIDDataGridViewTextBoxColumn,
            this.apptScheduledDataGridViewTextBoxColumn});
            this.dgvAppointments.DataSource = this.appointmentsBindingSource;
            this.dgvAppointments.Location = new System.Drawing.Point(12, 36);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.Size = new System.Drawing.Size(773, 404);
            this.dgvAppointments.TabIndex = 0;
            // 
            // apptIDDataGridViewTextBoxColumn
            // 
            this.apptIDDataGridViewTextBoxColumn.DataPropertyName = "ApptID";
            this.apptIDDataGridViewTextBoxColumn.HeaderText = "ApptID";
            this.apptIDDataGridViewTextBoxColumn.Name = "apptIDDataGridViewTextBoxColumn";
            this.apptIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aTTypeIDDataGridViewTextBoxColumn
            // 
            this.aTTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ATTypeID";
            this.aTTypeIDDataGridViewTextBoxColumn.HeaderText = "ATTypeID";
            this.aTTypeIDDataGridViewTextBoxColumn.Name = "aTTypeIDDataGridViewTextBoxColumn";
            this.aTTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apptDescriptionDataGridViewTextBoxColumn
            // 
            this.apptDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ApptDescription";
            this.apptDescriptionDataGridViewTextBoxColumn.HeaderText = "ApptDescription";
            this.apptDescriptionDataGridViewTextBoxColumn.Name = "apptDescriptionDataGridViewTextBoxColumn";
            this.apptDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patIDDataGridViewTextBoxColumn
            // 
            this.patIDDataGridViewTextBoxColumn.DataPropertyName = "PatID";
            this.patIDDataGridViewTextBoxColumn.HeaderText = "PatID";
            this.patIDDataGridViewTextBoxColumn.Name = "patIDDataGridViewTextBoxColumn";
            this.patIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apptScheduledDataGridViewTextBoxColumn
            // 
            this.apptScheduledDataGridViewTextBoxColumn.DataPropertyName = "ApptScheduled";
            this.apptScheduledDataGridViewTextBoxColumn.HeaderText = "ApptScheduled";
            this.apptScheduledDataGridViewTextBoxColumn.Name = "apptScheduledDataGridViewTextBoxColumn";
            this.apptScheduledDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments";
            this.appointmentsBindingSource.DataSource = this.gentleDentalDatabaseDataSet;
            // 
            // gentleDentalDatabaseDataSet
            // 
            this.gentleDentalDatabaseDataSet.DataSetName = "GentleDentalDatabaseDataSet";
            this.gentleDentalDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAllAppointments
            // 
            this.btnAllAppointments.Location = new System.Drawing.Point(12, 9);
            this.btnAllAppointments.Name = "btnAllAppointments";
            this.btnAllAppointments.Size = new System.Drawing.Size(81, 21);
            this.btnAllAppointments.TabIndex = 1;
            this.btnAllAppointments.Text = "All";
            this.btnAllAppointments.UseVisualStyleBackColor = true;
            this.btnAllAppointments.Click += new System.EventHandler(this.btnAllAppointments_Click);
            // 
            // btnEditAppointment
            // 
            this.btnEditAppointment.Location = new System.Drawing.Point(401, 7);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(115, 21);
            this.btnEditAppointment.TabIndex = 2;
            this.btnEditAppointment.Text = "Edit Appointment";
            this.btnEditAppointment.UseVisualStyleBackColor = true;
            this.btnEditAppointment.Click += new System.EventHandler(this.btnEditAppointment_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(535, 7);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(115, 21);
            this.btnDeleteAppointment.TabIndex = 3;
            this.btnDeleteAppointment.Text = "Delete Appointment";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(670, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 21);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboPatientName
            // 
            this.cboPatientName.FormattingEnabled = true;
            this.cboPatientName.Location = new System.Drawing.Point(113, 7);
            this.cboPatientName.Name = "cboPatientName";
            this.cboPatientName.Size = new System.Drawing.Size(264, 21);
            this.cboPatientName.TabIndex = 5;
            this.cboPatientName.SelectedIndexChanged += new System.EventHandler(this.cboPatientName_SelectedIndexChanged);
            // 
            // appointmentsTableAdapter
            // 
            this.appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAppointmentsShow
            // 
            this.AcceptButton = this.btnAllAppointments;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboPatientName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnEditAppointment);
            this.Controls.Add(this.btnAllAppointments);
            this.Controls.Add(this.dgvAppointments);
            this.Name = "frmAppointmentsShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments Main Form";
            this.Load += new System.EventHandler(this.frmAppointmentsShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gentleDentalDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAllAppointments;
        private System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboPatientName;
        private GentleDentalDatabaseDataSet gentleDentalDatabaseDataSet;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private GentleDentalDatabaseDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apptScheduledDataGridViewTextBoxColumn;
    }
}
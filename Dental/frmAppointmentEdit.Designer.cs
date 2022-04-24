namespace Dental
{
    partial class frmAppointmentEdit
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
            this.lblAppointmentDesc = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblScheduledDay = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAppointmentDesc = new System.Windows.Forms.TextBox();
            this.lblTheAppointmentID = new System.Windows.Forms.Label();
            this.lblAppointmentType = new System.Windows.Forms.Label();
            this.cboAppointmentType = new System.Windows.Forms.ComboBox();
            this.cboPatientName = new System.Windows.Forms.ComboBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblScheduledTIme = new System.Windows.Forms.Label();
            this.cboAppointmentTime = new System.Windows.Forms.ComboBox();
            this.dtpAppointmentDay = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblAppointmentDesc
            // 
            this.lblAppointmentDesc.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDesc.Location = new System.Drawing.Point(100, 158);
            this.lblAppointmentDesc.Name = "lblAppointmentDesc";
            this.lblAppointmentDesc.Size = new System.Drawing.Size(255, 29);
            this.lblAppointmentDesc.TabIndex = 7;
            this.lblAppointmentDesc.Text = "Appointment Desc:";
            this.lblAppointmentDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPatientID
            // 
            this.lblPatientID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(100, 254);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(255, 29);
            this.lblPatientID.TabIndex = 8;
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScheduledDay
            // 
            this.lblScheduledDay.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledDay.Location = new System.Drawing.Point(100, 329);
            this.lblScheduledDay.Name = "lblScheduledDay";
            this.lblScheduledDay.Size = new System.Drawing.Size(255, 29);
            this.lblScheduledDay.TabIndex = 9;
            this.lblScheduledDay.Text = "Scheduled Day:";
            this.lblScheduledDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(100, 45);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(255, 29);
            this.lblAppointmentID.TabIndex = 6;
            this.lblAppointmentID.Text = "Appointment ID:";
            this.lblAppointmentID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(457, 508);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(690, 508);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 50);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAppointmentDesc
            // 
            this.txtAppointmentDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAppointmentDesc.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentDesc.Location = new System.Drawing.Point(368, 117);
            this.txtAppointmentDesc.Multiline = true;
            this.txtAppointmentDesc.Name = "txtAppointmentDesc";
            this.txtAppointmentDesc.Size = new System.Drawing.Size(721, 111);
            this.txtAppointmentDesc.TabIndex = 0;
            // 
            // lblTheAppointmentID
            // 
            this.lblTheAppointmentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTheAppointmentID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheAppointmentID.Location = new System.Drawing.Point(368, 45);
            this.lblTheAppointmentID.Name = "lblTheAppointmentID";
            this.lblTheAppointmentID.Size = new System.Drawing.Size(220, 29);
            this.lblTheAppointmentID.TabIndex = 5;
            // 
            // lblAppointmentType
            // 
            this.lblAppointmentType.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lblAppointmentType.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentType.Location = new System.Drawing.Point(100, 414);
            this.lblAppointmentType.Name = "lblAppointmentType";
            this.lblAppointmentType.Size = new System.Drawing.Size(255, 29);
            this.lblAppointmentType.TabIndex = 11;
            this.lblAppointmentType.Text = "Appointment Type:";
            this.lblAppointmentType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboAppointmentType
            // 
            this.cboAppointmentType.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAppointmentType.FormattingEnabled = true;
            this.cboAppointmentType.Location = new System.Drawing.Point(368, 414);
            this.cboAppointmentType.Name = "cboAppointmentType";
            this.cboAppointmentType.Size = new System.Drawing.Size(316, 37);
            this.cboAppointmentType.TabIndex = 12;
            // 
            // cboPatientName
            // 
            this.cboPatientName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatientName.FormattingEnabled = true;
            this.cboPatientName.Location = new System.Drawing.Point(867, 414);
            this.cboPatientName.Name = "cboPatientName";
            this.cboPatientName.Size = new System.Drawing.Size(221, 37);
            this.cboPatientName.TabIndex = 14;
            // 
            // lblPatientName
            // 
            this.lblPatientName.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.lblPatientName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(695, 417);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(166, 29);
            this.lblPatientName.TabIndex = 13;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScheduledTIme
            // 
            this.lblScheduledTIme.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledTIme.Location = new System.Drawing.Point(690, 332);
            this.lblScheduledTIme.Name = "lblScheduledTIme";
            this.lblScheduledTIme.Size = new System.Drawing.Size(171, 29);
            this.lblScheduledTIme.TabIndex = 15;
            this.lblScheduledTIme.Text = "Scheduled TIme:";
            this.lblScheduledTIme.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboAppointmentTime
            // 
            this.cboAppointmentTime.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAppointmentTime.FormattingEnabled = true;
            this.cboAppointmentTime.Items.AddRange(new object[] {
            "8:00 AM",
            "8:30 AM",
            "9:00 AM",
            "9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "1:00 PM",
            "1:30 PM",
            "2:00 PM",
            "2:30 PM",
            "3:00 PM",
            "3:30 PM",
            "4:00 PM",
            "4:30 PM"});
            this.cboAppointmentTime.Location = new System.Drawing.Point(867, 329);
            this.cboAppointmentTime.Name = "cboAppointmentTime";
            this.cboAppointmentTime.Size = new System.Drawing.Size(221, 37);
            this.cboAppointmentTime.TabIndex = 16;
            // 
            // dtpAppointmentDay
            // 
            this.dtpAppointmentDay.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDay.Location = new System.Drawing.Point(368, 332);
            this.dtpAppointmentDay.Name = "dtpAppointmentDay";
            this.dtpAppointmentDay.Size = new System.Drawing.Size(316, 35);
            this.dtpAppointmentDay.TabIndex = 17;
            // 
            // frmAppointmentEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1262, 664);
            this.Controls.Add(this.dtpAppointmentDay);
            this.Controls.Add(this.cboAppointmentTime);
            this.Controls.Add(this.lblScheduledTIme);
            this.Controls.Add(this.cboPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.cboAppointmentType);
            this.Controls.Add(this.lblAppointmentType);
            this.Controls.Add(this.lblTheAppointmentID);
            this.Controls.Add(this.txtAppointmentDesc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.lblScheduledDay);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblAppointmentDesc);
            this.Name = "frmAppointmentEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Exiting Appointment Form";
            this.Load += new System.EventHandler(this.frmAppointmentEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentDesc;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblScheduledDay;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAppointmentDesc;
        private System.Windows.Forms.Label lblTheAppointmentID;
        private System.Windows.Forms.Label lblAppointmentType;
        private System.Windows.Forms.ComboBox cboAppointmentType;
        private System.Windows.Forms.ComboBox cboPatientName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblScheduledTIme;
        private System.Windows.Forms.ComboBox cboAppointmentTime;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDay;
    }
}
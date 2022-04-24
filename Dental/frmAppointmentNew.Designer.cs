namespace Dental
{
    partial class frmAppointmentNew
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
            this.txtAppointmentDesc = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblScheduledDay = new System.Windows.Forms.Label();
            this.lblAppointmentDesc = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpAppointmentDay = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentType = new System.Windows.Forms.Label();
            this.cboAppointmentType = new System.Windows.Forms.ComboBox();
            this.lblScheduledTime = new System.Windows.Forms.Label();
            this.cboAppointmentTime = new System.Windows.Forms.ComboBox();
            this.cboPatientName = new System.Windows.Forms.ComboBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAppointmentDesc
            // 
            this.txtAppointmentDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAppointmentDesc.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentDesc.Location = new System.Drawing.Point(367, 114);
            this.txtAppointmentDesc.Multiline = true;
            this.txtAppointmentDesc.Name = "txtAppointmentDesc";
            this.txtAppointmentDesc.Size = new System.Drawing.Size(721, 111);
            this.txtAppointmentDesc.TabIndex = 0;
            // 
            // lblPatientID
            // 
            this.lblPatientID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientID.Location = new System.Drawing.Point(100, 254);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(255, 29);
            this.lblPatientID.TabIndex = 6;
            this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblScheduledDay
            // 
            this.lblScheduledDay.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledDay.Location = new System.Drawing.Point(100, 332);
            this.lblScheduledDay.Name = "lblScheduledDay";
            this.lblScheduledDay.Size = new System.Drawing.Size(255, 29);
            this.lblScheduledDay.TabIndex = 7;
            this.lblScheduledDay.Text = "Scheduled Day:";
            this.lblScheduledDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAppointmentDesc
            // 
            this.lblAppointmentDesc.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDesc.Location = new System.Drawing.Point(100, 158);
            this.lblAppointmentDesc.Name = "lblAppointmentDesc";
            this.lblAppointmentDesc.Size = new System.Drawing.Size(255, 29);
            this.lblAppointmentDesc.TabIndex = 5;
            this.lblAppointmentDesc.Text = "Appointment Desc:";
            this.lblAppointmentDesc.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // dtpAppointmentDay
            // 
            this.dtpAppointmentDay.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAppointmentDay.Location = new System.Drawing.Point(368, 332);
            this.dtpAppointmentDay.Name = "dtpAppointmentDay";
            this.dtpAppointmentDay.Size = new System.Drawing.Size(316, 35);
            this.dtpAppointmentDay.TabIndex = 8;
            // 
            // lblAppointmentType
            // 
            this.lblAppointmentType.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentType.Location = new System.Drawing.Point(100, 414);
            this.lblAppointmentType.Name = "lblAppointmentType";
            this.lblAppointmentType.Size = new System.Drawing.Size(255, 29);
            this.lblAppointmentType.TabIndex = 9;
            this.lblAppointmentType.Text = "Appointment Type:";
            this.lblAppointmentType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboAppointmentType
            // 
            this.cboAppointmentType.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAppointmentType.FormattingEnabled = true;
            this.cboAppointmentType.Location = new System.Drawing.Point(368, 414);
            this.cboAppointmentType.Name = "cboAppointmentType";
            this.cboAppointmentType.Size = new System.Drawing.Size(220, 37);
            this.cboAppointmentType.TabIndex = 10;
            // 
            // lblScheduledTime
            // 
            this.lblScheduledTime.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduledTime.Location = new System.Drawing.Point(690, 332);
            this.lblScheduledTime.Name = "lblScheduledTime";
            this.lblScheduledTime.Size = new System.Drawing.Size(171, 29);
            this.lblScheduledTime.TabIndex = 11;
            this.lblScheduledTime.Text = "Scheduled Time:";
            this.lblScheduledTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.cboAppointmentTime.TabIndex = 12;
            // 
            // cboPatientName
            // 
            this.cboPatientName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPatientName.FormattingEnabled = true;
            this.cboPatientName.Location = new System.Drawing.Point(867, 414);
            this.cboPatientName.Name = "cboPatientName";
            this.cboPatientName.Size = new System.Drawing.Size(221, 37);
            this.cboPatientName.TabIndex = 13;
            // 
            // lblPatientName
            // 
            this.lblPatientName.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(695, 417);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(166, 29);
            this.lblPatientName.TabIndex = 14;
            this.lblPatientName.Text = "Patient Name:";
            this.lblPatientName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAppointmentNew
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1262, 664);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.cboPatientName);
            this.Controls.Add(this.cboAppointmentTime);
            this.Controls.Add(this.lblScheduledTime);
            this.Controls.Add(this.cboAppointmentType);
            this.Controls.Add(this.lblAppointmentType);
            this.Controls.Add(this.dtpAppointmentDay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAppointmentDesc);
            this.Controls.Add(this.lblScheduledDay);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtAppointmentDesc);
            this.Name = "frmAppointmentNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Appointment Form";
            this.Load += new System.EventHandler(this.frmAppointmentNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppointmentDesc;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblScheduledDay;
        private System.Windows.Forms.Label lblAppointmentDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDay;
        private System.Windows.Forms.Label lblAppointmentType;
        private System.Windows.Forms.ComboBox cboAppointmentType;
        private System.Windows.Forms.Label lblScheduledTime;
        private System.Windows.Forms.ComboBox cboAppointmentTime;
        private System.Windows.Forms.ComboBox cboPatientName;
        private System.Windows.Forms.Label lblPatientName;
    }
}
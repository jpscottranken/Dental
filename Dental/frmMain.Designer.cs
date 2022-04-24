namespace Dental
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.showAllPatientsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPatientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllAppointmentsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAppointmentMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsMenu,
            this.appointmentsMenu,
            this.helpMenu,
            this.exitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // patientsMenu
            // 
            this.patientsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllPatientsMenu,
            this.addNewPatientMenu});
            this.patientsMenu.Name = "patientsMenu";
            this.patientsMenu.Size = new System.Drawing.Size(61, 20);
            this.patientsMenu.Text = "Patients";
            // 
            // appointmentsMenu
            // 
            this.appointmentsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllAppointmentsMenu,
            this.addNewAppointmentMenu});
            this.appointmentsMenu.Name = "appointmentsMenu";
            this.appointmentsMenu.Size = new System.Drawing.Size(95, 20);
            this.appointmentsMenu.Text = "Appointments";
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(38, 20);
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.exitMenu_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(6, 26);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(793, 421);
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // showAllPatientsMenu
            // 
            this.showAllPatientsMenu.Name = "showAllPatientsMenu";
            this.showAllPatientsMenu.Size = new System.Drawing.Size(180, 22);
            this.showAllPatientsMenu.Text = "Show All Patients";
            this.showAllPatientsMenu.Click += new System.EventHandler(this.showAllPatientsMenu_Click);
            // 
            // addNewPatientMenu
            // 
            this.addNewPatientMenu.Name = "addNewPatientMenu";
            this.addNewPatientMenu.Size = new System.Drawing.Size(180, 22);
            this.addNewPatientMenu.Text = "Add New Patient";
            this.addNewPatientMenu.Click += new System.EventHandler(this.addNewPatientMenu_Click);
            // 
            // showAllAppointmentsMenu
            // 
            this.showAllAppointmentsMenu.Name = "showAllAppointmentsMenu";
            this.showAllAppointmentsMenu.Size = new System.Drawing.Size(199, 22);
            this.showAllAppointmentsMenu.Text = "Show All Appointments";
            this.showAllAppointmentsMenu.Click += new System.EventHandler(this.showAllAppointmentsMenu_Click);
            // 
            // addNewAppointmentMenu
            // 
            this.addNewAppointmentMenu.Name = "addNewAppointmentMenu";
            this.addNewAppointmentMenu.Size = new System.Drawing.Size(199, 22);
            this.addNewAppointmentMenu.Text = "Add New Appointment";
            this.addNewAppointmentMenu.Click += new System.EventHandler(this.addNewAppointmentMenu_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form - Gentle Dental";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsMenu;
        private System.Windows.Forms.ToolStripMenuItem showAllPatientsMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewPatientMenu;
        private System.Windows.Forms.ToolStripMenuItem appointmentsMenu;
        private System.Windows.Forms.ToolStripMenuItem showAllAppointmentsMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewAppointmentMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}


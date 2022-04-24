using System;
using System.Windows.Forms;

namespace Dental
{
    public partial class frmAppointmentEdit : Form
    {
        public int AppointmentID { get; set; }
        private Appointments appointment;
        private AppointmentTypes appointmentType;
        private Patients patients;

        public frmAppointmentEdit()
        {
            InitializeComponent();
            appointment = new Appointments();
            appointmentType = new AppointmentTypes();
            patients = new Patients();
        }

        private void frmAppointmentEdit_Load(object sender, EventArgs e)
        {
            cboAppointmentType.DataSource = appointmentType.Items;
            cboAppointmentType.DisplayMember = "ATDescription";
            cboAppointmentType.ValueMember = "ATTypeID";

            cboPatientName.DataSource = patients.Items;
            cboPatientName.DisplayMember = "PatName";
            cboPatientName.ValueMember = "PatID";

            var row = appointment.FindByApptID(AppointmentID);
            dtpAppointmentDay.Value = row.ApptScheduled;
            txtAppointmentDesc.Text = row.ApptDescription;
            //cboAppointmentTime.SelectedValue = row.
            cboAppointmentType.SelectedValue = row.ATTypeID;
            cboPatientName.SelectedValue = row.PatID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            attemptToSaveAppointmentRecord();
        }

        private void attemptToSaveAppointmentRecord()
        {
            DateTime scheduledAt;

            try
            {
                scheduledAt = Appointments.CombineDateTime(
                    dtpAppointmentDay.Value.Date,
                    Convert.ToDateTime(cboAppointmentTime.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter A Valid Date And Time\n\n" +
                                ex.Message,
                                "APPOINTMENT DATE AND/OR TIME ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var atTypeID = Convert.ToInt32(cboAppointmentType.SelectedValue);
            var patID = Convert.ToInt32(cboPatientName.SelectedValue);

            if (appointment.Update(AppointmentID,
                                   atTypeID,
                                   txtAppointmentDesc.Text,
                                   patID,
                                   scheduledAt))
            {
                MessageBox.Show("Existing record has been updated",
                                "APPOINTMENT UPDATED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                Close();
            }
            else
            {
                MessageBox.Show("Unable to update existing record",
                                "APPOINTMENT UPDATE ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

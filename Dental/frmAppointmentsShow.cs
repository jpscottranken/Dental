using System;
using System.Windows.Forms;

namespace Dental
{
    public partial class frmAppointmentsShow : Form
    {
        private Appointments appointment;
        private Patients patient;
        private bool formLoading;
        private bool keepGoing;

        public frmAppointmentsShow()
        {
            InitializeComponent();
            appointment = new Appointments();
            patient = new Patients();
            formLoading = true;
        }

        private void frmAppointmentsShow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gentleDentalDatabaseDataSet.Appointments' table. You can move, or remove it, as needed.
            //this.appointmentsTableAdapter.Fill(this.gentleDentalDatabaseDataSet.Appointments);
            cboPatientName.DataSource = patient.Items;
            cboPatientName.DisplayMember = "PatName";
            cboPatientName.ValueMember = "PatID";
            cboPatientName.SelectedIndex = -1;
            formLoading = false;
        }

        private void btnAllAppointments_Click(object sender, EventArgs e)
        {
            dgvAppointments.DataSource = appointment.Items;
            formLoading = true;
            cboPatientName.SelectedIndex = -1;
            formLoading = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboPatientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                var patientID = Convert.ToInt32(cboPatientName.SelectedValue);
                //MessageBox.Show("***DEBUG***The selected Patient ID is: " + patientID.ToString(),
                //           "PATIENT ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvAppointments.DataSource = appointment.GetByPatientID(patientID);
            }
            else
            {
                cboPatientName.SelectedIndex = -1;
            }
        }

        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            attemptToEditRecord();
        }

        private void attemptToEditRecord()
        {
            //  User must select a row to edit
            keepGoing = isAppointmentRowSelected(1);

            if (!keepGoing)
            {
                return;
            }

            var appointmentID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);
            var frmEditAppt = new frmAppointmentEdit();
            frmEditAppt.AppointmentID = appointmentID;
            frmEditAppt.ShowDialog();
            dgvAppointments.DataSource = appointment.Items;
            var patientID = Convert.ToInt32(cboPatientName.SelectedValue);
            dgvAppointments.DataSource = appointment.GetByPatientID(patientID);
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            attemptToDeleteRecord();
        }

        private void attemptToDeleteRecord()
        {
            //  User must select a row to edit
            bool keepGoing = isAppointmentRowSelected(2);

            if (!keepGoing)
            {
                return;
            }

            var appointmentID = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);

            if (appointment.Delete(appointmentID))
            {
                dgvAppointments.DataSource = appointment.Items;
                var patientID = Convert.ToInt32(cboPatientName.SelectedValue);
                dgvAppointments.DataSource = appointment.GetByPatientID(patientID);
                MessageBox.Show("The selected appointment has been deleted",
                                "APPOINTMENT DELETED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The selected appointment cannot be deleted",
                                "APPOINTMENT NOT DELETED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool isAppointmentRowSelected(int type)
        {
            string value;
            bool retVal = true;

            switch (type)
            {
                case 1:
                    value = "Edit";
                    break;

                case 2:
                    value = "Delete";
                    break;

                default:
                    return false;
            }

            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Row Selected To Attempt " + value,
                                "NO ROW SELECTED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                retVal = false;
            }

            return retVal;
        }
    }
}

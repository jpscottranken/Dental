using System;
using System.Windows.Forms;

namespace Dental
{
    public partial class frmPatientNew : Form
    {
        public frmPatientNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            attemptToSavePatientRecord();
        }

        private void attemptToSavePatientRecord()
        {
            var patient = new Patients();
            var patientID = patient.NextPatientID;

            if (patient.Insert(patientID, txtPatientName.Text,
                txtPatientEmail.Text, txtPatientPhone.Text))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelOperation();
        }

        private void cancelOperation()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace Dental
{
    public partial class frmPatientEdit : Form
    {
        public int PatientID { get; set; }
        private Patients patient;

        public frmPatientEdit()
        {
            InitializeComponent();
            patient = new Patients();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            attemptToSavePatientRecord();
        }

        private void attemptToSavePatientRecord()
        {
            if (patient.Update(PatientID,
                               txtPatientName.Text,
                               txtEmail.Text,
                               txtPhone.Text))
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

        private void frmPatientEdit_Load(object sender, EventArgs e)
        {
            var row = patient.FindByID(PatientID);
            lblThePatientID.Text = row.PatID.ToString();
            txtPatientName.Text = row.PatName;
            txtEmail.Text = row.PatEmail;
            txtPhone.Text = row.PatPhone;
        }
    }
}

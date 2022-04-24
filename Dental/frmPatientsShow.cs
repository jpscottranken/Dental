using System;
using System.Windows.Forms;

namespace Dental
{
    public partial class frmPatientsShow : Form
    {
        private Patients patient;

        public frmPatientsShow()
        {
            InitializeComponent();
            patient = new Patients();
        }

        private void frmPatientsShow_Load(object sender, EventArgs e)
        {
            // Load data into the 'gentleDentalDatabaseDataSet.Patients' table.
            this.patientsTableAdapter.Fill(this.gentleDentalDatabaseDataSet.Patients);
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            attemptToEditPatientRecord();
        }

        private void attemptToEditPatientRecord()
        {
            //  User must select a row to edit
            bool keepGoing = isPatientRowSelected(1);

            if (!keepGoing)
            {
                return;
            }

            //  Instantiate new instance of edit patient form
            var frmEditPat = new frmPatientEdit()
            {
                PatientID = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value)
            };

            if (frmEditPat.ShowDialog() == DialogResult.OK)
            {
                patientsTableAdapter.Fill(this.gentleDentalDatabaseDataSet.Patients);
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            attemptToDeletePatientRecord();
        }

        private void attemptToDeletePatientRecord()
        {
            //  User must select a row to delete
            bool keepGoing = isPatientRowSelected(2);

            if (!keepGoing)
            {
                return;
            }

            var PatientID = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells[0].Value);

            if (patient.Delete(PatientID))
            {
                dgvPatients.DataSource = patient.Items;
                MessageBox.Show("Patient WAS Deleted",
                                "SUCCESSFUL PATIENT DELETION",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            { 
                MessageBox.Show("Patient NOT Deleted",
                "UNSUCCESSFUL PATIENT DELETION",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }

        }

        private bool isPatientRowSelected(int type)
        {
            string value = "";
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


            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("No Row Selected To Attempt " + value,
                                "NO ROW SELECTED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                retVal = false;
            }

            return retVal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

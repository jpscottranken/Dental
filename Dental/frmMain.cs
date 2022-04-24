using System;
using System.Windows.Forms;

namespace Dental
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void showAllPatientsMenu_Click(object sender, EventArgs e)
        {
            var frmShowAllPatients = new frmPatientsShow();
            frmShowAllPatients.ShowDialog();
        }

        private void addNewPatientMenu_Click(object sender, EventArgs e)
        {
            var frmShowAllPatients = new frmPatientsShow();
            var frmNewPatient  = new frmPatientNew();

            if (frmNewPatient.ShowDialog() == DialogResult.OK)
            {
                frmShowAllPatients.ShowDialog();
            }
        }

        private void showAllAppointmentsMenu_Click(object sender, EventArgs e)
        {
            var frmShowAllAppts = new frmAppointmentsShow();
            frmShowAllAppts.ShowDialog();
        }

        private void addNewAppointmentMenu_Click(object sender, EventArgs e)
        {
            var frmShowAllAppts = new frmAppointmentsShow();
            var frmNewAppt  = new frmAppointmentNew();

            if (frmNewAppt.ShowDialog() == DialogResult.OK)
            {
                frmShowAllAppts.ShowDialog();
            }
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Your Own Help Screen Here",
                            "HELP SCREEN",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void exitMenu_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void exitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

using Dental.GentleDentalDatabaseDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;
using static Dental.GentleDentalDatabaseDataSet;

namespace Dental
{
    public class Patients
    {
        //  Instance variables
        private readonly PatientsTableAdapter adapter;
        PatientsRow originalPatientRow;

        //  Constructor
        public Patients()
        {
            adapter = new PatientsTableAdapter();
        }

        public DataTable Items
        {
            get
            {
                DataTable table = adapter.GetData();
                table.DefaultView.Sort = "PatName";
                return table;
            }
        }

        public int NextPatientID
        {
            get
            {
                var lastPatientID = adapter.GetLastPatID();
                const int INCREMENT_VALUE = 1;

                if (lastPatientID == 0)
                {
                    return 500;
                }
                else
                {
                    return Convert.ToInt32(lastPatientID + INCREMENT_VALUE);
                }
            }
        }

        public PatientsRow FindByID(int PatID)
        {
            var table = adapter.FindByID(PatID);
            return (PatientsRow)table.Rows[0];
        }

        public bool Insert(int PatID,
                           string PatName,
                           string PatEmail,
                           string PatPhone)
        {
            try
            {
                adapter.Insert(PatID, PatName, PatEmail, PatPhone);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting New Patient:\n\n" +
                                ex.Message,
                                "PATIENT INSERTION ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(int PatID,
                           string PatName,
                           string PatEmail,
                           string PatPhone)
        {
            try
            {
                originalPatientRow = adapter.GetData().FindByPatID(PatID);
                adapter.Update(PatID,
                               PatName,
                               PatEmail,
                               PatPhone,
                               originalPatientRow.PatID,
                               originalPatientRow.PatName,
                               originalPatientRow.PatEmail,
                               originalPatientRow.PatPhone);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Existing Patient:\n\n" +
                                ex.Message,
                                "PATIENT UPDATE ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(int PatID)
        {
            var rowsAffected = 0;

            if (MessageBox.Show("Delete This Customer???",
                                "DELETE CUSTOMER",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                originalPatientRow = adapter.GetData().FindByPatID(PatID);

                if (adapter.PatientHasAppointment(originalPatientRow.PatID) != null)
                {
                    MessageBox.Show("Cannot Delete Patient As S/He Has Appointments:\n\n",
                                "PATIENT DELETE ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    return false;
                }

                rowsAffected = adapter.Delete(originalPatientRow.PatID,
                                              originalPatientRow.PatName,
                                              originalPatientRow.PatEmail,
                                              originalPatientRow.PatPhone);
            }

            return rowsAffected > 0;

        }
    }
}

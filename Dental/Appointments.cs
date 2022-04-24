using Dental.GentleDentalDatabaseDataSetTableAdapters;
using System;
using System.Data;
using System.Windows.Forms;
using static Dental.GentleDentalDatabaseDataSet;

namespace Dental
{
    public class Appointments
    {
        //  Instance variable
        private readonly AppointmentsTableAdapter adapter;
        private AppointmentsRow originalAppointmentRow;

        //  Constructor
        public Appointments()
        {
            adapter = new AppointmentsTableAdapter();
        }

        public DataTable Items => adapter.GetData();

        public DataTable GetByPatientID(int PatID)
        {
            var table = adapter.GetData();
            table.DefaultView.RowFilter = "PatID = " + PatID;
            return table;
        }

        public AppointmentsRow FindByApptID(int ApptID)
        {
            var table = adapter.GetData().FindByApptID(ApptID);
            return table;
        }

        public bool Insert(int ATTypeID,
                           string ApptDescription,
                           int PatID,
                           DateTime ApptScheduled)
        {
            try
            {
                adapter.Insert(ATTypeID,
                               ApptDescription,
                               PatID,
                               ApptScheduled);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting New Appointment:\n\n" +
                                ex.Message,
                                "APPOINTMENT INSERTION ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(int ApptID,
                           int ATTypeID,
                           string ApptDescription,
                           int PatID,
                           DateTime ApptScheduled)
        {
            try
            {
                originalAppointmentRow = adapter.GetData().FindByApptID(ApptID);
                adapter.Update(ATTypeID,
                               ApptDescription,
                               PatID,
                               ApptScheduled,
                               originalAppointmentRow.ApptID,
                               originalAppointmentRow.ATTypeID,
                               originalAppointmentRow.ApptDescription,
                               originalAppointmentRow.PatID,
                               originalAppointmentRow.ApptScheduled);
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

        public bool Delete(int ApptID)
        {
            var rowsAffected = 0;

            if (MessageBox.Show("Delete This Appointment???",
                                "DELETE APPOINTMENT",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                originalAppointmentRow = adapter.GetData().FindByApptID(ApptID);

                rowsAffected = adapter.Delete(originalAppointmentRow.ApptID,
                                              originalAppointmentRow.ATTypeID,
                                              originalAppointmentRow.ApptDescription,
                                              originalAppointmentRow.PatID,
                                              originalAppointmentRow.ApptScheduled);
            }

            return rowsAffected > 0;

        }

        public static DateTime CombineDateTime(DateTime aDate, DateTime aTime)
        {
            var ts = new TimeSpan(aTime.Hour, aTime.Minute, 0);
            return aDate.Add(ts);
        }
    }
}

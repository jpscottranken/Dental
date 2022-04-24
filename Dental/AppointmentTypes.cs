using Dental.GentleDentalDatabaseDataSetTableAdapters;
using System.Data;

namespace Dental
{
    public class AppointmentTypes
    {
        //  Instance variable
        private readonly AppointmentTypeTableAdapter adapter;

        //  Constructor
        public AppointmentTypes()
        {
            adapter = new AppointmentTypeTableAdapter();
        }

        public DataTable Items
        {
            get
            {
                DataTable table = adapter.GetData();
                table.DefaultView.Sort = "ATDescription";
                return table;
            }
        }
    }
}

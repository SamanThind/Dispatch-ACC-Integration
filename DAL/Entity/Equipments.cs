using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Truck_Trailer
    {
        public long vehicleId { get; set; }
        public string vin { get; set; }
        public long carrierId { get; set; }
        public string unitNumber { get; set; }
        public string plateNumber { get; set; }
        public long companyId { get; set; }
    }

    public class Driver
    {
        public long DriverId { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public long carrierId { get; set; }
        public string carrierName { get; set; }
        public long sinno { get; set; }
        public string drivinglicensenumber { get; set; }
    }
}

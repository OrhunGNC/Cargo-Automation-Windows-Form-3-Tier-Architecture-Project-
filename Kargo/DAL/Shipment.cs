using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Shipment
    {
        public int shipmentID { get; set; }
        public string shipmentName { get; set; }
        public string shipmentPickupPoint { get; set; }
        public string shipmentTransportationPoint { get; set; }
        public int shipmentDistance { get; set; }
        public decimal shipmentFee { get; set; }
        public int customerID { get; set; }
        public int personelID { get; set; }
        public int vehicleID { get; set; }


    }
}

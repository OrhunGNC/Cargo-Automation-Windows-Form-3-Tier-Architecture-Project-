using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Customer
    {
        public int customerID { get; set; }
        public string customerNameSurname { get; set; }
        public string customerAdress { get; set; }
        public string customerPhone { get; set; }
        public string customerMail { get; set;}
        public string customerPaymentStatus { get; set;}

    }
}

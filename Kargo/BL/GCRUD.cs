using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BL
{
    public class GCRUD
    {
        public static DataTable CustomerList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("CustomerList",Tools.coon);
            adapter.SelectCommand.CommandType=System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
                
        }
        public static bool CustomerAdd(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("CustomerAdd", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerNameSurname", customer.customerNameSurname);
            cmd.Parameters.AddWithValue("@customerAdress", customer.customerAdress);
            cmd.Parameters.AddWithValue("@customerPhone", customer.customerPhone);
            cmd.Parameters.AddWithValue("@customerMail", customer.customerMail);
            cmd.Parameters.AddWithValue("@customerPaymentStatus", customer.customerPaymentStatus);
            return Tools.ConnectSet(cmd);
        }
        public static bool CustomerUpdate(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("CustomerUpdate", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerID", customer.customerID);
            cmd.Parameters.AddWithValue("@customerNameSurname", customer.customerNameSurname);
            cmd.Parameters.AddWithValue("@customerAdress", customer.customerAdress);
            cmd.Parameters.AddWithValue("@customerPhone", customer.customerPhone);
            cmd.Parameters.AddWithValue("@customerMail", customer.customerMail);
            cmd.Parameters.AddWithValue("@customerPaymentStatus", customer.customerPaymentStatus);
            return Tools.ConnectSet(cmd);
        }
        public static bool CustomerDel(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("CustomerDel", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerID", customer.customerID);
            return Tools.ConnectSet(cmd);
        }
        public static DataTable CustomerSearch(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("CustomerSearch", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerNameSurname", customer.customerNameSurname);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable PersonelList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("PersonelList", Tools.coon);
            adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static bool PersonelAdd(Personel personel)
        {
            SqlCommand cmd = new SqlCommand("PersonelAdd", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@personelNameSurname", personel.personelNameSurname);
            cmd.Parameters.AddWithValue("@personelTask", personel.personelTask);
            cmd.Parameters.AddWithValue("@personelTitle", personel.personelTitle);
            cmd.Parameters.AddWithValue("@personelPhone", personel.personelPhone);
            cmd.Parameters.AddWithValue("@personelMail", personel.personelMail);
            cmd.Parameters.AddWithValue("@personelSalary", personel.personelSalary);
            return Tools.ConnectSet(cmd);
        }
        public static bool PersonelUpdate(Personel personel)
        {
            SqlCommand cmd = new SqlCommand("PersonelUpdate", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@personelID", personel.personelID);
            cmd.Parameters.AddWithValue("@personelNameSurname", personel.personelNameSurname);
            cmd.Parameters.AddWithValue("@personelTask", personel.personelTask);
            cmd.Parameters.AddWithValue("@personelTitle", personel.personelTitle);
            cmd.Parameters.AddWithValue("@personelPhone", personel.personelPhone);
            cmd.Parameters.AddWithValue("@personelMail", personel.personelMail);
            cmd.Parameters.AddWithValue("@personelSalary", personel.personelSalary);
            return Tools.ConnectSet(cmd);
        }
        public static bool PersonelDel(Personel personel)
        {
            SqlCommand cmd = new SqlCommand("PersonelDel", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@personelID", personel.personelID);
            return Tools.ConnectSet(cmd);
        }
        public static DataTable PersonelSearch(Personel personel)
        {
            SqlCommand cmd = new SqlCommand("PersonelSearch", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@personelNameSurname", personel.personelNameSurname);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable ShipmentList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("ShipmentList", Tools.coon);
            adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static bool ShipmentAdd(Shipment shipment)
        {
            SqlCommand cmd = new SqlCommand("ShipmentAdd", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentName", shipment.shipmentName);
            cmd.Parameters.AddWithValue("@shipmentPickupPoint", shipment.shipmentPickupPoint);
            cmd.Parameters.AddWithValue("@shipmentTransportationPoint", shipment.shipmentTransportationPoint);
            cmd.Parameters.AddWithValue("@shipmentDistance", shipment.shipmentDistance);
            cmd.Parameters.AddWithValue("@shipmentFee", shipment.shipmentFee);
            cmd.Parameters.AddWithValue("@customerID", shipment.customerID);
            cmd.Parameters.AddWithValue("@personelID", shipment.personelID);
            cmd.Parameters.AddWithValue("@vehicleID", shipment.vehicleID);
            return Tools.ConnectSet(cmd);
        }
        public static bool ShipmentUpdate(Shipment shipment)
        {
            SqlCommand cmd = new SqlCommand("ShipmentUpdate", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentID", shipment.shipmentID);
            cmd.Parameters.AddWithValue("@shipmentName", shipment.shipmentName);
            cmd.Parameters.AddWithValue("@shipmentPickupPoint", shipment.shipmentPickupPoint);
            cmd.Parameters.AddWithValue("@shipmentTransportationPoint", shipment.shipmentTransportationPoint);
            cmd.Parameters.AddWithValue("@shipmentDistance", shipment.shipmentDistance);
            cmd.Parameters.AddWithValue("@shipmentFee", shipment.shipmentFee);
            cmd.Parameters.AddWithValue("@customerID", shipment.customerID);
            cmd.Parameters.AddWithValue("@personelID", shipment.personelID);
            cmd.Parameters.AddWithValue("@vehicleID", shipment.vehicleID);
            return Tools.ConnectSet(cmd);
        }
        public static bool ShipmentDel(Shipment shipment)
        {
            SqlCommand cmd = new SqlCommand("ShipmentDel", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentID", shipment.shipmentID);
            return Tools.ConnectSet(cmd);
        }
        public static DataTable ShipmentSearch(Shipment shipment)
        {
            SqlCommand cmd = new SqlCommand("ShipmentSearch", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentName", shipment.shipmentName);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable VehicleList()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("VehicleList", Tools.coon);
            adapter.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable VehicleSearch(Vehicle vehicle)
        {
            SqlCommand cmd = new SqlCommand("VehicleSearch", Tools.coon);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.Add("@vehicleName", vehicle.vehicleName);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static bool VehicleAdd(Vehicle vehicle)
        {
            SqlCommand cmd = new SqlCommand("VehicleAdd", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@vehicleName", vehicle.vehicleName);
            cmd.Parameters.AddWithValue("@vehicleCapacity", vehicle.vehicleCapacity);
            cmd.Parameters.AddWithValue("@vehicleDriver", vehicle.vehicleDriver);
            cmd.Parameters.AddWithValue("@vehicleExpense", vehicle.vehicleExpense);
            return Tools.ConnectSet(cmd);
        }
        public static bool VehicleUpdate(Vehicle vehicle)
        {
            SqlCommand cmd = new SqlCommand("VehicleUpdate", Tools.coon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@vehicleID", vehicle.vehicleID);
            cmd.Parameters.AddWithValue("@vehicleName", vehicle.vehicleName);
            cmd.Parameters.AddWithValue("@vehicleCapacity", vehicle.vehicleCapacity);
            cmd.Parameters.AddWithValue("@vehicleDriver", vehicle.vehicleDriver);
            cmd.Parameters.AddWithValue("@vehicleExpense", vehicle.vehicleExpense);
            return Tools.ConnectSet(cmd);
        }
    }
}

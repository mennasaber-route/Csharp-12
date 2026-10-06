using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11
{
    public static class DeliveryReport
    {
        public static void PrintShipment(
            ITrackable shipment)
        {
            Console.WriteLine(
                shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(
            IInsurable shipment)
        {
            Console.WriteLine(
                $"Insurance : {shipment.CalculateInsurance():0.00} EGP");
        }
    }

}

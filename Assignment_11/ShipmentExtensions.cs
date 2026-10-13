using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_11
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string shipmentType = shipment switch
            {
                StandardShipment => "Standard",
                ExpressShipment => "Express",
                InternationalShipment => "International",
                _ => shipment.GetType().Name
            };

            return $"{shipment.TrackingCode} | " +
                   $"{shipmentType} | " +
                   $"{shipment.Weight:0.##} KG | " +
                   $"{shipment.GetTrackingStatus()}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.GetTrackingStatus() == "Delivered";
        }


    }

}


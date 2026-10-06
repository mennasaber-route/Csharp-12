using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal _extraFee;

        public decimal ExtraFee { get; set; }
        public ExpressShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            decimal extraFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            if (extraFee >= 0)
            {
                ExtraFee = extraFee;
            }
            else
            {
                ExtraFee = 0;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5) + ExtraFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Express Shipment");
            Console.WriteLine(
                $"Tracking Code : {TrackingCode}");
            Console.WriteLine(
                $"Extra Fee : {ExtraFee} EGP");
            Console.WriteLine(
                $"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";
        }


        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

    }

}

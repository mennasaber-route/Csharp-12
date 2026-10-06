using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string DestinationCountry { get; set; }

        public decimal CustomsFee { get; set; }


        public InternationalShipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination,
            string destinationCountry,
            decimal customsFee)
            : base(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination)
        {
            DestinationCountry = destinationCountry;

            if (customsFee >= 0)
            {
                CustomsFee = customsFee;
            }
            else
            {
                CustomsFee = 0;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + ((decimal)Weight * 5) + CustomsFee;
            }
        }


        public override void PrintShipment()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("International Shipment");
            Console.WriteLine(
                $"Tracking Code : {TrackingCode}");
            Console.WriteLine(
                $"Destination Country : {DestinationCountry}");
            Console.WriteLine(
                $"Estimated Cost : {EstimatedCost} EGP");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine(
                $"Customs Report for {DestinationCountry}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }


    }

}

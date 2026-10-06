using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11
{
    public abstract class Shipment
    {
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;


        public string TrackingCode
        {
            get
            {
                return _trackingCode;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingCode = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public decimal Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return _deliveryFee;
            }

            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        //public DeliveryAddress Destination { get; set; }
        public DeliveryAddress DeliveryAddress { get; set; }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            _trackingCode = "Unknown";
            _description = "Unknown";
            _weight = 1;
            _deliveryFee = 50;

            //Destination = destination;
            DeliveryAddress = destination;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
                Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            decimal totalWeight = newWeight + extraPackingWeight;

            if (totalWeight > 0)
                Weight = totalWeight;
        }

        public abstract decimal EstimatedCost { get; }

        public abstract void PrintShipment();

        public virtual Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment deepCopy = (Shipment)MemberwiseClone();

            deepCopy.DeliveryAddress = new DeliveryAddress(
                DeliveryAddress.City,
                this.DeliveryAddress.Street,
                this.DeliveryAddress.BuildingNumber
            );
            return deepCopy;
        }


    }
}

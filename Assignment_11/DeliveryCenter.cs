using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_11
{
    public class DeliveryCenter
    {
        private Shipment[] _shipments;
        public string CenterName { get; set; }
        public Driver AssignedDriver { get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            _shipments = new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }

                return null;
            }

            set
            {
                if (index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i] != null &&
                        _shipments[i].TrackingCode == trackingCode)
                    {
                        return _shipments[i];
                    }
                }

                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null)
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null &&
                    _shipments[i].TrackingCode == trackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null)
                {
                    _shipments[i].PrintShipment();
                }
            }
        }

        public void PrintTrackingStatuses()
        {
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null)
                {
                    ITrackable trackable =
                        (ITrackable)_shipments[i];

                    Console.WriteLine(
                        trackable.GetTrackingStatus());
                }
            }
        }


    }

}

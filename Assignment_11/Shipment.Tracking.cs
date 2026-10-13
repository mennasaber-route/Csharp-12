using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment_11
{
    public abstract partial class Shipment
    {
        public string TrackingStatus { get; private set; } = "In Transit";

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (string.IsNullOrWhiteSpace(newStatus))
            {
                return;
            }

            TrackingStatus = newStatus;
            OnTrackingStatusChanged(newStatus);
        }

        protected void SetInitialTrackingStatus(string status)
        {
            if (!string.IsNullOrWhiteSpace(status))
            {
                TrackingStatus = status;
            }
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }


}

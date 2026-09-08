using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal abstract partial class Shipment
    {
        private string trackingStatus = "In Transit";

        public string GetTrackingStatus()
        {
            return trackingStatus;
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                trackingStatus = newStatus;

                OnTrackingStatusChanged(newStatus);
            }
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }
}
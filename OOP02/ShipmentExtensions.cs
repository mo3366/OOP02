using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string shipmentType = shipment.GetType().Name
                .Replace("Shipment", "");

            string trackingStatus =
                ((ITrackable)shipment).GetTrackingStatus();

            return $"{shipment.TrackingCode} | " +
                   $"{shipmentType} | " +
                   $"{shipment.Weight} KG | " +
                   $"{trackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            string trackingStatus =
                ((ITrackable)shipment).GetTrackingStatus();

            return trackingStatus == "Delivered";
        }
    }
}

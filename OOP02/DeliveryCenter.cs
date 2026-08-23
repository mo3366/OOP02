using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal struct DeliveryCenter
    {
        #region 5. Create a DeliveryCenter struct
        private Shipment[] shipments;

        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }


        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return default;
            }

            set
            {
                if (index >= 0 && index < shipments.Length)
                    shipments[index] = value;
            }
        }


        public Shipment this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                    return default;

                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }

                return default;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(shipments[i].TrackingCode))
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        #endregion
    }
}

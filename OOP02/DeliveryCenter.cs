using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class DeliveryCenter
    {
        private string centerName;

        public Driver Driver { get; set; }

        #region 5. Create a DeliveryCenter class
        private Shipment[] shipments;

        public DeliveryCenter(string centerName)
        {
            this.centerName = centerName;
            shipments = new Shipment[20];
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
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        #endregion

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        public void PrintAllShipments()
        {
            foreach (Shipment s in shipments)
            {
                if (s != null)
                {
                    s.PrintShipment();
                }
            }
        }


       public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in shipments)
            {
                if (t != null)
                {
                    Console.WriteLine(t.GetTrackingStatus());
                }
            }
        }

        public void PrintCalculateInsurance()
        {
            foreach (IInsurable i in shipments)
            {
                if (i != null)
                {
                    Console.WriteLine(i.CalculateInsurance());
                }
            }
        }

    }
}

using OOP02;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class Shipment
    {
        #region 2.Ceate a Shipment struct
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = "";
            this.description = "";
            this.weight = 0;
            this.deliveryFee = 0;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public DeliveryAddress Destination { get; set; }

        // Read-only from outside
        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        // Read/Write with validation
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        // Read/Write with validation
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        // Public getter, private setter
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        // calculated property 
        public virtual decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }



        #endregion

        #region 2. Add constructor overloading to Shipment
        // first Constructor 
        public Shipment(string trackingCode)
        {

            this.trackingCode = trackingCode;
            this.description = "Unknown";
            this.Weight = 1;
            this.DeliveryFee = 50;
            this.Destination = new DeliveryAddress("Cairo", "Unknown Street", 1);

        }

     
        #endregion


        #region 3. Add the following methods to Shipment

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee =  newFee;
            }
        }


        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }

        public void UpdateWeight(decimal newWeight, decimal packingWeight)
        {
            if (newWeight > 0 && packingWeight > 0)
            {
                Weight = newWeight + packingWeight;
            }
        }



        public virtual void PrintShipment()
        {
            Console.WriteLine("Shipment Information:");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP02
{
    internal class InternationalShipment :Shipment
    {
        private string destinationCountry;
        private decimal customsFee;


        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination , string destinationCountry, decimal customsFee)
           : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.destinationCountry = destinationCountry;
            this.customsFee = customsFee;
        }

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get
            {
                return base.EstimatedCost + CustomsFee;
            }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Weight : {Weight} KG");
            Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Customs Fee : {CustomsFee} EGP");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP");
        }

    }
}
